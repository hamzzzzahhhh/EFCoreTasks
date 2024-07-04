using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTasks.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_employees_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "ManagerID", "Name" },
                values: new object[] { 1, null, "Alice" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "ManagerID", "Name" },
                values: new object[] { 2, 1, "Bob" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "ManagerID", "Name" },
                values: new object[] { 3, 1, "Charlie" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "ManagerID", "Name" },
                values: new object[] { 4, 2, "David" });

            migrationBuilder.CreateIndex(
                name: "IX_employees_ManagerID",
                table: "employees",
                column: "ManagerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
