namespace EntityFrameworkSqliteCodeFirst.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        INN = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        Count = c.Long(nullable: false),
                        Code = c.String(maxLength: 2147483647),
                        BuyPrice = c.Double(nullable: false),
                        SalePrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        Role = c.String(maxLength: 2147483647),
                        Salary = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SaledDetail",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DetailId = c.Long(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        ClientId = c.Long(),
                        VehicleId = c.Long(),
                        SaleCount = c.Long(nullable: false),
                        SaleDateTime = c.DateTime(nullable: false),
                        Income = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.ClientId)
                .ForeignKey("dbo.Employees", t => t.DetailId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.VehicleId)
                .Index(t => t.DetailId, name: "IX_SaledDetail_DetailId")
                .Index(t => t.ClientId, name: "IX_SaledDetail_ClientId")
                .Index(t => t.VehicleId, name: "IX_SaledDetail_VehicleId");
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        ClientId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.ClientId)
                .Index(t => t.ClientId, name: "IX_Vehicles_ClientId");
            
            CreateTable(
                "dbo.WorkHours",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        EmployeeId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId, name: "IX_WorkHours_EmployeeId");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkHours", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Vehicles", "ClientId", "dbo.Employees");
            DropForeignKey("dbo.SaledDetail", "VehicleId", "dbo.Employees");
            DropForeignKey("dbo.SaledDetail", "DetailId", "dbo.Employees");
            DropForeignKey("dbo.SaledDetail", "ClientId", "dbo.Employees");
            DropIndex("dbo.WorkHours", "IX_WorkHours_EmployeeId");
            DropIndex("dbo.Vehicles", "IX_Vehicles_ClientId");
            DropIndex("dbo.SaledDetail", "IX_SaledDetail_VehicleId");
            DropIndex("dbo.SaledDetail", "IX_SaledDetail_ClientId");
            DropIndex("dbo.SaledDetail", "IX_SaledDetail_DetailId");
            DropTable("dbo.WorkHours",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Date",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.Vehicles",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.SaledDetail",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "DetailId",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.Employees",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.Details",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.Clients",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
        }
    }
}
