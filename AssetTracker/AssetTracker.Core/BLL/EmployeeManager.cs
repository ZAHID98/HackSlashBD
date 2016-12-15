using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;
using AssetTracker.Core.Models.ViewModel;

namespace AssetTracker.Core.BLL
{
   public class EmployeeManager
   {
       EmployeeRepositroy repository = new EmployeeRepositroy();
       public bool Add(Employee employee)
       {
          
           if (employee.OrganizationBranch == null)
           {
               return false;
           }
           if ((employee.Name == null) && (employee.ContractNo.Length == 11))
           {
               return false;
           }
           return repository.Add(employee);
       }

       public bool Update(Employee employee)
       {
           bool isUpdated = repository.Update(employee);
           return isUpdated;
           ;
       }

       public Employee GetById(int id)
       {
           var employee= repository.GetById(id);
           return employee;
       }
   }
}

