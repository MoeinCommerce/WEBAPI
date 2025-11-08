using System.Numerics;

namespace WebApi.Models
{
    public class WebCategory
    {
        public BigInteger Id { get; set; }
        public string Name { get; set; }
        public BigInteger? ParentId { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
