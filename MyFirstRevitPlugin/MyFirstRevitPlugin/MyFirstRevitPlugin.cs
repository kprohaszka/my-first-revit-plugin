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
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uiapp.ActiveUIDocument.Document;
            Selection selection = uidoc.Selection;

            Reference pickedref = null;

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


            Curve wallLine = Line.CreateBound(first3DLocationOfWall, second3DLocationOfWall);


            pickedref = selection.PickObject(ObjectType.Element, "Please select an element to acquire LevelId");
            Element elem = doc.GetElement(pickedref);
            ElementId levelId = elem.LevelId;


            Transaction trans = new Transaction(doc);
            trans.Start("GenerateWall");
            Wall wall = Wall.Create(doc, wallLine, levelId, false);
            trans.Commit();

            return Result.Succeeded;
        }
    }
}