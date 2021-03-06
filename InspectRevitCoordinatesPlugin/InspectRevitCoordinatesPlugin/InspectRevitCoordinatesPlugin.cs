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

namespace InspectRevitCoordinatesPlugin
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class InspectRevitCoordinatesPlugin : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                UIApplication uiapp = commandData.Application;
                UIDocument uidoc = uiapp.ActiveUIDocument;
                Selection selection = uidoc.Selection;

                InspectCoordinates(selection);

                return Result.Succeeded;
            }
            catch (Exception exception)
            {
                message = exception.Message;
                return Result.Failed;
            }
        }

        public void InspectCoordinates(Selection selection)
        {
            XYZ firstWallCoordinatePair =
                selection.PickPoint("Please pick the first wall coordinate pair");
            XYZ secondWallCoordinatePair =
                selection.PickPoint("Please Pick the second wall coordinate pair");

            WriteCoordinatesToFile(firstWallCoordinatePair.ToString(),
                secondWallCoordinatePair.ToString());

            selection.PickPoint($"First Pair of 3D Coordinates {firstWallCoordinatePair.ToString()}");
            selection.PickPoint($"Second Pair of 3D Coordinates {secondWallCoordinatePair.ToString()}");
        }

        public void WriteCoordinatesToFile(string firstWallCoordinatePair,
            string secondWallCoordinatePair)
        {
            string filename = "coordinates.txt";
            string documentsFolderPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string revitCoordinatesDirectory = "Revit Coordinates";
            Directory.CreateDirectory(Path.Combine(documentsFolderPath, revitCoordinatesDirectory));
            string path = Path.Combine(documentsFolderPath, revitCoordinatesDirectory, filename);


            using (StreamWriter textFile = File.AppendText(path))
            {
                textFile.WriteLine(firstWallCoordinatePair);
                textFile.WriteLine(secondWallCoordinatePair);
            }
        }
    }
}