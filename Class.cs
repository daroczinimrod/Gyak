using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqgyak
{
    class fuvar
    {
        int azon;
        string indulas;
        int idotartam;
        double tavolsag;
        double dij;
        double borravalo;
        string fizetes;

        public fuvar(int azon, string indulas, int idotartam, double tavolsag, double dij, double borravalo, string fizetes)
        {
            this.azon = azon;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.dij = dij;
            this.borravalo = borravalo;
            this.fizetes = fizetes;
        }

        public int Azon { get => azon; }
        public string Indulas { get => indulas; }
        public int Idotartam { get => idotartam; }
        public double Tavolsag { get => tavolsag; }
        public double Dij { get => dij; }
        public double Borravalo { get => borravalo; }
        public string Fizetes { get => fizetes; }
    }
}
