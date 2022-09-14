using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemySiparisUygulamasi.Data.Repository.IRepository;
using UdemySiparisUygulamasi.Models;

namespace UdemySiparisUygulamasi.Data.Repository
{
    public class AppUserRepository:Repository<AppUser>,IAppUserRepository
    {
        private  ApplicationDbContext _context;
        public AppUserRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
    }
}
