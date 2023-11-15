using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise.console.Data
{

    public static class ProductInventory
    {
        public static Dictionary<int, string> Products { get; set; } = new Dictionary<int, string>();
              
        public static void Create(string product)
        {
            Products.Add(Products.Max(x => x.Key) + 1, product);

        }
        public static void Read()
        {
            Console.WriteLine("");

            foreach (var kvp in Products)
            {
                Console.WriteLine($"{kvp.Key}.{kvp.Value}");
            }
        }
        
        public static void Delete(int id)
        {
            Products.Remove(id);
        }
        public static void Initialize()
        {
            Products.Add(1,"Branded Hoodie (Size M)");
            Products.Add(2,"Official Teacher Mouse Mat with Authentic Teachers Signature");
            Products.Add(3,"Official Boolean Duck");
            Products.Add(4,"Official Mouse Mat");
        }
        

    }
}