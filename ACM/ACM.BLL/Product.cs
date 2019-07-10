﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    class Product
    {
        //ProductID
        public int ProductId {get; private set;}
        //Product name
        public string ProductName { get; set; }
        //Description
        public string ProductDescription { get; set; }

        //Current price. Defined as a nullable type by using ?
        public decimal? CurrentPrice { get; set; }

        //Constructor
        public Product()
        {

        }

        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }

        //Methods


        ///<summary>
        ///Validates product info
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) && string.IsNullOrEmpty(ProductDescription)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        ///<summary>
        ///Retrieve informations for a specific product
        ///</summary>
        ///<returns></returns>
        public Product Retrieve(int productId)
        {
            return new Product();
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        ///<summary>
        ///Save or add a new product to the DB
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {

            return true;
        }

    }
}