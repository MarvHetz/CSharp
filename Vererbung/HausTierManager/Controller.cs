using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HausTierManager
{
    internal class Controller
    {
        private List<Tier> tierList;
        public Controller() 
        {
            TierList = new List<Tier>();
        }

        internal List<Tier> TierList { get => tierList; set => tierList = value; }

        public void tierHinzufuegen(String name, double Gewicht, int hundesteuernummer,int Typ)
        {
            if (Typ == 0)
            {
                TierList.Add(new Hund(name, Gewicht, hundesteuernummer));
            }
            else if (Typ == 1)
            {
                TierList.Add(new Katze(name, Gewicht));
            }
            else if (Typ == 2)
            { 
                TierList.Add(new RassenKatze(name,Gewicht));
            }
        }

        public string AnzeigenTier(Tier tier)
        {
            return tier.getStringForListBox();
        }

        public void Impfen(Tier tier)
        {
            try
            {
                tier.Impfen();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
