using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IssuePlanner.Models;

namespace IssuePlanner.Data
{
    public class IPContext:DbContext
    {
        public IPContext(DbContextOptions<IPContext> options) : base(options)
        {
        }
        public DbSet<GithubIssueModel> Issues { get; set; }
        public DbSet<TblLeftModel> LeftTable { get; set; }
        public DbSet<TblRightModel> RightTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GithubIssueModel>().ToTable("tblIssue");
            modelBuilder.Entity<TblLeftModel>().ToTable("tblLeft");
            modelBuilder.Entity<TblRightModel>().ToTable("tblRight");
        }
    }
}
