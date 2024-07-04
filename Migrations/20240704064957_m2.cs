using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTasks.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view view1 as select * from Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
