namespace ResourcesApi.Models
{
    public class ResourceLocation
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ResourceId { get; set; }
        public Resource Resource { get; set; } = null!;
    }
}