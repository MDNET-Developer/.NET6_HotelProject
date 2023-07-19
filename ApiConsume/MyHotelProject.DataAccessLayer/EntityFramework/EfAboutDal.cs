using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Repositories;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(MyContext? context) : base(context)
        {
        }
    }
}
