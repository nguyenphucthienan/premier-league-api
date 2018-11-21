﻿using PremierLeagueAPI.Core.Models;

namespace PremierLeagueAPI.Dtos.Card
{
    public class CardCreateDto
    {
        public int ClubId { get; set; }
        public int PlayerId { get; set; }
        public CardType CardType { get; set; }
        public int CardTime { get; set; }
    }
}