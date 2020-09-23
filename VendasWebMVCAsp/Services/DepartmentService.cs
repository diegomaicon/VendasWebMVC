using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVCAsp.Models;
using Microsoft.EntityFrameworkCore;


namespace VendasWebMVCAsp.Services
{
    public class DepartmentService
    {
        private readonly VendasWebMVCAspContext _context;
        public DepartmentService(VendasWebMVCAspContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
