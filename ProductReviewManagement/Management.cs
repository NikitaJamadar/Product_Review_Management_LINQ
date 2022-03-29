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
    }
}
