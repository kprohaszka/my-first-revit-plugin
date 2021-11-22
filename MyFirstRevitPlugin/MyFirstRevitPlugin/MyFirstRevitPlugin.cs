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
            string xCoordinateFromForm1 = generateWallForm.XCoordinateValue1.ToString();
            string yCoordinateFromForm1 = generateWallForm.YCoordinateValue1.ToString();

            string xCoordinateFromForm2 = generateWallForm.XCoordinateValue2.ToString();
            string yCoordinateFromForm2 = generateWallForm.YCoordinateValue2.ToString();

            //convert them to their respective types
            double xCoordinate1 = double.Parse(xCoordinateFromForm1);
            double yCoordinate1 = double.Parse(yCoordinateFromForm1);

            double xCoordinate2 = double.Parse(xCoordinateFromForm2);
            double yCoordinate2 = double.Parse(yCoordinateFromForm2);

            //Construct XYZ value:
            XYZ first3DLocationOfWall = new XYZ(xCoordinate1, yCoordinate1, ZCoordinateValue);
            XYZ second3DLocationOfWall = new XYZ(xCoordinate2, yCoordinate2, ZCoordinateValue);

            //Create Line
            Curve wallLine = Line.CreateBound(first3DLocationOfWall, second3DLocationOfWall);

            //Ask the user to select an element which the program will use to get the levelId
            pickedref = selection.PickObject(ObjectType.Element, "Please select an element to acquire LevelId");
            Element elem = doc.GetElement(pickedref);
            ElementId levelId = elem.LevelId;

            //Create Wall Between the two 3D Coordinates
            Transaction trans = new Transaction(doc);
            trans.Start("GenerateWall");
            Wall wall = Wall.Create(doc, wallLine, levelId, false);
            trans.Commit();

            return Result.Succeeded;
        }
        }
    }