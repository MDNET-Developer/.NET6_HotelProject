using Microsoft.EntityFrameworkCore;
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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(MyContext? context) : base(context)
        {
        }

        public async Task AcceptBookingAsync(int id)
        {
            var data = await _dbSet.FindAsync(id);
            data.Status = "Təstiqləndi";
            _context.SaveChangesAsync();
        }
    }
}
