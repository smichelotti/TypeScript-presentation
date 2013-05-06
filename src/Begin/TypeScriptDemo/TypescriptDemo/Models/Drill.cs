﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypescriptDemo.Models
{
    public class Drill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}