﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1News.ViewModels
{
    public class DisplayMemeViewModel
    {
        public string Caption { get; set; }
        public bool IsMeme { get; set; }
        public List<string> URL { get; set; }
    }
}
