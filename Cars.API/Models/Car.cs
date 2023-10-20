namespace Cars.API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Age { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }
}
