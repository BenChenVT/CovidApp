using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace CovidApp
{
    public class FileReader
    {

        // change root path if necessary, add search function later
        string rootPath = @"Y:\dotnet_VS\CovidApp\CSVFile\";

        LinkedList<DataProcess> allState = new LinkedList<DataProcess>();



        public FileReader(string fileName)
        {
            ParseFile(fileName);
        }

        // current directory: 
        // Y:\\dotnet_VS\\CovidVisualization\\TestProject1\\bin\\Debug\\net6.0
        public void ParseFile(string fileName)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());

            string line;
            try
            {
                StreamReader sr = new StreamReader(rootPath + fileName);
                line = sr.ReadLine();
                // first line is title(ethnic)  all ehnics in this string array
                string[] ethnics = Regex.Split(line, " *, *");


                line = sr.ReadLine();
                while (line != null)
                {
                    DataProcess oneState = new DataProcess(ethnics, line);
                    allState.AddLast(oneState);

                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                //Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Reading file succeeded!");
            }
        }


        public LinkedList<DataProcess> getAllData()
        {
            return allState;
        }
    }
}