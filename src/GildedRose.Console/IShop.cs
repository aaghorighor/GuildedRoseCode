using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Application
{
    public interface IShop
    {
        IList<Item> Items { get; set; }
        void UpdateQuality();
    }
}
