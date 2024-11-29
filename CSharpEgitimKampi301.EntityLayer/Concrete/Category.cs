using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //int x; //Field
        //public int y { get; set; }//property

        //void test()
        //{
        //    int z; // variable
        //}

        public int CategoryId { get; set; } //CodeFirst yaklaşımında bunun birincil anahtar olduğunu tanımlamak için oluşturacağımız prop Clasın adıyla aynı olamlı.
        public int CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}
/*
 Field-Variable-Property
 */

/*
 int x; --> Field
 */