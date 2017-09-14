using System;
using System.Net;
using System.Windows.Forms;
using EcoCityUser.Models;
using EcoCityUser.Properties;

namespace EcoCityUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeElements();

            var lat = new Latitude();
        }

        private void InitializeElements()
        {
            cmb_category.Items.Add("illegal_dump");
            cmb_category.Items.Add("graphites");
            cmb_category.Items.Add("not_working_street_light");
            cmb_category.Items.Add("broken_sidewalk_tiles");

            cmb_category.SelectedIndex = 0;
        }

        private async void OnCreateUserInput(object sender, EventArgs e)
        {
            var category = new Category { Value = cmb_category.Text };
            var description = new Description { Value = txt_description.Text };

            var userInputModel = new UserInputModel
            {
                Category = category,
                Description = description
            };

            ShowSentData(userInputModel);

            var httpHelper = new HttpHelper();
            await httpHelper.PostSensorData(userInputModel);

            Settings.Default.UserInputId += 1;
            Settings.Default.Save();
        }


        private void ShowSentData(UserInputModel model)
        {
            labCategory.Text = model.Category.Value;
            labDateTime.Text = model.DateTimeObject.Value;
            labLatLong.Text = $"{model.Latitude.Value} / {model.Longitude.Value}";
            labDesc.Text = model.Description.Value;
        }
    }
}

