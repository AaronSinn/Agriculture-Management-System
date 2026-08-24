namespace AMS.Entities
{
    public class Taxon
    {
        public int TaxonId { get; set; }
        public string Genus { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty; //e.g. 'Malus domestica'
        public ICollection<Accession> Accessions { get; set; } = new List<Accession>();
    }
}
