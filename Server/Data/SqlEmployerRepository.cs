using System;
using System.Collections.Generic;
using System.Linq;
using Softline.Models;

namespace Softline.Data
{
    public class SqlEmployerRepository : IEmployerRepository
    {
        private readonly EmployerContext _context;

        public SqlEmployerRepository(EmployerContext context)
        {
            _context = context;
        }

        public void CreateEmployer(Employer employer)
        {
            if(employer == null){
                throw new ArgumentNullException(nameof(employer));
            }
            _context.Employers.Add(employer);
        }

        public void DeleteEmployer(Employer employer)
        {
            if(employer == null){
                throw new ArgumentNullException(nameof(employer));
            }
            _context.Employers.Remove(employer);
        }

        public Employer GetEmployerById(int id)
        {
            return _context.Employers.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Employer> GetEmployers()
        {
            return _context.Employers.ToList();
        }

        public bool Update()
        {
            return(_context.SaveChanges() >= 0);
        }

        public void UpdateEmployer(Employer employer)
        {
            
        }
    }
}