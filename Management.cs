using System;
using System.Collections.Generic;
using System.Data;
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
        public void RetrieveRecordsByProductID(List<ProductReview> productList)
        {
            var records = (from Product in productList where (Product.ProductID == 1 || Product.ProductID == 4 || Product.ProductID == 9) && Product.Rating > 3 select Product).ToList();
            Display(records);
        }
        public void RetrieveRecordsCount(List<ProductReview> productList)
        {
            var records = productList.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var data in records)
            {
                Console.WriteLine("Number Of Records of Product ID : {0} is {1} ", data.ProductID, data.Count);

            }
        }
        public void RetrieveOnlyproductIDAndReview(List<ProductReview> productList)
        {
            var records = from Product in productList select new { Product.ProductID, Product.Review };
            foreach (var data in records)
            {
                Console.WriteLine("ProductID : " + data.ProductID + " " + "Review : " + data.Review);
            }

        }
        public void SkipTopFiveRecords(List<ProductReview> productList)
        {
            var records = (from Product in productList select Product).Skip(5).ToList();
            Display(records);
        }
        DataTable dataTable = new DataTable();
        public void ProductReviewDatatable(List<ProductReview> productList)
        {
            dataTable.Columns.Add("ProductID").DataType = typeof(Int32);
            dataTable.Columns.Add("UserID").DataType = typeof(Int32);
            dataTable.Columns.Add("Rating").DataType = typeof(Int32);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("ISLike").DataType = typeof(bool);
            foreach (var data in productList)
            {
                dataTable.Rows.Add(data.ProductID, data.UserID, data.Rating, data.Review, data.ISLike);
            }
            var productTable = from Product in dataTable.AsEnumerable() select Product;
            foreach (DataRow Product in productTable)
            {
                Console.WriteLine("ProductID : " + Product.Field<int>("ProductID") + "\t" + "UserID : " + Product.Field<int>("UserID") + "\t" + "Rating : " + Product.Field<int>("Rating") + "\t" + "Review : " + Product.Field<string>("Review") + "\t" + "ISLike : " + Product.Field<bool>("ISLike"));
            }
        }
        public void RetrieveRecordsFromDataTable(List<ProductReview> productList)
        {

            var productTable = from Product in this.dataTable.AsEnumerable() where Product.Field<bool>("ISLike").Equals(true) select Product;
            foreach (DataRow Product in productTable)
            {
                Console.WriteLine("ProductId : " + Product.Field<int>("ProductID") + "\t" + "UserID : " + Product.Field<int>("UserID") + "\t" + "Rating : " + Product.Field<int>("Rating") + "\t" + "Review : " + Product.Field<string>("Review") + "\t" + "ISLike : " + Product.Field<bool>("ISLike"));
            }
        }
    }
}
