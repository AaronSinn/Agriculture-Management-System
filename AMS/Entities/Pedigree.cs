namespace AMS.Entities
{
    public class Pedigree
    {
        public int PedigreeId { get; set; }
        public int AccessionId { get; set; }
        public int? MaleAccessionId { get; set; }
        public int? FemaleAccessionId { get; set; }
        public string? ExternalMaleName { get; set; }
        public string? ExternalFemaleName { get; set; }
        public string? CrossMethod { get; set; }
        public string? Description { get; set; }
        public bool HasKnownParentage =>
            MaleAccessionId is not null || FemaleAccessionId is not null
            || ExternalMaleName is not null || ExternalFemaleName is not null;
    }
}
