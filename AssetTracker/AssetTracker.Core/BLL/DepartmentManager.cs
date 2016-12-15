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
    public class DepartmentManager
    {
            DepartmentRepository repository = new DepartmentRepository();

            public bool Add(Department department)
            {
              
                if (department.OrganizationBranch == null)
                {
                    return false;
                }
                if (department.Name != null && ((department.Name == null) && (department.Name.Length <= 11)))
                {
                    return false;
                }
                return repository.Add(department);
            }

            public bool Update(Department department)
            {
                bool isUpdated = repository.Update(department);
                return isUpdated;
                ;
            }

            public Department GetById(int id)
            {
                var department = repository.GetById(id);
                return department;
            }
        }
    }


