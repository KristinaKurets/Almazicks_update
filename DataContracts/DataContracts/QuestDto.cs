using System.Collections.Generic;

namespace Almazicks.DataContracts.DataContracts
{
    public class QuestDto : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int Resource { get; set; }
        public string ResourceName { get; set; }
        public virtual List<StageDto> Stages { get; set; }


    }
}
