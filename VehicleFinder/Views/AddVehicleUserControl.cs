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
        private readonly VehicleService _vehicleService;

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
            manfactureYearComboBox.Items.AddRange(years);
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
            int horsePowers;
            var isHorsePowerParseble = int.TryParse(horsePowersTextBox.Text, out horsePowers);

            if (!isHorsePowerParseble) 
            {
                errorMessage.Text = "Please enter valid horse powers value.";
                return;
            }

            if (manfactureYearComboBox.SelectedItem == null) 
            {
                errorMessage.Text = "Please pick the year of manufacturing.";
                return;
            }

            if (modelYearComboBox.SelectedItem == null)
            {
                errorMessage.Text = "Please pick the year of model.";
                return;
            }

            if (bodyStyleComboBox.SelectedItem == null)
            {
                errorMessage.Text = "Please pick the body style of the vehicle.";
                return;
            }

            if (engineComboBox.SelectedItem == null)
            {
                errorMessage.Text = "Please pick the engine type of the vehicle.";
                return;
            }

            var addVehicleViewModel = new AddVehicleViewModel()
            {
                Brand = brandTextBox.Text,
                Model = modelTextBox.Text,
                HorsePower = horsePowers,
                EngineName = engineNameTextBox.Text,
                EngineType = engineComboBox.Text,
                ManufactureYear = int.Parse(manfactureYearComboBox.Text),
                ModelYear = int.Parse(modelYearComboBox.Text),
                BodyStyle = bodyStyleComboBox.Text,
                HasLeatherUpholstery = leatherUpholsteryCheckBox.Checked,
                HasHeatedSeats = heatedPartsCheckBox.Checked,
                HasPanoramicRoof = panoramicRoofCheckBox.Checked,
                HasReversingCamera = reversingCameraCheckBox.Checked,
                HasDashcam = dashcamCheckBox.Checked,
                HasNavigation = satNavCheckBox.Checked
        };
            var errorMessages = addVehicleViewModel.getValidationErrors();
            if (errorMessages.Any())
            {
                errorMessage.Text = errorMessages.First();
                return;
            }
            else {
                errorMessage.Text = "";
            }

            var result = _vehicleService.AddVehicle(addVehicleViewModel);
            if (result) 
            {
                clearDialog();
            }
        }

        private void clearDialog()
        {
            throw new NotImplementedException();
        }

        private void modelYearComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var modelYear = int.Parse(modelYearComboBox.SelectedItem.ToString());

            manfactureYearComboBox.Enabled = true;
            manfactureYearComboBox.Items.Clear();
            manfactureYearComboBox.Items.AddRange(Enumerable.Range(modelYear, 2021-modelYear).Select(x => x.ToString()).Reverse().ToArray());
        }
    }
}
