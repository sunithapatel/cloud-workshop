namespace ResourcesApi.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Body { get; set; }
        public string? Url { get; set; }
        public string? EligibilityCriteria { get; set; }
        public int? InternshipPeriod { get; set; }
        public ICollection<ResourceApplicationPeriod> ApplicationPeriods { get; set; } = null!;
        public bool Stipend { get; set; }
        public ICollection<ResourceLocation> Locations { get; set; } = null!;
        public string? Description { get; set; }
    }
}