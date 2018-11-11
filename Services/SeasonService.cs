﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PremierLeagueAPI.Core;
using PremierLeagueAPI.Core.Models;
using PremierLeagueAPI.Core.Repositories;
using PremierLeagueAPI.Core.Services;

namespace PremierLeagueAPI.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISeasonRepository _seasonRepository;

        public SeasonService(IUnitOfWork unitOfWork,
            ISeasonRepository seasonRepository)
        {
            _unitOfWork = unitOfWork;
            _seasonRepository = seasonRepository;
        }

        public async Task<IEnumerable<Season>> GetAllAsync()
        {
            return await _seasonRepository.GetAllAsync();
        }

        public async Task<Season> GetByIdAsync(int id)
        {
            return await _seasonRepository.GetAsync(id);
        }

        public async Task<Season> GetDetailByIdAsync(int id)
        {
            return await _seasonRepository.GetDetailAsync(id);
        }

        public async Task CreateAsync(Season season)
        {
            _seasonRepository.Add(season);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateAsync(Season season)
        {
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteAsync(Season season)
        {
            _seasonRepository.Remove(season);
            await _unitOfWork.CompleteAsync();
        }
    }
}