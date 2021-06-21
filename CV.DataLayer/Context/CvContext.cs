using CV.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.DataLayer.Context
{
    public class CvContext : DbContext
    {
        public CvContext(DbContextOptions<CvContext> options) : base(options)
        {

        }

        #region User

        public DbSet<User> Users { get; set; }


        #endregion
    }


}
