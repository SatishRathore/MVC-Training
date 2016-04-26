using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Repository
    {
        private List<LineItem> itemCollection;

        /// <summary>
        /// Default Constructor with Anonyous Initilization
        /// </summary>
        public Repository()
        {
            itemCollection = new List<LineItem>();
            itemCollection.Add(new LineItem { Id = 1, Name = "bats", Price = 1000, Quantity = 1 });//Anonyous Initialization
            itemCollection.Add(new LineItem { Id = 2, Name = "caps", Price = 2000, Quantity = 2 });
            itemCollection.Add(new LineItem { Id = 3, Name = "racket", Price = 3000, Quantity = 3 });
            itemCollection.Add(new LineItem { Id = 4, Name = "hockey", Price = 4000, Quantity = 4 });
            itemCollection.Add(new LineItem { Id = 5, Name = "volleyball", Price = 5000, Quantity = 5 });
            itemCollection.Add(new LineItem { Id = 6, Name = "shoes", Price = 6000, Quantity = 6 });
            itemCollection.Add(new LineItem { Id = 7, Name = "Tshirt", Price = 7000, Quantity = 7 });
            itemCollection.Add(new LineItem { Id = 8, Name = "basketball", Price = 8000, Quantity = 8 });
            itemCollection.Add(new LineItem { Id = 9, Name = "Shirt", Price = 9000, Quantity = 9 });
            itemCollection.Add(new LineItem { Id = 10, Name = "Skates", Price = 10000, Quantity = 10 });
        }

        /// <summary>
        /// For getting the LineItem Collection
        /// </summary>
        /// <returns>Collection of the LineItem</returns>
        public List<LineItem> GetItems()
        {
            return itemCollection;
        }
    }
}