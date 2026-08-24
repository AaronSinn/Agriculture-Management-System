namespace AMS.Entities
{
    public class Accession
    {
        public int AccessionId { get; set; }
        public string AccessionCode { get; set; } = string.Empty;
        public string AccessionPrefix { get; set; } = string.Empty;
        public string AccessionNumber { get; set; } = string.Empty;
        public string CultivarName { get; set; } = string.Empty;
        public string LabelName { get; set; } = string.Empty;
        public int TaxonId { get; set; }
        public int SiteId { get; set; }
        public string PlantType { get; set; } = string.Empty;
        public string LifeForm { get; set; } = string.Empty;
        public string LevelOfImprovement { get; set; } = string.Empty;
        public string BreederOrCollector { get; set; } = string.Empty;
        public int ReleasedYear { get; set; }
        public string ReleasedDateFormat { get; set; } = string.Empty;
        public int MyProperty { get; set; }
        public string SiteComment { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public Descriptor? Descriptor { get; set; }
        public Pedigree? Pedigree { get; set; }
        public ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
        public ICollection<AccessionSource> Sources { get; set; } = new List<AccessionSource>();
        public ICollection<Narrative> Narratives { get; set; } = new List<Narrative>();
        public ICollection<FireblightRating> FireblightRatings { get; set; } = new List<FireblightRating>();
        public ICollection<Ipr> IprRecords { get; set; } = new List<Ipr>();
        public ICollection<Cooperator> Cooperators { get; set; } = new List<Cooperator>();
    }
}
