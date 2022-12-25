using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductID=1,CategoryId=1,ProductName="Bardak",UnitsInStock=15 },
                new Product{ProductID=1,CategoryId=1,ProductName="Kamera",UnitsInStock=3},
                new Product{ProductID=1,CategoryId=1,ProductName="Telefon",UnitsInStock=2},
                new Product{ProductID=1,CategoryId=1,ProductName="Klavye",UnitsInStock=65},
                new Product{ProductID=1,CategoryId=1,ProductName="Fare",UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete;

            productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();//where içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            product.UnitsInStock = product.UnitsInStock;


        }
    }
}
