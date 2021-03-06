using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;

namespace MyFirstRevitPlugin
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class MyFirstRevitPlugin : IExternalCommand
    {
        private const double ZCoordinateValue = 0.000000000;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uiapp.ActiveUIDocument.Document;
            Selection selection = uidoc.Selection;

            try
            {

                (XYZ, XYZ) coordinates = GetCoordinatesFromUser(commandData);

                GenerateWall(coordinates, selection, doc);

                return Result.Succeeded;

            }
            catch (Exception exception)
            {
                message = exception.Message;
                return Result.Failed;
            }
        }


        public ElementId GetLevelId(Selection selection, Document doc)
        {
            Reference pickedref = selection.PickObject(ObjectType.Element,
                "Please select an element to acquire LevelId");
            Element elem = doc.GetElement(pickedref);
            return elem.LevelId;
        }

        public void GenerateWall((XYZ, XYZ) coordinates, Selection selection, Document doc)
        {

            Curve wallLine = Line.CreateBound(coordinates.Item1, coordinates.Item2);
            ElementId levelId = GetLevelId(selection, doc);
            Transaction trans = new Transaction(doc);
            trans.Start("GenerateWall");
            Wall.Create(doc, wallLine, levelId, false);
            trans.Commit();
        }

        public (XYZ, XYZ) GetCoordinatesFromUser(ExternalCommandData commandData)
        {
            GenerateWallForm generateWallForm = new GenerateWallForm(commandData);
            generateWallForm.ShowDialog();

            string xCoordinateFromForm1 = generateWallForm.XCoordinateValue1.ToString();
            string yCoordinateFromForm1 = generateWallForm.YCoordinateValue1.ToString();

            string xCoordinateFromForm2 = generateWallForm.XCoordinateValue2.ToString();
            string yCoordinateFromForm2 = generateWallForm.YCoordinateValue2.ToString();


            double xCoordinate1 = double.Parse(xCoordinateFromForm1);
            double yCoordinate1 = double.Parse(yCoordinateFromForm1);

            double xCoordinate2 = double.Parse(xCoordinateFromForm2);
            double yCoordinate2 = double.Parse(yCoordinateFromForm2);

            XYZ first3DLocationOfWall = new XYZ(xCoordinate1, yCoordinate1, ZCoordinateValue);
            XYZ second3DLocationOfWall = new XYZ(xCoordinate2, yCoordinate2, ZCoordinateValue);

            return (first3DLocationOfWall, second3DLocationOfWall);
        }
    }
}