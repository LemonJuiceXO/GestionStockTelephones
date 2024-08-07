using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.ViewModels
{
  public  class ProductModel
    {
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Model { get; set; }
        public float ProductBuyPrice { get; set; }
        public float ProductSellPrice { get; set; }
        public float ProductDate { get; set; }
    }
}
