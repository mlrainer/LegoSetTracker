﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegoSets
{
   public class SetDetails
    {
        public int Id { get; set; }
        public string? Theme { get; set; }
        public int SetNumber { get; set; }
        public int Pieces { get; set; }
        public int MiniFigs { get; set; }
        public string? Complete { get; set; }
    }
}