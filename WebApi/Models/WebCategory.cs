using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WebCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int Parent { get; set; }

        public string Description { get; set; }

        public string Display { get; set; }

        public WooCategoryImage Image { get; set; }

        public int MenuOrder { get; set; }

        public int Count { get; set; }
    }
    public class WooCategoryImage
    {
        public int Id { get; set; }

        public string Src { get; set; }

        public string Name { get; set; }

        public string Alt { get; set; }
    }
}
