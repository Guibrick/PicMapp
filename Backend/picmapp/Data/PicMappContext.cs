using System;
using System.Collections.Generic;
using Backend.picmapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend.picmapp.Data;
public partial class PicMappContext : DbContext
{
    public PicMappContext(DbContextOptions<PicMappContext> options) : base(options)
    {
    }
    public DbSet<Card> Cards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=Mapp;User Id=sa;Password=Stockholm-9876;trustServerCertificate=True;");
    }
}
