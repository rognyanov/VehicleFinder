using System;
namespace VehicleFinder
{
    using System.Windows.Forms;
    using VehicleFinder.Views;

    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void addVehicleMenu_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new AddVehicleUserControl());
        }

        private void searchVehicleMenu_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new SearchVehiclesUserControl());
        }
    }
}
