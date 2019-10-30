using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class ProductRepository
    {
        ///<sumary>
        ///Retrieve one product
        ///<sumary>
        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);
            //TODO: code to get the costumer form the database

            //Temporary customer to work  with
            if (productID == 1)
            {
                product.Name = "Klepsydra";
                product.Description = "Klepsydra timepiece is an outstanding achievement and unlike anything else on the market. Each Klepsydra contains over 2.8 million silver- or gold-plated stainless-steel nanoballs which measure the elapsed time. A full cycle takes 30 minutes from the start.";
                product.CurrentPrice = 4725m;
            }

            return product;
        }

        ///<summary>
        ///Overload the Retrieve method for retreive informations for multiple customers
        ///</summary>
        ///<returns></returns>
        public List<Product> Retrieve()//Same name diferent signature. Method overload because it perform similar functionalities and returns same type results than non overload method.
        {
            //TODO: Code to access the database and get all products

            return new List<Product>();
        }

        ///<sumary>
        ///Saves the current customer
        ///<sumary>
        public bool save(Product product)
        {
            Product newProduct = new Product();
            //TODO: code to save the new customer to the database
            return true;
        }
    }
}
