using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemySiparisUygulamasi.Data.Repository.IRepository;
using UdemySiparisUygulamasi.Models;

namespace UdemySiparisUygulamasi.Data.Repository
{
    
    public class OrderDetailRepository:Repository<OrderDetail>,IOrderDetailRepository
    {
        private ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
    }
}
