using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
