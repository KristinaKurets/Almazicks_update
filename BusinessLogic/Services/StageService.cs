using Almazicks.DataContracts.DataContracts;
using AutoMapper;
using BusinessLogic.Interfaces;
using Data;
using Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class StageService : IStageService
    {
        private readonly DiamondsDbContext _context;
        private readonly IMapper _mapper;

        public StageService(DiamondsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateStageAsync(StageDto stage)
        {
            await _context.AddAsync(_mapper.Map<Stage>(stage));
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<StageDto>> GetStagesAsync()
        {
            var stages = await _context.Stages.ToListAsync();
            return _mapper.Map<IEnumerable<StageDto>>(stages);
        }
    }
}
