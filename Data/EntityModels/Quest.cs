using System.Collections.Generic;

namespace Data.EntityModels
{
    public class Quest : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int Resource { get; set; }
        public string ResourceName { get; set; }
        public virtual List<Stage> Stages { get; set; }
        

    }
}
