using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Context;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace EntityFrameworkSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            OrganizationRepository organizationRepository = new OrganizationRepository();

            var organization = organizationRepository.GetById(2);




            Console.WriteLine("Organization Name: " + organization.Name);
            Console.WriteLine("Organization Code: " + organization.Code);
            Console.WriteLine("Organization Location: " + organization.Location);

            //Organization organization = new Organization()
            //{
            //    Name = "Technobd",
            //    Code = "TEC",
            //    Location = "Dhaka"
            //};


            //OrganizationManager organizationManager = new OrganizationManager();
            //bool isSaved = organizationManager.Add(organization);

            //if (isSaved)
            //{
            //    Console.WriteLine("Saved!");
            //}
            //else
            //{
            //    Console.WriteLine("Failed!");
            //}


            Console.ReadKey();


        }
    }
}
