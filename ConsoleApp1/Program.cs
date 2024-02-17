using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static string[] readFile(String file)
        {
            string[] lines = File.ReadAllLines(file);
            return lines;
        }

        static void even(string ID)
        {
            int sum = 0;
            foreach(char number in ID)
            {
                sum += (int)number;
            }

            if(sum % 2 == 0)
            {
                Console.WriteLine(ID);
            }
        } 

        static void Main(string[] args)
        { 
            ArrayList listaSamochodow = new ArrayList();

            Osobowy osobowy = new Osobowy();
            Ciezarowy ciezarowy = new Ciezarowy();

            listaSamochodow.Add(osobowy);
            listaSamochodow.Add(ciezarowy);

            foreach (Samochod samochod in listaSamochodow)
            {
                samochod.GetColor();
                samochod.GetBrand();
                samochod.GetEngineCapacity();

                if (samochod is Osobowy)
                {
                    ((Osobowy)samochod).GetName();
                }
                else if (samochod is Ciezarowy)
                {
                    ((Ciezarowy)samochod).GetMaxLoad();
                }

                Console.WriteLine();
            }

            string[] lines = readFile("identyfikator.txt");
            foreach (string line in lines)
            {
                even(line);
            }
        }
    }
}
