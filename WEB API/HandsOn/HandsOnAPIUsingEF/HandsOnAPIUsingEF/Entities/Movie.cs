﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnAPIUsingEF.Entities
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }

    }
}