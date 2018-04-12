using System;
using System.Data.Entity;

namespace Signpoint.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string ImgLocation { get; set; }
        public string Description { get; set; }
    }

    public class ImageDBContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
    }
}