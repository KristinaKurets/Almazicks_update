namespace Data.EntityModels
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; }
        public int ResourceChange { get; set; }
        public int StageToId { get; set; }
    }
}
