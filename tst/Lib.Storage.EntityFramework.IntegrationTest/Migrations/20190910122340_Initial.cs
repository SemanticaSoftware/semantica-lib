using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Semantica.Lib.Tests.Storage.EntityFramework.Test.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValueType",
                columns: table => new
                {
                    ValueTypeProp = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueType", x => x.ValueTypeProp);
                });

            migrationBuilder.CreateTable(
                name: "Root",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prop = table.Column<string>(maxLength: 64, nullable: true),
                    ImmutableProp = table.Column<string>(maxLength: 64, nullable: true),
                    NotMappedProp = table.Column<string>(nullable: true),
                    ValuesValueTypeProp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Root", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Root_ValueType_ValuesValueTypeProp",
                        column: x => x.ValuesValueTypeProp,
                        principalTable: "ValueType",
                        principalColumn: "ValueTypeProp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SimpleDependent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RootId = table.Column<int>(nullable: false),
                    DependentProp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleDependent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SimpleDependent_Root_RootId",
                        column: x => x.RootId,
                        principalTable: "Root",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Root",
                columns: new[] { "Id", "ImmutableProp", "NotMappedProp", "Prop", "ValuesValueTypeProp" },
                values: new object[] { 1, "ImmutableProp-1", "AS", "Prop-1", null });

            migrationBuilder.InsertData(
                table: "Root",
                columns: new[] { "Id", "ImmutableProp", "NotMappedProp", "Prop", "ValuesValueTypeProp" },
                values: new object[] { 2, "ImmutableProp-2", "DASAS", "Prop-2", null });

            migrationBuilder.InsertData(
                table: "SimpleDependent",
                columns: new[] { "Id", "DependentProp", "RootId" },
                values: new object[] { 101, true, 1 });

            migrationBuilder.InsertData(
                table: "SimpleDependent",
                columns: new[] { "Id", "DependentProp", "RootId" },
                values: new object[] { 102, false, 2 });

            migrationBuilder.InsertData(
                table: "SimpleDependent",
                columns: new[] { "Id", "DependentProp", "RootId" },
                values: new object[] { 103, true, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Root_ValuesValueTypeProp",
                table: "Root",
                column: "ValuesValueTypeProp");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleDependent_RootId",
                table: "SimpleDependent",
                column: "RootId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SimpleDependent");

            migrationBuilder.DropTable(
                name: "Root");

            migrationBuilder.DropTable(
                name: "ValueType");
        }
    }
}
