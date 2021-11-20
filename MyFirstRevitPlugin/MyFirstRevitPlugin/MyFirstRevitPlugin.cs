using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace MyFirstRevitPlugin
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class MyFirstRevitPlugin : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Get application and document objects
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uiapp.ActiveUIDocument.Document;

            Reference pickedref = null;

            //set up form and ask for coordinates from the user
            GenerateWallForm generateWallForm = new GenerateWallForm(commandData);
            generateWallForm.ShowDialog();

            //grab string values
            string XCoordinateString1 = generateWallForm.XCoordinateValue1.ToString();
            string YCoordinateString1 = generateWallForm.YCoordinateValue1.ToString();

            string XCoordinateString2 = generateWallForm.XCoordinateValue2.ToString();
            string YCoordinateString2 = generateWallForm.YCoordinateValue2.ToString();

            Transaction trans = new Transaction(doc);
            trans.Start("Lab");
            trans.Commit();

            return Result.Succeeded;
        }
        }
    }