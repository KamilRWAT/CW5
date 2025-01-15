using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Gracz
    {
        public string Nick { get; set; }
        public string Haslo { get; set; }
        public int saldo { get; set; }

        //public string PelneDane => $"{Nick}%{Haslo}%{saldo}";
        private string pelneDane;

        public string PelneDane
        {
            get { //return pelneDane = $"{Nick}%{Haslo}%{saldo}";
                    return pelneDane = string.Join('%',Nick,Haslo,saldo);
                }
            set { pelneDane = value; }
        }
    }
}
