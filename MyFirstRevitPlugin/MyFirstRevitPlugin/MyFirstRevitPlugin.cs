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
        private const double ZCoordinateValue = 0.000000000;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            //Get application and document objects
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uiapp.ActiveUIDocument.Document;
            Selection selection = uidoc.Selection;

            Reference pickedref = null;

            //set up form and ask for coordinates from the user
            GenerateWallForm generateWallForm = new GenerateWallForm(commandData);
            generateWallForm.ShowDialog();

            //grab string values
            string XCoordinateString1 = generateWallForm.XCoordinateValue1.ToString();
            string YCoordinateString1 = generateWallForm.YCoordinateValue1.ToString();

            string XCoordinateString2 = generateWallForm.XCoordinateValue2.ToString();
            string YCoordinateString2 = generateWallForm.YCoordinateValue2.ToString();

            //convert them to their respective types
            double doubleXCoordinateValue1 = double.Parse(XCoordinateString1);
            double doubleYCoordinateValue1 = double.Parse(YCoordinateString1);

            double doubleXCoordinateValue2 = double.Parse(XCoordinateString2);
            double doubleYCoordinateValue2 = double.Parse(YCoordinateString2);

            //Construct XYZ value:
            XYZ First3DLocationOfWall = new XYZ(doubleXCoordinateValue1, doubleYCoordinateValue1, ZCoordinateValue);
            XYZ Second3DLocationOfWall = new XYZ(doubleXCoordinateValue2, doubleYCoordinateValue2, ZCoordinateValue);

            //Create Line
            Curve wallLine = Line.CreateBound(First3DLocationOfWall, Second3DLocationOfWall);

            //Take level from wall selected
            //User has to select a wall

            //Ask the user to select an element which the program will use to get the levelId
            pickedref = selection.PickObject(ObjectType.Element, "Please select an element to acquire LevelId");
            Element elem = doc.GetElement(pickedref);
            ElementId levelId = elem.LevelId;

            Transaction trans = new Transaction(doc);
            trans.Start("Lab");
            trans.Commit();

            return Result.Succeeded;
        }
        }
    }