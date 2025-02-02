﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarSystem.Migrations
{
    public partial class TerceiroMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Guitarras",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Guitarras");
        }
    }
}
