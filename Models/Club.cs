﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremierLeagueAPI.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int EstablishedYear { get; set; }
        public string HomeField { get; set; }
        public string PhotoUrl { get; set; }
    }
}