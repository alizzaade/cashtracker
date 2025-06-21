﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cashTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExpenseCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Expenses",
                newName: "Category");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Expenses",
                newName: "Description");
        }
    }
}
