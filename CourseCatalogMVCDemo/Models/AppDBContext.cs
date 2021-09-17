using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalogMVCDemo.Models
{
    public class AppDBContext : DBContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
    }
}
