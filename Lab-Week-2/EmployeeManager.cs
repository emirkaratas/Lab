using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week_2
{
    internal class EmployeeManager
    {
        List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Remove(int id)
        {
            var found = _employees.FirstOrDefault(x => x.Id == id);
            if (found == null)
            {
                throw new Exception("ID bulunamadı.");
            }
            _employees.Remove(found);
        }
        public List<Employee> getEmps()
        {
            return _employees;
        }
    }
}
