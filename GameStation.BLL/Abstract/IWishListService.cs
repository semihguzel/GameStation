using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IWishListService
    {
        List<WishList> GetAll();
        void Add(WishList wishList);
        void Update(WishList wishList);
        void Delete(int wishListId);
    }
}
