﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReveiveManagementUsingLINQ
{
    public class Management
    {
        public void Display(List<ProductReview> productList)
        {
            foreach (ProductReview list in productList)
            {
                Console.WriteLine("ProductID :-" + list.ProductID + " " + "User ID:-" + list.UserID + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "ISLike:-" + list.ISLike);
            }
        }
        public void TopThreeRecords(List<ProductReview> productList)
        {
            var records = (from Product in productList orderby Product.Rating descending select Product).Take(3).ToList();
            Display(records);
        }
    }
}
