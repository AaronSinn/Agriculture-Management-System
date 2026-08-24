namespace AMS.Entities
{
    public class Ipr
    {
        public int IprId { get; set; }
        public int AccessionId { get; set; }
        public string IprType { get; set; } = string.Empty;
        public int CooperatorId { get; set; }
    }
}
