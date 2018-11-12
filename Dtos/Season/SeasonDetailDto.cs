﻿using System.Collections.Generic;
using PremierLeagueAPI.Dtos.Club;

namespace PremierLeagueAPI.Dtos.Season
{
    public class SeasonDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ClubBriefListDto> Clubs { get; set; }
    }
}