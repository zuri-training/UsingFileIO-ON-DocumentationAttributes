using Documentation;
using static Documentation.DocumentationModel;

namespace DocumentationAttribute;


class Program
{
    static void Main(string[] args)
    {
        GetDocs();
        FileIO.Fileinput();
    }
    public class FileInfoTypeOperations
    {
        public static void CreateAFile()
        {

            //Change to a folder on your machine that you have read/write access to, or run as administrator
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}React{Path.DirectorySeparatorChar}Test.txt";


            // Make a new file on the C drive.
            FileInfo f = new(fileName);

            FileStream fs = f.Create();
            // Use the FileStream object...
            // Close down file stream.
            fs.Close();
        }
    }
}

