﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovie.DAL.Model.Entity
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        //rating
        //Director
        //Category
    }
}
