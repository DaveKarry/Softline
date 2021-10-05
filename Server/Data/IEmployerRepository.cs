using Softline.Models;
using System.Collections.Generic;


namespace Softline.Data
{
    public interface IEmployerRepository
    {
        bool Update();
        IEnumerable<Employer> GetEmployers();
        Employer GetEmployerById(int id);
        void CreateEmployer(Employer employer);
        void UpdateEmployer(Employer employer);
        void DeleteEmployer(Employer employer);
    }

} 