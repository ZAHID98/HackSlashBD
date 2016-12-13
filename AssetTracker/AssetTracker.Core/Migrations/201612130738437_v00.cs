namespace AssetTracker.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v00 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneralCategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GeneralCategories", t => t.GeneralCategoryId, cascadeDelete: true)
                .Index(t => t.GeneralCategoryId);
            
            CreateTable(
                "dbo.DetailCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneralCategoryId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                        Code = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.GeneralCategories", t => t.GeneralCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.GeneralCategoryId)
                .Index(t => t.CategoryId)
                .Index(t => t.SubCategoryId);
            
            CreateTable(
                "dbo.GeneralCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneralCategoryId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.GeneralCategories", t => t.GeneralCategoryId, cascadeDelete: true)
                .Index(t => t.GeneralCategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OrganizationId = c.Int(nullable: false),
                        OrganizationBranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .ForeignKey("dbo.OrganizationBranches", t => t.OrganizationBranchId, cascadeDelete: true)
                .Index(t => t.OrganizationId)
                .Index(t => t.OrganizationBranchId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Designation = c.String(),
                        ContractNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(),
                        OrganizationId = c.Int(nullable: false),
                        OrganizationBranchId = c.Int(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .ForeignKey("dbo.OrganizationBranches", t => t.OrganizationBranchId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.OrganizationId)
                .Index(t => t.OrganizationBranchId)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(maxLength: 3),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrganizationBranches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        OrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        Name = c.String(),
                        ShortName = c.String(),
                        OrganizationBranch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .ForeignKey("dbo.OrganizationBranches", t => t.OrganizationBranch_Id)
                .Index(t => t.OrganizationId)
                .Index(t => t.OrganizationBranch_Id);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        PhoneNuber = c.String(nullable: false),
                        EmailAddress = c.String(),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "OrganizationBranch_Id", "dbo.OrganizationBranches");
            DropForeignKey("dbo.Locations", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Departments", "OrganizationBranchId", "dbo.OrganizationBranches");
            DropForeignKey("dbo.Departments", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Employees", "OrganizationBranchId", "dbo.OrganizationBranches");
            DropForeignKey("dbo.Employees", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.OrganizationBranches", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.DetailCategories", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.DetailCategories", "GeneralCategoryId", "dbo.GeneralCategories");
            DropForeignKey("dbo.SubCategories", "GeneralCategoryId", "dbo.GeneralCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "GeneralCategoryId", "dbo.GeneralCategories");
            DropForeignKey("dbo.DetailCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Locations", new[] { "OrganizationBranch_Id" });
            DropIndex("dbo.Locations", new[] { "OrganizationId" });
            DropIndex("dbo.OrganizationBranches", new[] { "OrganizationId" });
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropIndex("dbo.Employees", new[] { "OrganizationBranchId" });
            DropIndex("dbo.Employees", new[] { "OrganizationId" });
            DropIndex("dbo.Departments", new[] { "OrganizationBranchId" });
            DropIndex("dbo.Departments", new[] { "OrganizationId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.SubCategories", new[] { "GeneralCategoryId" });
            DropIndex("dbo.DetailCategories", new[] { "SubCategoryId" });
            DropIndex("dbo.DetailCategories", new[] { "CategoryId" });
            DropIndex("dbo.DetailCategories", new[] { "GeneralCategoryId" });
            DropIndex("dbo.Categories", new[] { "GeneralCategoryId" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Locations");
            DropTable("dbo.OrganizationBranches");
            DropTable("dbo.Organizations");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.SubCategories");
            DropTable("dbo.GeneralCategories");
            DropTable("dbo.DetailCategories");
            DropTable("dbo.Categories");
        }
    }
}
