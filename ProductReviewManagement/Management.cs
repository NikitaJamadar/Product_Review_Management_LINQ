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
        public void RetrieveProductIdAndReviewOfAllRecords(List<ProductReview> review)
        {
            var recordData = (from products in review
                              select new { ProductId = products.ProductId, Review = products.Review });

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Review : " + list.Review);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordData = (from products in review
                              select products).Skip(5);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
        }
        public void RetrieveProductIdAndReviewUsingSelect(List<ProductReview> review)
        {
            var recordData = review.Select(products => new { ProductId = products.ProductId, Review = products.Review });

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Review : " + list.Review);
            }
        }
        public void RetrieveProductIdLike(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.isLike == true)
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Is Like : " + list.isLike);
            }
        }
        public void RetrieveAverage(List<ProductReview> review)
        {
            var recordData = (review.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Avg = x.Average(p => p.Rating) }));

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Average : " + list.Avg);
            }
        }
        public void RetrieveReviewIsGood(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.Review == "Good    ")
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Review : " + list.Review);
            }
        }
        public void RetrieveProductId10WithRating(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.ProductId == 10)
                              orderby products.Rating descending
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Rating : " + list.Rating);
            }
        }
    }
}
