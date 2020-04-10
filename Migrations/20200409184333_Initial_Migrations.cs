using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Migrations
{
    public partial class Initial_Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    DOJ = table.Column<DateTime>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "LeaveConfiguration",
                columns: table => new
                {
                    Leave_Name = table.Column<string>(nullable: false),
                    No_of_Days = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveConfiguration", x => x.Leave_Name);
                });

            migrationBuilder.CreateTable(
                name: "Leavelist",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false),
                    Leave_balance = table.Column<int>(nullable: false),
                    Leave_type = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leavelist", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    Date = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Leave_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.Date);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "LeaveConfiguration");

            migrationBuilder.DropTable(
                name: "Leavelist");

            migrationBuilder.DropTable(
                name: "LeaveType");
        }
    }
}
