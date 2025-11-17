using System.Numerics;

namespace WebApi.Models
{
    public class WebCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? ParentId { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
