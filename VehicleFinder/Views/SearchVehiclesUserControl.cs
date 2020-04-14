using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VehicleFinder.Data;
using VehicleFinder.Models;
using VehicleFinder.Models.Enums;
using VehicleFinder.ViewModels;

namespace VehicleFinder.Views
{
    public partial class SearchVehiclesUserControl : UserControl
    {
        private Dictionary<string, Func<string, Vehicle, bool>> _filterDictionary =
            new Dictionary<string, Func<string, Vehicle, bool>>();
        private List<string> _engineTypes;
        private List<string> _bodyStyles;
        private List<string> _yearRange;

        public SearchVehiclesUserControl()
        {
            InitializeComponent();
        }

        private void SearchVehiclesUserControl_Load(object sender, EventArgs e)
        {
            InitChoiceLists();
            LoadSearchCriteria();
            LoadExtrasCheckedList();
            InitFilterDictionary();
        }

        private void InitChoiceLists()
        {
            _engineTypes = new List<string>()
            {
                EngineType.Diesel.ToString(),
                EngineType.Electric.ToString(),
                EngineType.Gas.ToString(),
                EngineType.Hybrid.ToString(),
                EngineType.Petrol.ToString(),
                EngineType.PetrolAndGas.ToString()
            };

            _bodyStyles = new List<string>()
            {
                BodyStyle.Cabriolet.ToString(),
                BodyStyle.Coupe.ToString(),
                BodyStyle.Hatchback.ToString(),
                BodyStyle.Kombi.ToString(),
                BodyStyle.Minivan.ToString(),
                BodyStyle.Sedan.ToString()
            };


            _yearRange = new List<string>();
            _yearRange.AddRange(Enumerable.Range(1900, 121)
                        .Select(x => x.ToString())
                        .Reverse()
                        .ToArray());
        }

        private void LoadSearchCriteria()
        {
            searchCriteriaComboBox.Items.AddRange(new string[]
            {
                "Brand",
                "Model",
                "Engine name",
                "Engine type",
                "Extras",
                "Body style",
                "Manufacture year"
            });
        }

        private void LoadExtrasCheckedList()
        {
            //searchCriteriaCheckedListBox.Items.AddRange(new string[]
            //{
            //    "Leather upholstery",
            //    "Heated seats/steering wheel",
            //    "Panoramic roof",
            //    "Reversing camera",
            //    "Dashcam",
            //    "Sat-nav"
            //});

            searchCriteriaCheckedListBox.Items.AddRange(new string[]
            {
                "Leather Upholstery",
                "Heated Seats",
                "Panoramic Roof",
                "Reversing Camera",
                "Dashcam",
                "Navigation"
            });
        }

        private void InitFilterDictionary()
        {
            _filterDictionary.Add("Brand",
                (string c, Vehicle v) => { return v.Brand.Name.Equals(c); });
            _filterDictionary.Add("Model",
                (string c, Vehicle v) => { return v.Model.Name.Equals(c); });
            _filterDictionary.Add("Engine name",
                (string c, Vehicle v) => { return v.Engine.Name.Equals(c); });
            _filterDictionary.Add("Engine type",
                (string c, Vehicle v) => { return v.Engine.EngineType.Equals(Enum.Parse(typeof(EngineType), c)); });
            // Change according to searchCriteriaCheckedListBox.Items
            _filterDictionary.Add("Leather Upholstery", ApplyCriteriaForExtra);
            _filterDictionary.Add("Heated Seats", ApplyCriteriaForExtra);
            _filterDictionary.Add("Panoramic Roof", ApplyCriteriaForExtra);
            _filterDictionary.Add("Reversing Camera", ApplyCriteriaForExtra);
            _filterDictionary.Add("Dashcam", ApplyCriteriaForExtra);
            _filterDictionary.Add("Navigation", ApplyCriteriaForExtra);
            _filterDictionary.Add("Body style",
                (string c, Vehicle v) => { return v.BodyStyle.ToString().Equals(c); });
            _filterDictionary.Add("Manufacture year",
                (string c, Vehicle v) => { return v.ManufactureYear == int.Parse(c); });
        }

        private void LoadEngineTypes()
        {
            searchCriteriaInputComboBox.DataSource = _engineTypes;
            searchCriteriaInputComboBox.Visible = true;
        }

        private void LoadBodyStyles()
        {
            searchCriteriaInputComboBox.DataSource = _bodyStyles;
            searchCriteriaInputComboBox.Visible = true;
        }

        private void LoadYearRange()
        {
            searchCriteriaInputComboBox.DataSource = _yearRange;
            searchCriteriaInputComboBox.Visible = true;
        }

        private bool ApplyCriteriaForExtra(string extraName, Vehicle vehicle)
        {
            return vehicle.Extras.Any(e => e.Name.Equals(extraName));
        }

        private List<Vehicle> ApplyCriteria(List<Vehicle> vehicles)
        {
            List<string> criteriaList = criteriaListBox.Items.Cast<string>().ToList();
            var criteriaDictionary = CreateCriteriaDictionary(criteriaList);
            foreach (var pair in criteriaDictionary)
            {
                vehicles = vehicles.FindAll(v => _filterDictionary[pair.Key](pair.Value, v));
            }
            return vehicles;
        }

