using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VehicleFinder.Models.Enums;
using VehicleFinder.Services;
using VehicleFinder.ViewModels;

namespace VehicleFinder.Views
{
    public partial class AddVehicleUserControl : UserControl
    {
        private VehicleService _vehicleService;

        public AddVehicleUserControl()
        {
            _vehicleService = new VehicleService();

            InitializeComponent();
            InitializeEngineComboBox();
            InitializeBodyStyleComboBox();
            InitializeYersComboBox();
        }

        private void InitializeYersComboBox()
        {
            var years = Enumerable.Range(1900, 121)
                .Select(x => x.ToString())
                .Reverse()
                .ToArray();

            manfactureYearComboBox.Enabled = false;
            modelYearComboBox.Items.AddRange(years);
        }

        private void InitializeBodyStyleComboBox()
        {
            List<string> bodyStyles = new List<string>();
            bodyStyles.Add(BodyStyle.Cabriolet.ToString());
            bodyStyles.Add(BodyStyle.Coupe.ToString());
            bodyStyles.Add(BodyStyle.Hatchback.ToString());
            bodyStyles.Add(BodyStyle.Kombi.ToString());
            bodyStyles.Add(BodyStyle.Minivan.ToString());
            bodyStyles.Add(BodyStyle.Sedan.ToString());

            bodyStyleComboBox.DataSource = bodyStyles;
        }

        private void InitializeEngineComboBox()
        {
            List<string> engines = new List<string>();
            engines.Add(EngineType.Diesel.ToString());
            engines.Add(EngineType.Electric.ToString());
            engines.Add(EngineType.Gas.ToString());
            engines.Add(EngineType.Hybrid.ToString());
            engines.Add(EngineType.Petrol.ToString());
            engines.Add(EngineType.PetrolAndGas.ToString());

            engineComboBox.DataSource = engines;
        }

        private void addNewCar_Click(object sender, EventArgs e)
        {
            if (!inputIsValid())
                return;

            var viewModel = new AddVehicleViewModel()
            {
                Brand = brandTextBox.Text,
                Model = modelTextBox.Text,
                HorsePower = int.Parse(horsePowersTextBox.Text),
                EngineName = engineNameTextBox.Text,
                EngineType = engineComboBox.Text,
                ManufactureYear = int.Parse(manfactureYearComboBox.SelectedItem.ToString()),
                ModelYear = int.Parse(modelYearComboBox.SelectedItem.ToString()),
                BodyStyle = bodyStyleComboBox.SelectedItem.ToString(),
                HasLeatherUpholstery = leatherUpholsteryCheckBox.Checked,
                HasHeatedSeats = heatedPartsCheckBox.Checked,
                HasPanoramicRoof = panoramicRoofCheckBox.Checked,
                HasReversingCamera = reversingCameraCheckBox.Checked,
                HasDashcam = dashcamCheckBox.Checked,
                HasNavigation = satNavCheckBox.Checked
            };

            if (!modelIsValid(viewModel))
                return;

            PostExecute(_vehicleService.AddVehicle(viewModel));
        }

        private void PostExecute(bool isAdded)
        {
            if (isAdded)
            {
                ResetDialog();
                MessageBox.Show("The vehicle has been added successfully.", "Vehicle Finder: Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error ocurred adding the vehicle. Please contact your support.", "Vehicle Finder: Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetDialog()
        {
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            horsePowersTextBox.Text = "0";
            engineNameTextBox.Text = "";
            engineComboBox.Text = "";
            manfactureYearComboBox.Text = "";
            manfactureYearComboBox.Enabled = false;
            modelYearComboBox.Text = "";
            bodyStyleComboBox.Text = "";
            leatherUpholsteryCheckBox.Checked = false;
            heatedPartsCheckBox.Checked = false;
            panoramicRoofCheckBox.Checked = false;
            reversingCameraCheckBox.Checked = false;
            dashcamCheckBox.Checked = false;
            satNavCheckBox.Checked = false;
        }

        private bool modelIsValid(AddVehicleViewModel viewModel)
        {
            var errorMessages = viewModel.getValidationErrors();

            if (errorMessages.Any())
            {
                errorMessage.Text = errorMessages.First();
                return false;
            }
            else
            {
                errorMessage.Text = "";
                return true;
            }
        }

        private bool inputIsValid()
        {
            int horsePowers;
            var isHorsePowerParseble = int.TryParse(horsePowersTextBox.Text, out horsePowers);

            if (!isHorsePowerParseble)
            {
                errorMessage.Text = "Please enter valid horse powers value.";
                return false;
            }

            if (manfactureYearComboBox.SelectedItem == null)
            {
                errorMessage.Text = "Please pick the year of manufacturing.";
                return false;
            }

            if (modelYearComboBox.SelectedItem == null)
            {
                errorMessage.Text = "Please pick the year of model.";
                return false;
            }

            if (bodyStyleComboBox.SelectedItem == null)
            {
                errorMessage.Text = "Please pick the body style of the vehicle.";
                return false;
            }

            if (engineComboBox.SelectedItem == null)
            {
                errorMessage.Text = "Please pick the engine type of the vehicle.";
                return false;
            }

            return true;
        }

        private void modelYearComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var modelYear = int.Parse(modelYearComboBox.SelectedItem.ToString());

            manfactureYearComboBox.Enabled = true;
            manfactureYearComboBox.Items.Clear();
            manfactureYearComboBox.Items.AddRange(Enumerable.Range(modelYear, 2021 - modelYear).Select(x => x.ToString()).Reverse().ToArray());
        }
    }
}
