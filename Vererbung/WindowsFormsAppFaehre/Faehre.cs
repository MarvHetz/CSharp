using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehre
{
    internal class Faehre
    {
        private decimal belegteLaenge;
        private decimal GrundPreisLKW;
        private decimal GrundPreisPKW;
        private decimal maxLaenge;
        private string name;
        private decimal preisProPerson;
        private decimal preisProTonne;

        public Faehre()
        { 
        }

        public Faehre(decimal belegteLaenge, decimal grundPreisLKW, decimal grundPreisPKW, decimal maxLaenge, string name, decimal preisProPerson, decimal preisProTonne)
        {
            this.belegteLaenge = belegteLaenge;
            GrundPreisLKW = grundPreisLKW;
            GrundPreisPKW = grundPreisPKW;
            this.maxLaenge = maxLaenge;
            this.name = name;
            this.preisProPerson = preisProPerson;
            this.preisProTonne = preisProTonne;
        }
    }
}
