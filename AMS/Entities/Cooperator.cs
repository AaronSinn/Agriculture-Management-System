namespace AMS.Entities
{
    public class Cooperator
    {
        public int CooperatorId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Organization { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        public ICollection<Accession> Accessions { get; set; } = new List<Accession>();
        public ICollection<Ipr> IprRecords { get; set; } = new List<Ipr>();
    }
}
