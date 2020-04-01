using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [DisplayName("Titel")]
        public string Title { get; set; }

        [DisplayName("Artikel")]
        [Required]
        [MinLength(20, ErrorMessage = "Artikel muss mindestens 20 Zeichen beinhalten")]
        public string Content { get; set; }

        [DisplayName("Erstellt am")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Erstellt von")]
        public string CreatedBy { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
