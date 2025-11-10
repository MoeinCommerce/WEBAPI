using System.Numerics;

namespace WebApi.Models
{
    public class WebPaymentMethod
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}