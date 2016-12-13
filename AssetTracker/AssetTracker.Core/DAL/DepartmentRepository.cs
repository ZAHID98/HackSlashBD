using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;
using AssetTracker.Core.Models.ViewModel;

namespace AssetTracker.Core.DAL
{
    public class DepartmentRepository
    {
       
            public bool Add(Department department)
            {
                AssetDBContext db = new AssetDBContext();
                db.Departments.Add(department);
                int rowAffected = db.SaveChanges();
                return rowAffected > 0;
            }

            public bool Update(Department  department)
            {
                AssetDBContext db = new AssetDBContext();
                db.Departments.Attach(department);
                db.Entry(department).State = EntityState.Modified;
                int rowAffected = db.SaveChanges();
                return rowAffected > 0;
            }

            public IList<Department > GetAll()
            {
                AssetDBContext db = new AssetDBContext();
                var department = db.Departments.Include(c => c.OrganizationBranch).ToList();
                return department;
            }

            public Department GetById(int id)
            {
                AssetDBContext db = new AssetDBContext();
                var department = db.Departments.Include(c => c.OrganizationBranch).FirstOrDefault(c => c.Id == id);
                return department;
            }
        }
    }


    

