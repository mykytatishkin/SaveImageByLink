using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaveImgaByLinkWeb.Models;

    public class ImageContext : DbContext
    {
        public ImageContext (DbContextOptions<ImageContext> options)
            : base(options)
        {
        }

        public DbSet<SaveImgaByLinkWeb.Models.Image> Images { get; set; } = default!;
        public DbSet<SaveImgaByLinkWeb.Models.User> Users { get; set; } = default!;
    }
