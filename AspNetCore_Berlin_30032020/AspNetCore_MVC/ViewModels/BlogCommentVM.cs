using AspNetCore_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.ViewModels
{
    public class BlogCommentVM
    {
        public IList<Blog> Blogs { get; set; }

        public IList<Comment> Comments { get; set; }

        public string TestProperty { get; set; } = "Hallo ASPNetCore Teilnehmer";
    }
}
