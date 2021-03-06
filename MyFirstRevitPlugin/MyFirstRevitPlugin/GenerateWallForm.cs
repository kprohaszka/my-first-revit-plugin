using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace MyFirstRevitPlugin
{
    public partial class GenerateWallForm : System.Windows.Forms.Form
    {
        private UIApplication uiapp;
        private UIDocument uidoc;
        private Autodesk.Revit.ApplicationServices.Application app;
        private Document doc;

        public string XCoordinateValue1;
        public string YCoordinateValue1;
        public string XCoordinateValue2;
        public string YCoordinateValue2;

        public GenerateWallForm(ExternalCommandData commandData)
        {
            InitializeComponent();

            uiapp = commandData.Application;
            uidoc = uiapp.ActiveUIDocument;
            app = uiapp.Application;
            doc = uidoc.Document;
        }

        private void InformativeLebel6_Click(object sender, EventArgs e)
        {

        }

        private void InformativeLabel1_Click(object sender, EventArgs e)
        {

        }

        private void XCoordinateLabel_Click(object sender, EventArgs e)
        {

        }

        private void YCoordinateLabel_Click(object sender, EventArgs e)
        {

        }

        private void XCoordinateTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void YCoordinateTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void XCoordinateTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void YCoordinateTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformativeLabel2_Click(object sender, EventArgs e)
        {

        }

        private void InformativeLabel3_Click(object sender, EventArgs e)
        {

        }

        private void InformativeLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ActionCancelButton_Click(object sender, EventArgs e)
        {
            CancelButton.DialogResult = DialogResult.Cancel;
            Debug.WriteLine("Cancel Button Was Clicked");
        }

        private void GenerateWallButton_Click(object sender, EventArgs e)
        {
            XCoordinateValue1 = XCoordinateTextBox1.Text;
            YCoordinateValue1 = YCoordinateTextBox1.Text;

            XCoordinateValue2 = XCoordinateTextBox2.Text;
            YCoordinateValue2 = YCoordinateTextBox2.Text;

            GenerateWallButton.DialogResult = DialogResult.OK;
            Debug.WriteLine("Ok Button Was Clicked.");
            Close();

            return;
        }
    }
}
