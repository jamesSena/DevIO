using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
