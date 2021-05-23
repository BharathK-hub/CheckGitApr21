using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentAPI.Models
{
    public class WeatherContext:DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options):base(options)
        {

        }
        public DbSet<Weather> WeatherDetails { get; set; }
    }
}
