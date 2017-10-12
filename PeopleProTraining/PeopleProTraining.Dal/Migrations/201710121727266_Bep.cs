namespace PeopleProTraining.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bep : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "Department_DepartmentIdBep", newName: "Department_DepartmentId");
            RenameColumn(table: "dbo.Departments", name: "DepartmentIdBep", newName: "DepartmentId");
            RenameIndex(table: "dbo.Departments", name: "IX_DepartmentIdBep", newName: "IX_DepartmentId");
            RenameIndex(table: "dbo.Employees", name: "IX_Department_DepartmentIdBep", newName: "IX_Department_DepartmentId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employees", name: "IX_Department_DepartmentId", newName: "IX_Department_DepartmentIdBep");
            RenameIndex(table: "dbo.Departments", name: "IX_DepartmentId", newName: "IX_DepartmentIdBep");
            RenameColumn(table: "dbo.Departments", name: "DepartmentId", newName: "DepartmentIdBep");
            RenameColumn(table: "dbo.Employees", name: "Department_DepartmentId", newName: "Department_DepartmentIdBep");
        }
    }
}
