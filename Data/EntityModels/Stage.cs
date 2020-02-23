using System.Collections.Generic;

namespace Data.EntityModels
{
    public class Stage : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string PictureUrl { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}
