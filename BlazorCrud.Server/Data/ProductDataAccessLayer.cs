using BlazorCrud.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Data
{
    public class ProductDataAccessLayer
    {
        ProductContext db = new ProductContext();

        /* CRUD 
            1. Read - Fetch all data from database
            2. Read - Fetch particular data based on Id
            3. Create - Add a data
            4. Edit - Update a data
            5. Delete - Remove a particular data
         */

        // Read All Data
        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        // Read details of particular data
        public Product GetProduct(int id)
        {
            var product = db.Products.Find(id);
            return product;
        }

        // Add a data
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        // Update a data
        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
        }

        // Delete a data
        public void DeleteProduct(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
