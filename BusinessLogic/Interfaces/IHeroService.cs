using Almazicks.DataContracts.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IHeroService
    {
        Task<HeroDto> GetHeroAsync(int id);
        Task<IEnumerable<HeroDto>> GetHeroesAsync();
        Task CreateHeroAsync(HeroDto hero);
        Task UpdateHeroAsync(int id, HeroDto hero);
    }
}
