using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    class Management
    {
        public void RetrieveTop3Records(List<ProductReview> review)
        {
            var recordData = (from products in review
                              orderby products.Rating descending
                              select products).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
        }
        public void RetrieveRecordsWithGreaterThanThreeRating(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.ProductId == 1 ||
                              products.ProductId == 4 ||
                              products.ProductId == 9)
                              && products.Rating > 3
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
        }
        public void RetrieveCountOfReviewForEachProductId(List<ProductReview> review)
        {
            var recordData = review.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Count : " + list.Count);
            }
        }
    }
}
