using System.Collections.Generic;

namespace Almazicks.DataContracts.DataContracts
{
    public class HeroDto : BaseEntity
    {
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public virtual List<QuestDto> Quests { get; set; }
    }
}
