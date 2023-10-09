using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ondc.Seller.DataAccess.Entities
{
    public class ApplicationDbContextOptions
    {
        public string TablePrefix { get; init; } = "";


        public Assembly? EntitiesAssembly { get; init; }
    }
}
