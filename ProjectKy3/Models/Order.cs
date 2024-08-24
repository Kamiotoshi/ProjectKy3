namespace ProjectKy3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<int> ProductIds { get; set; } = new List<int>();
        public DateTime OrderDate { get; set; }
    }
}
