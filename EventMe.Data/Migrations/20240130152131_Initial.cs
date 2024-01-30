using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Event identifier"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Event name"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Event start"),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Event end"),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Place for event")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                },
                comment: "Table with events");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
