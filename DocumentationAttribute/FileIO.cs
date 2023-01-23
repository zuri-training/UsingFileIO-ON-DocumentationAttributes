using System;
using System.Xml.Linq;
using System.IO;
using Documentation;
using static Documentation.DocumentationModel;

namespace DocumentationAttribute
{
    public class FileIO
    {
        private string doc;
        public string Doc
        {
            get
            {
                return doc;
            }
            set
            {
                if (value != "")
                    doc = value;
            }
        }

        public static void Fileinput() 
	    {
            //string writeText = GetDocString;// Create a text string
            File.WriteAllText("filename.txt", GetDocString.ToString());  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);
        }
    }
}

