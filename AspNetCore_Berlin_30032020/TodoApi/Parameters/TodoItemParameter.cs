using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Infrastructure.Http;

namespace TodoApi.Parameters
{
    public class TodoItemParameter : QueryStringParameters
    {
        public TodoItemParameter()
        {
            OrderBy = "Name";
        }

        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
