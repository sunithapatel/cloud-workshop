namespace ResourcesApi.Models
{
    public class ResourceApplicationPeriod
    {
        public int Id { get; set; }
        public string Month { get; set; } = null!;
        public int ResourceId { get; set; }
        public Resource Resource { get; set; } = null!;
    }
}