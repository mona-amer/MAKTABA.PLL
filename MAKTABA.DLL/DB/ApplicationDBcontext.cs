using EXCEL.DAL.ENTITIES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL.DAL.DB
{
    public class ApplicationDBcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExcelData;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true",
        sqlOptions => sqlOptions.EnableRetryOnFailure());

        }
        public DbSet<COMPANY> ExcelData { get; set; }
    }
} 
