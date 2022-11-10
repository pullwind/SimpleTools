using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTools
{
    class Context :DbContext
    {
        public Context() : base ("name=c2")
        {

        }

        public DbSet<ThePC> thePCs { get; set; }

    }
}
