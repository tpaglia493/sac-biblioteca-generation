using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaDipendentiSAC.Migrations
{
    /// <inheritdoc />
    public partial class AddedAuthorToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autore",
                table: "Books",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autore",
                table: "Books");
        }
    }
}
