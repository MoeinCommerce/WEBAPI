using System.Numerics;

namespace WebApi.Models
{
    public class WebCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
