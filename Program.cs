using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReveiveManagementUsingLINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Using LINQ Program ");
            List<ProductReview> productList = new List<ProductReview>
            {
                new ProductReview(){ProductID=1, UserID=1,Rating=5,Review="Excellent",ISLike=true},
                new ProductReview(){ProductID=2, UserID=2,Rating=4,Review="Nice",ISLike=true},
                new ProductReview(){ProductID=3, UserID=3,Rating=3,Review="Nice",ISLike=true},
                new ProductReview(){ProductID=4, UserID=4,Rating=2,Review="Bad",ISLike=false},
                new ProductReview(){ProductID=5, UserID=5,Rating=1,Review="VeryBad",ISLike=false},
                new ProductReview(){ProductID=6, UserID=6,Rating=1,Review="VeryBad",ISLike=false},
                new ProductReview(){ProductID=7, UserID=7,Rating=2,Review="Bad",ISLike=false},
                new ProductReview(){ProductID=8, UserID=8,Rating=3,Review="Nice",ISLike=true},
                new ProductReview(){ProductID=9, UserID=9,Rating=4,Review="Nice",ISLike=true},
                new ProductReview(){ProductID=10, UserID=10,Rating=5,Review="Excellent",ISLike=true}
            };
            bool flag = true;
            Management management = new Management();

            management.Display(productList);
        }
    }
}