using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Anuncio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anuncios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Categoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SubCategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Marca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Modelo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_TipoAnucio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Loja = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeAnuncio = table.Column<string>(type: "varchar(200)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    Valor_Antigo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Imagem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Quilometragem = table.Column<int>(type: "int", nullable: false),
                    AceitaTroca = table.Column<bool>(type: "bit", nullable: false),
                    Direcao = table.Column<int>(type: "int", nullable: false),
                    Combustivel = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anuncios_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeCategoria = table.Column<string>(type: "varchar(200)", nullable: false),
                    AnuncioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorias_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TiposAnuncios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeTipoAnuncio = table.Column<string>(type: "varchar(200)", nullable: false),
                    Duracao = table.Column<string>(type: "varchar(3)", nullable: false),
                    Valor = table.Column<string>(type: "varchar(4)", nullable: false),
                    AnuncioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposAnuncios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposAnuncios_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(13)", nullable: false),
                    AnuncioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategorias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Categoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeSubCategoria = table.Column<string>(type: "varchar(200)", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rua = table.Column<string>(type: "varchar(200)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(9)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(13)", nullable: false),
                    Whatsapp = table.Column<string>(type: "varchar(13)", nullable: false),
                    Rua = table.Column<string>(type: "varchar(200)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(9)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lojas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mensagens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Anuncio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DS_Mensagem = table.Column<string>(type: "varchar(500)", nullable: false),
                    AnuncioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensagens_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mensagens_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SubCategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeMarca = table.Column<string>(type: "varchar(200)", nullable: false),
                    SubCategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marcas_SubCategorias_SubCategoriaId",
                        column: x => x.SubCategoriaId,
                        principalTable: "SubCategorias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Marca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeModelo = table.Column<string>(type: "varchar(200)", nullable: false),
                    MarcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_PedidoId",
                table: "Anuncios",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_AnuncioId",
                table: "Categorias",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_UsuarioId",
                table: "Enderecos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Lojas_UsuarioId",
                table: "Lojas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_SubCategoriaId",
                table: "Marcas",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_AnuncioId",
                table: "Mensagens",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_UsuarioId",
                table: "Mensagens",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposAnuncios_AnuncioId",
                table: "TiposAnuncios",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AnuncioId",
                table: "Usuarios",
                column: "AnuncioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Lojas");

            migrationBuilder.DropTable(
                name: "Mensagens");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "TiposAnuncios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "SubCategorias");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Anuncios");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
