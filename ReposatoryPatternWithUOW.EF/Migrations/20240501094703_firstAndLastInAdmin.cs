using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryPatternWithUOW.EF.Migrations
{
    /// <inheritdoc />
    public partial class firstAndLastInAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Password" },
                values: new object[] { "The Knight", "Platform", "$2a$11$YiLhW/zYz/2DnckdKXI6T.8OFUt/XI6ZUFVhS3ab757HT8FhQPeuu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Password" },
                values: new object[] { "Admin", "Parent", "$2a$11$49NCMyqoYhQKt/ik1pXCQ.aq8yb2fP0Csq857wFxq0echUXN1fcY2" });
        }
    }
}
