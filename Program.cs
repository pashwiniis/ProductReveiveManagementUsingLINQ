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

            while (flag)
            {
                Console.WriteLine("Specify the Number To Excute USE CASE Wise Problems:-- \n 1. Displaying ADD List \n 2. Top Three Records According to Rating  \n 3. Retrieve Records using Product ID which is Rating > 3\n 4. The Number of Records of ProductID \n 5. Retrieve Product ID and Review\n 6. Exit");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        management.Display(productList);
                        break;
                    case 2:
                        management.TopThreeRecords(productList);
                        break;
                    case 3:
                        management.RetrieveRecordsByProductID(productList);
                        break;
                    case 4:
                        management.RetrieveRecordsCount(productList);
                        break;
                    case 5:
                        management.RetrieveOnlyproductIDAndReview(productList);
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}