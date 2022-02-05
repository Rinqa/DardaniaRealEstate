using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DardaniaRealEstate.Models;

namespace DardaniaRealEstate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DardaniaRealEstate.Models.Residence> Residence { get; set; }
        public DbSet<DardaniaRealEstate.Models.Office> Office { get; set; }
        public DbSet<DardaniaRealEstate.Models.Communes> Communes { get; set; }
        public DbSet<DardaniaRealEstate.Models.Agents> Agents { get; set; }
        public DbSet<DardaniaRealEstate.Models.Properties> Properties { get; set; }
    }
}
