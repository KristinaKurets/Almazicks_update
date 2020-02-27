using Almazicks.DataContracts.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IStageService
    {
        Task<IEnumerable<StageDto>> GetStagesAsync();
        Task CreateStageAsync(StageDto stage);
    }
}
