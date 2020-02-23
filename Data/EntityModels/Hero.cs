using System.Collections.Generic;

namespace Data.EntityModels
{
    public class Hero : BaseEntity
    {
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public virtual List<Quest> Quests { get; set; }
    }
}
