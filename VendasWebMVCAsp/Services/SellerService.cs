using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVCAsp.Models;

namespace VendasWebMVCAsp.Services
{
    public class SellerService
    {
        private readonly VendasWebMVCAspContext _context;
        public SellerService(VendasWebMVCAspContext context) {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Indsert(Seller obj) {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
