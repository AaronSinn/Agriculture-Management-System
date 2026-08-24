namespace AMS.Entities
{
    public class Narrative
    {
        public int NarrativeId { get; set; }
        public int AccessionId { get; set; }
        public required string NarrativeType { get; set; }          // 'Keyword' | 'Full'
        public required string Text { get; set; }
    }
}
