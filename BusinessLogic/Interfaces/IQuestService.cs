using Almazicks.DataContracts.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IQuestService
    {
        Task<QuestDto> GetQuestAsync(int id);
        Task<IEnumerable<QuestDto>> GetQuestsAsync();
        Task CreateQuestAsync(QuestDto quest);
        Task UpdateQuestAsync(int id, QuestDto quest);
    }
}
