namespace AMS.Entities
{
    public class AccessionSource
    {
        public int AccessionSourceId { get; set; }
        public int AccessionId { get; set; }
        public string Country { get; set; } = string.Empty;
        public string ProvinceState { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public bool IsOrgin { get; set; }
        public int SourceSeq { get; set; }
    }
}
