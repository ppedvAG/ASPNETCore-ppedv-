using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infrastructure.OpenAPI.Hoates
{
    public class LinkResourceBase
    {
        public LinkResourceBase()
        {

        }

        public List<Link> Links { get; set; } = new List<Link>();
    }
}
