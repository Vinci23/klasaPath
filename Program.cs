using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasaPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prviDirektoriji = @"c:\prviDir";
            string drugiDirektoriji = @"c:\drugiDir";
            string[] nazivi = new string[5];

            if (!Directory.Exists(prviDirektoriji)) 
            { 
                Directory.CreateDirectory(prviDirektoriji);
            }
            if (!Directory.Exists(drugiDirektoriji))
            {
                Directory.CreateDirectory(drugiDirektoriji);
            }

            for(int i = 0; i <5; i++)
            {
                nazivi[i] = "Datoteka" + i;

                if (!File.Exists(@"c:\prviDir\" + nazivi[i]))
                {
                    File.Create(@"c:\prviDir\" + nazivi[i]);
                }
            }
            try
            {
                foreach(string datoteka in Directory.GetFiles(prviDirektoriji))
                {
                    string imeDatoteke = Path.GetFileName(datoteka);
                    string ciljnaDatoteka = Path.Combine(drugiDirektoriji, imeDatoteke);

                    File.Copy(datoteka, ciljnaDatoteka, );
                }
                Console.WriteLine("It is DONE");
            }
            catch(Exception greska)
            {
                Console.WriteLine("Greška: {0}", greska.Message);
            }

            Console.ReadKey();
        }
    }
}
