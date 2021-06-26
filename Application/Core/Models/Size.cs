namespace KoganCodingChallenge.Core.Models
{
    public class Size
    {
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }

        public decimal AreaInMeters()
        {
            var widthAsMetre = Width / 100;
            var lengthAsMetre = Length / 100;
            var heightAsMetre = Height / 100;

            return widthAsMetre * lengthAsMetre * heightAsMetre;
        }
    }
}