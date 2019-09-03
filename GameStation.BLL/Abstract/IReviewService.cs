using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IReviewService
    {
        List<Review> GetAll();
        Review GetById(int Id);

        void Add(Review review);
        void Update(Review review);
        void Delete(int reviewId);
    }
}
