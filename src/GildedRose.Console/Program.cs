using System;
using System.Collections.Generic;
using MarkdownLog;
using StructureMap;

namespace GildedRose.Application
{
    public static class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var container = Container.For<Boostrap>();
            var itemBuilder = container.GetInstance<IItemBuilder>();
            var shop = container.GetInstance<IShop>();

            shop.Items = itemBuilder.Items();

            while (true)
            {
                Console.Clear();

                shop.UpdateQuality();

                Console.WriteLine(shop.Items.ToMarkdownTable());
                
                Console.ReadKey();
            }
        }
    }
}
