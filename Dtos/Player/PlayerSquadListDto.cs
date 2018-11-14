﻿using System;
using PremierLeagueAPI.Core.Models;

namespace PremierLeagueAPI.Dtos.Player
{
    public class PlayerSquadListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public PositionType PositionType { get; set; }
        public string Nationality { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhotoUrl { get; set; }
    }
}