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
   public class EmployeeRepositroy
    {
        public bool Add(Employee employee)
        {
            AssetDBContext db=new AssetDBContext();
            db.Employees.Add(employee);
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public bool Update(Employee employee)
        {
            AssetDBContext db=new AssetDBContext();
            db.Employees.Attach(employee);
            db.Entry(employee).State = EntityState.Modified;
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public IList<Employee > GetAll()
        {
            AssetDBContext db=new AssetDBContext();
            var employee = db.Employees.Include(c => c.OrganizationBranch).ToList();
            return employee;
        }

        public Employee GetById(int id)
        {
            AssetDBContext db=new AssetDBContext();
            var employee = db.Employees.Include(c => c.OrganizationBranch).FirstOrDefault(c => c.Id == id);
            return employee;
        }
    }
}

    

