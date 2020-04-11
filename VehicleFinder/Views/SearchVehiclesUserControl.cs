using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VehicleFinder.Models.Enums;

namespace VehicleFinder.Views
{
    public partial class SearchVehiclesUserControl : UserControl
    {

        public SearchVehiclesUserControl()
        {
            InitializeComponent();
        }

        private void SearchVehiclesUserControl_Load(object sender, EventArgs e)
        {
            var searchCriteria = new List<string>()
            {
                "Brand",
                "Model",
                "Engine name",
                "Engine type",
                "Extras",
                "Body style",
                "Manufacture year"
            };
            searchCriteriaComboBox.Items.AddRange(searchCriteria.ToArray());
            searchCriteriaCheckedListBox.Items.AddRange(new string[]
            {
                "Leather upholstery",
                "Heated seats/steering wheel",
                "Panoramic roof",
                "Reversing camera",
                "Dashcam",
                "Sat-nav"
            });
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void addCriteria_Click(object sender, EventArgs e)
        {
            var selectedCriteria = searchCriteriaComboBox.SelectedItem.ToString();
            string keyAndValueString = selectedCriteria + ":";
            switch (selectedCriteria)
            {
                case "Engine type":
                case "Body style":
                case "Manufacture year":
                    keyAndValueString += searchCriteriaInputComboBox.SelectedItem;
                    break;
                case "Extras":
                    foreach (string Extra in searchCriteriaCheckedListBox.CheckedItems)
                        criteriaListBox.Items.Add(keyAndValueString + Extra);
                    return;
                default:
                    keyAndValueString += searchCriteriaInputTextBox.Text;
                    break;
            }
            criteriaListBox.Items.Add(keyAndValueString);
        }

        private void searchCriteriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAndClearInput();
            var selectedCriteria = searchCriteriaComboBox.SelectedItem.ToString();
            criteriaName.Text = selectedCriteria;
            criteriaName.Visible = true;
            switch (selectedCriteria)
            {
                case "Engine type":
                    foreach (EngineType engineType in Enum.GetValues(typeof(EngineType)))
                        searchCriteriaInputComboBox.Items.Add(engineType.ToString());
                    searchCriteriaInputComboBox.Visible = true;
                    break;
                case "Body style":
                    foreach (BodyStyle bodyStyle in Enum.GetValues(typeof(BodyStyle)))
                        searchCriteriaInputComboBox.Items.Add(bodyStyle.ToString());
                    searchCriteriaInputComboBox.Visible = true;
                    break;
                case "Manufacture year":
                    searchCriteriaInputComboBox.Items.AddRange(Enumerable.Range(1900, 121)
                        .Select(x => x.ToString())
                        .Reverse()
                        .ToArray());
                    searchCriteriaInputComboBox.Visible = true;
                    break;
                case "Extras":
                    searchCriteriaCheckedListBox.Visible = true;
                    break;
                default:
                    searchCriteriaInputTextBox.Visible = true;
                    break;
            }
        }

        private void HideAndClearInput()
        {
            criteriaName.Text = string.Empty;
            searchCriteriaInputComboBox.Text = string.Empty;
            searchCriteriaInputComboBox.Items.Clear();
            searchCriteriaInputTextBox.Clear();
            searchCriteriaCheckedListBox.ClearSelected();
            criteriaName.Visible = false;
            searchCriteriaInputComboBox.Visible = false;
            searchCriteriaInputTextBox.Visible = false;
            searchCriteriaCheckedListBox.Visible = false;
        }
    }
}
