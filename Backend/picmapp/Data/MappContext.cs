using System;
using System.Collections.Generic;
using Backend.picmapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend.picmapp.Data;
public partial class MappContext : DbContext
{
    public MappContext(DbContextOptions<MappContext> options) : base(options)
    {
    }
    public DbSet<Destination> Destinations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=Mapp;User Id=sa;Password=Stockholm-9876;trustServerCertificate=True;");
    }
}
