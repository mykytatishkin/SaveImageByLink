using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaveImageByLink.Models;

namespace SaveImageByLink.Data
{
	public class ImageContext : DbContext
	{
        public ImageContext(DbContextOptions<ImageContext> options)
            : base(options)
        {
        }
        public DbSet<SaveImageByLink.Models.Image> Images { get; set; } = default!;
    }
}