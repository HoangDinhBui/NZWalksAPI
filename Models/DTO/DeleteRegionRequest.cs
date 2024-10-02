namespace NZWalksAPI.Models.DTO
{
    public class DeleteRegionRequest
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
