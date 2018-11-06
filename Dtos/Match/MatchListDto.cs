﻿using System;
using PremierLeagueAPI.Dtos.Club;

namespace PremierLeagueAPI.Dtos.Match
{
    public class MatchListDto
    {
        public int Id { get; set; }
        public int Round { get; set; }
        public ClubListDto HomeClub { get; set; }
        public ClubListDto AwayClub { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public DateTime MatchTime { get; set; }
        public bool IsPlayed { get; set; }
    }
}