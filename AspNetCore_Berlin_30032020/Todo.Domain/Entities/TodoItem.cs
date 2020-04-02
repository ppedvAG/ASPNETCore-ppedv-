﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Entities
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
