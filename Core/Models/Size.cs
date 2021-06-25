namespace KoganCodingChallenge.Domain
{
    public class Size
    {
        public float Width { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }

        public float Area()
        {
            return Width * Length * Height;
        }
    }
}