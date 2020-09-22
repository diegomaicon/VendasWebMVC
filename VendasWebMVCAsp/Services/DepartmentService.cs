using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVCAsp.Models;

namespace VendasWebMVCAsp.Services
{
    public class DepartmentService
    {
        private readonly VendasWebMVCAspContext _context;
        public DepartmentService(VendasWebMVCAspContext context)
        {
            _context = context;
        }

        public List<Department> FindAll() {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
