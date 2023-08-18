using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments(); 
        //Stubbed out method for selecting departments
    }
}