        private Dictionary<string, string> CreateCriteriaDictionary(List<string> criteriaList)
        {
            return criteriaList.Select(c =>
            {
                string key = c.Split(':')[0], value = c.Split(':')[1];
                if (key.Equals("Extras"))
                    key = value;
                return new KeyValuePair<string, string>(key, value);
            }).ToDictionary(c => c.Key, c => c.Value);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (criteriaListBox.Items.Count == 0)
            {
                DisplayErrorMessage("You have not added any search criteria!");
            }
            else
            {
                List<Vehicle> vehicles = FetchVehicles();
                var result = ApplyCriteria(vehicles);
                MapResultToViewAndDisplay(result);
                ReloadSearch();
            }
        }

        private List<Vehicle> FetchVehicles()
        {
            List<Vehicle> vehicles;
            using (var db = new AppDbContext())
            {
                vehicles = db.Vehicles.Include(v => v.Brand)
                    .Include(v => v.Model)
                    .Include(v => v.Engine)
                    .Include(v => v.Extras)
                    .ToList();
            }
            return vehicles;
        }

        private void MapResultToViewAndDisplay(List<Vehicle> result)
        {
            if (!result.Any())
            {
                DisplayErrorMessage("No results found for selected criteria!");
                resultDataGrid.DataSource = null;
            }
            else
            {
                var displayList = result.Select(v =>
                new DisplayVehicleViewModel()
                {
                    Brand = v.Brand.Name,
                    Model = v.Model.Name + " " + v.Model.Year,
                    ManufactureYear = v.ManufactureYear.ToString(),
                    BodyStyle = v.BodyStyle.ToString(),
                    Engine = v.Engine.Name + " " + v.Engine.EngineType,
                    HorsePower = v.HorsePower.ToString(),
                    Extras = (v.Extras.Count != 0) ? string.Join(", ", v.Extras) : "None"
                }).ToList();
                resultDataGrid.DataSource = displayList;
            }
        }

        private void addCriteria_Click(object sender, EventArgs e)
        {
            var selectedCriteria = searchCriteriaComboBox.SelectedItem.ToString();
            var selectedCriteriaIndex = searchCriteriaComboBox.SelectedIndex;

            switch (selectedCriteria)
            {
                case "Engine type":
                case "Body style":
                case "Manufacture year":
                    if (searchCriteriaInputComboBox.SelectedItem == null)
                    {
                        DisplayErrorMessage("Please select a search criteria value.");
                        return;
                    }
                    AddCriteriaToList(selectedCriteria, searchCriteriaInputComboBox.SelectedItem.ToString());
                    break;

                case "Extras":
                    var selectedExtras = searchCriteriaCheckedListBox.CheckedItems;
                    if (selectedExtras.Count == 0)
                    {
                        DisplayErrorMessage("Please select search criteria values.");
                        return;
                    }
                    AddCriteriaToList(selectedCriteria,
                        new List<string>(searchCriteriaCheckedListBox.CheckedItems.Cast<string>()));
                    break;

                default:
                    if (searchCriteriaInputTextBox.Text.Equals(string.Empty))
                    {
                        DisplayErrorMessage("Please enter a search criteria value.");
                        return;
                    }
                    AddCriteriaToList(selectedCriteria, searchCriteriaInputTextBox.Text.ToString());
                    break;
            }
            RemoveCriteria(selectedCriteriaIndex);
            DisableCriteriaSelection();
        }

        private void RemoveCriteria(int selectedCriteriaIndex)
        {
            searchCriteriaComboBox.Items.RemoveAt(selectedCriteriaIndex);
        }

        private void AddCriteriaToList(string selectedCriteria, List<string> values)
        {
            foreach (string value in values)
                criteriaListBox.Items.Add(selectedCriteria + ":" + value);
        }

        private void AddCriteriaToList(string selectedCriteria, string value)
        {
            criteriaListBox.Items.Add(selectedCriteria + ":" + value);
        }

        private void searchCriteriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCriteriaSelection();
            DisableCriteriaSelection();
            var selectedCriteria = searchCriteriaComboBox.SelectedItem.ToString();
            EnableCriteriaSelection(selectedCriteria);
            switch (selectedCriteria)
            {
                case "Engine type":
                    LoadEngineTypes();
                    break;
                case "Body style":
                    LoadBodyStyles();
                    break;
                case "Manufacture year":
                    LoadYearRange();
                    break;
                case "Extras":
                    searchCriteriaCheckedListBox.Visible = true;
                    break;
                default:
                    searchCriteriaInputTextBox.Visible = true;
                    break;
            }
        }

        private void EnableCriteriaSelection(string selectedCriteria)
        {
            criteriaName.Text = selectedCriteria;
            criteriaName.Visible = true;
            addCriteria.Enabled = true;
        }

        private void ClearCriteriaSelection()
        {
            criteriaName.Text = string.Empty;
            searchCriteriaInputComboBox.DataSource = null;
            searchCriteriaInputTextBox.Clear();
            searchCriteriaCheckedListBox.ClearSelected();
        }

        private void DisableCriteriaSelection()
        {
            criteriaName.Visible = false;
            searchCriteriaInputComboBox.Visible = false;
            searchCriteriaInputTextBox.Visible = false;
            searchCriteriaCheckedListBox.Visible = false;
            addCriteria.Enabled = false;
        }

        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Error.", MessageBoxButtons.OK);
        }

        private void ReloadSearch()
        {
            DisableCriteriaSelection();
            ClearCriteriaSelection();
            searchCriteriaComboBox.Items.Clear();
            criteriaListBox.Items.Clear();
            LoadSearchCriteria();
        }
    }
}
