using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IRecentlyViewService
    {
        List<RecentlyView> GetAll();
        void Add(RecentlyView recentlyView);
        void Update(RecentlyView recentlyView);
        void Delete(int recentlyViewId);
    }
}
