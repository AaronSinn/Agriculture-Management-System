namespace AMS.Entities
{
    public class Descriptor
    {
        public int AccesssionId { get; set; }
        public double FruitShape { get; set; }
        public double FruitLenght { get; set; }
        public double FruitWidth { get; set; }
        public double FruitWeight { get; set; }
        public double FruitStemThick { get; set; }
        public double FruitStemLength { get; set; }
        public double FruitTexture { get; set; }
        public double FruitFleshOXI { get; set; }
        public string SeedColour { get; set; } = string.Empty;
        public double SeedQuantity { get; set; }
        public double SeedLength { get; set; }
        public double SeedWidth { get; set; }
        public double SeedNumber { get; set; }
        public string SeedShape { get; set; } = string.Empty;
        public string Colour { get; set; } = string.Empty;
        public double Density { get; set; }
        public string Cmt { get; set; } = string.Empty;
        public string FirstBloomDate { get; set; } = string.Empty;
        public string FullBloomDate { get; set; } = string.Empty;
        public string FireblightRating { get; set; } = string.Empty;
    }
}
