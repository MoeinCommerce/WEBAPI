using System.Numerics;

namespace WebApi.Models
{
    public class WebPaymentMethod
    {
        public BigInteger Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}