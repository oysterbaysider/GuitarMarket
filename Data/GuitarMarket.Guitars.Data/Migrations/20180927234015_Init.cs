using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarMarket.Guitars.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuitarBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    LogoUrl = table.Column<string>(nullable: true),
                    BrandIntroduction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuitarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuitarModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ModelIntroduction = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuitarModels_GuitarBrands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "GuitarBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guitars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guitars_GuitarBrands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "GuitarBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guitars_GuitarModels_ModelId",
                        column: x => x.ModelId,
                        principalTable: "GuitarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guitars_GuitarTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "GuitarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuitarModels_BrandId",
                table: "GuitarModels",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_BrandId",
                table: "Guitars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_ModelId",
                table: "Guitars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_TypeId",
                table: "Guitars",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guitars");

            migrationBuilder.DropTable(
                name: "GuitarModels");

            migrationBuilder.DropTable(
                name: "GuitarTypes");

            migrationBuilder.DropTable(
                name: "GuitarBrands");
        }
    }
}
