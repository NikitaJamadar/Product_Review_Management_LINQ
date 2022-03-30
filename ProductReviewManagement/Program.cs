using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Product Review Management Program*****");

            List<ProductReview> productlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 4.9, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 4.9, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4.2, Review = "Good    ", isLike = false },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 4.1, Review = "Good    ", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 3.7, Review = "Average ", isLike = false },
                new ProductReview() { ProductId = 3, UserId = 4, Rating = 4.9, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 2.9, Review = "Average ", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 2.2, Review = "Bad     ", isLike = false },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 2.8, Review = "Bad     ", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 2, Rating = 1.7, Review = "Very Bad", isLike = false },
                new ProductReview() { ProductId = 6, UserId = 5, Rating = 3.1, Review = "Average ", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 1, Rating = 4.7, Review = "Good    ", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 4.9, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 8, UserId = 2, Rating = 3.8, Review = "Good    ", isLike = false },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 3.9, Review = "Good    ", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 3, Rating = 3.2, Review = "Average ", isLike = false },
                new ProductReview() { ProductId = 3, UserId = 4, Rating = 4.9, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 8, UserId = 2, Rating = 2.7, Review = "Average ", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 5, Rating = 1.3, Review = "Bad     ", isLike = false },
                new ProductReview() { ProductId = 9, UserId = 6, Rating = 2.1, Review = "Bad     ", isLike = false },
                new ProductReview() { ProductId = 1, UserId = 4, Rating = 1.2, Review = "Very Bad", isLike = false },
                new ProductReview() { ProductId = 6, UserId = 1, Rating = 2.5, Review = "Average ", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 2, Rating = 2.3, Review = "Bad     ", isLike = false },
                new ProductReview() { ProductId = 9, UserId = 3, Rating = 4.5, Review = "VeryGood", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 4.1, Review = "Good    ", isLike = true }
            };

            foreach (var list in productlist)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
            Console.WriteLine("\n------------------------------------------------------------------------------------------------ \n Retrieve Top 3 Records from list \n");

            Management management = new Management();

             management.RetrieveTop3Records(productlist);

            Console.WriteLine("\n------------------------------------------------------------------------------------------------ \n Retrieve Data Rating are Greater then 3 and ProductId is 1, 4, 9 \n");
            management.RetrieveRecordsWithGreaterThanThreeRating(productlist);

            Console.WriteLine("\n------------------------------------------------------------------------------------------------ \n Retrieve Count Of Review For Each ProductId \n");
            management.RetrieveCountOfReviewForEachProductId(productlist);

            Console.WriteLine("\n------------------------------------------------------------------------------------------------ \n Retrieve ProductId And Review Of All Records \n");
            management.RetrieveProductIdAndReviewOfAllRecords(productlist);

            Console.WriteLine("\n------------------------------------------------------------------------------------------------ \n Skip Top 5 Records and Retrieve other All Records \n");
            management.SkipTopFiveRecords(productlist);
        }
      
    }
}
