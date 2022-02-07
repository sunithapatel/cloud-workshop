namespace ResourcesApi.Models
{
    public class ResourceLocation
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Resource> Resources { get; set; } = null!;
    }
}