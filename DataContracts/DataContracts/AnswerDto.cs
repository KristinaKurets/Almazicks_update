namespace Almazicks.DataContracts.DataContracts
{
    public class AnswerDto : BaseEntity
    {
        public string Text { get; set; }
        public int ResourceChange { get; set; }
        public int StageToId { get; set; }
    }
}
