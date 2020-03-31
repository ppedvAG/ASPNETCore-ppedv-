using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_RazorPages.Data
{
    public class Comment
    {
        //EF erkennt die Id anhand der Variablen Namensgebung 
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        // Hier wird die Relation zu Block hergestellt

        //BlogId = FK
        public int BlogId { get; set; }

        //Navigation zu Blog -> dafür 
        public Blog Blog { get; set; }


    }
}
