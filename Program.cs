using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using linqgyak;

namespace linqgyak
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat: Kesz");
            List<fuvar> fuvarlista = new List<fuvar>();
            StreamReader sr = new StreamReader("fuvar.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                fuvarlista.Add(new fuvar(int.Parse(adat[0]), adat[1], int.Parse(adat[2]), double.Parse(adat[3]), double.Parse(adat[4]), double.Parse(adat[5]), adat[6]));
            }
            sr.Close();

            Console.WriteLine($"3.feladat: ", fuvarlista.Count());

            Console.WriteLine($"4. feladat:{(fuvarlista.Count(a => a.Azon == 6185))} fuvar alatt: {fuvarlista.Where(a => a.Azon == 6185).Sum(x => x.Dij)}$");

        }
    }
}
