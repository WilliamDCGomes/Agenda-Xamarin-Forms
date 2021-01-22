﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AppTarefas.Migrations
{
    public partial class BancoB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prioridade",
                table: "Tarefas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prioridade",
                table: "Tarefas");
        }
    }
}
