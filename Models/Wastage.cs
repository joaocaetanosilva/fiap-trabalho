namespace Recycle.Models
{
    public class Wastage
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public double Weight { get; set; }
        public DateTime CollectionDate { get; set; }
        public string? Location { get; set; }
    }
}
