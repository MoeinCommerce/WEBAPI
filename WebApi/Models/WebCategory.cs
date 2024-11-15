namespace WebApi.Models
{
    public class WebCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
