﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PremierLeagueAPI.Core.Models;
using PremierLeagueAPI.Core.Queries;
using PremierLeagueAPI.Core.Repositories;
using PremierLeagueAPI.Extensions;
using PremierLeagueAPI.Helpers;

namespace PremierLeagueAPI.Persistence.Repositories
{
    public class GoalRepository : Repository<Goal>, IGoalRepository
    {
        public GoalRepository(PremierLeagueDbContext context) : base(context)
        {
        }

        public async Task<PaginatedList<Goal>> GetAsync(GoalQuery goalQuery)
        {
            var query = Context.Goals
                .Include(g => g.Club)
                .Include(g => g.Player)
                .AsQueryable();

            if (goalQuery.MatchId.HasValue)
                query = query.Where(g => g.MatchId == goalQuery.MatchId);

            var columnsMap = new Dictionary<string, Expression<Func<Goal, object>>>()
            {
                ["id"] = g => g.Id,
                ["goalType"] = g => g.GoalType,
                ["goalTime"] = g => g.GoalTime,
            };

            query = query.Sort(goalQuery, columnsMap);

            return await PaginatedList<Goal>.CreateAsync(query, goalQuery.PageNumber, goalQuery.PageSize);
        }

        public async Task<Goal> GetDetailByIdAsync(int id)
        {
            return await Context.Goals
                .Include(g => g.Club)
                .Include(g => g.Match)
                .Include(g => g.Player)
                .SingleOrDefaultAsync(g => g.Id == id);
        }
    }
}