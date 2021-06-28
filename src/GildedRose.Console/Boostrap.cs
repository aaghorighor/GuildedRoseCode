using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using StructureMap.Graph;

namespace GildedRose.Application
{
    public class Boostrap : Registry
    {
        public Boostrap()
        {                      
            For<IItemBuilder>().Use<ItemBuilder>();
            For<IShop>().Use<Shop>();
        }
    }
}
