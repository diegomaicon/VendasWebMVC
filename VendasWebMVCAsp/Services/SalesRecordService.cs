using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVCAsp.Models;

namespace VendasWebMVCAsp.Services
{
    public class SalesRecordService
    {

        private readonly VendasWebMVCAspContext _context;
        public SalesRecordService(VendasWebMVCAspContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindbyDateAsync(DateTime? minData, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minData.HasValue)
            {
                result = result.Where(x => x.Date >= minData.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result.
                         Include(x => x.Seller).
                         Include(x => x.Seller).
                         OrderByDescending(x => x.Date).
                         ToListAsync();
        }

        public async Task<List<IGrouping<Department,SalesRecord>>> FindbyDateGroupAsync(DateTime? minData, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minData.HasValue)
            {
                result = result.Where(x => x.Date >= minData.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result.
                         Include(x => x.Seller).
                         Include(x => x.Seller).
                         OrderByDescending(x => x.Date).
                         GroupBy(x => x.Seller.Department).
                         ToListAsync();
        }





    }
}
