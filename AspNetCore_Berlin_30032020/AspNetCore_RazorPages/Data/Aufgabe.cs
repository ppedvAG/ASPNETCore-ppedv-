using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_RazorPages.Data
{
    public class Aufgabe
    {
        //Entity Framework erkennt, an der Namenskonvention, dass Id = Primary Key in Tabelle
        public int Id { get; set; }
        public string AufgabenName { get; set; }
        public DateTime AufgabeBis { get; set; }
        public bool IstFertig { get; set; }
    }
}
