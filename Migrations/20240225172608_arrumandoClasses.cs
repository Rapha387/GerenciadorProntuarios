using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorProntuarios.Migrations
{
    /// <inheritdoc />
    public partial class arrumandoClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "AlunoId",
                table: "DocumentosAluno",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Prontuarios_CursoId",
                table: "Prontuarios",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosAluno_DocumentoId",
                table: "DocumentosAluno",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Diplomas_AlunoId",
                table: "Diplomas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Diplomas_CursoId",
                table: "Diplomas",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diplomas_Alunos_AlunoId",
                table: "Diplomas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diplomas_Cursos_CursoId",
                table: "Diplomas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosAluno_Alunos_AlunoId",
                table: "DocumentosAluno",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosAluno_Documentos_DocumentoId",
                table: "DocumentosAluno",
                column: "DocumentoId",
                principalTable: "Documentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuarios_Alunos_AlunoId",
                table: "Prontuarios",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuarios_Cursos_CursoId",
                table: "Prontuarios",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diplomas_Alunos_AlunoId",
                table: "Diplomas");

            migrationBuilder.DropForeignKey(
                name: "FK_Diplomas_Cursos_CursoId",
                table: "Diplomas");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosAluno_Alunos_AlunoId",
                table: "DocumentosAluno");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosAluno_Documentos_DocumentoId",
                table: "DocumentosAluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Prontuarios_Alunos_AlunoId",
                table: "Prontuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Prontuarios_Cursos_CursoId",
                table: "Prontuarios");

            migrationBuilder.DropIndex(
                name: "IX_Prontuarios_CursoId",
                table: "Prontuarios");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosAluno_DocumentoId",
                table: "DocumentosAluno");

            migrationBuilder.DropIndex(
                name: "IX_Diplomas_AlunoId",
                table: "Diplomas");

            migrationBuilder.DropIndex(
                name: "IX_Diplomas_CursoId",
                table: "Diplomas");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "DocumentosAluno",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");
        }
    }
}
