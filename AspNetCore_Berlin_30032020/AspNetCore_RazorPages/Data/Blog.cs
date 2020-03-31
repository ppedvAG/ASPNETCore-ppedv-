using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_RazorPages.Data
{
    public class Blog
    {

        //EF erkennt die Id anhand der Variablen Namensgebung 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public ICollection<Comment> Comments { get; set; }


    }
}
