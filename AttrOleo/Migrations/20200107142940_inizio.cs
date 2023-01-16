using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AttrOleo.Migrations
{
    public partial class inizio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dischi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LottoNo = table.Column<string>(nullable: true),
                    Costruttore = table.Column<string>(nullable: true),
                    PressioneRottura = table.Column<int>(nullable: true),
                    DataCreazione = table.Column<DateTime>(nullable: false),
                    DataAggiornamento = table.Column<DateTime>(nullable: false),
                    TecnicoUltimoAggiornamentoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dischi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dischi_AspNetUsers_TecnicoUltimoAggiornamentoId",
                        column: x => x.TecnicoUltimoAggiornamentoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Valvole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(nullable: true),
                    Reparto = table.Column<string>(nullable: true),
                    Impianto = table.Column<string>(nullable: true),
                    Matricola = table.Column<string>(nullable: true),
                    Costruttore = table.Column<string>(nullable: true),
                    DataCreazione = table.Column<DateTime>(nullable: false),
                    DataAggiornamento = table.Column<DateTime>(nullable: false),
                    TecnicoUltimoAggiornamentoId = table.Column<string>(nullable: true),
                    Stato = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Modello = table.Column<string>(nullable: true),
                    PressioneTaratura = table.Column<int>(nullable: true),
                    VerificaTaratura = table.Column<DateTime>(nullable: true),
                    ScadenzaTaratura = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valvole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Valvole_AspNetUsers_TecnicoUltimoAggiornamentoId",
                        column: x => x.TecnicoUltimoAggiornamentoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pressioni",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(nullable: true),
                    Reparto = table.Column<string>(nullable: true),
                    Impianto = table.Column<string>(nullable: true),
                    Matricola = table.Column<string>(nullable: true),
                    Costruttore = table.Column<string>(nullable: true),
                    DataCreazione = table.Column<DateTime>(nullable: false),
                    DataAggiornamento = table.Column<DateTime>(nullable: false),
                    TecnicoUltimoAggiornamentoId = table.Column<string>(nullable: true),
                    Stato = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    SerialNoFabbrica = table.Column<string>(nullable: true),
                    TecnicoReferenteId = table.Column<string>(nullable: true),
                    Volume = table.Column<int>(nullable: true),
                    PressioneMassima = table.Column<int>(nullable: true),
                    Fluido = table.Column<string>(nullable: true),
                    Descrizione = table.Column<string>(nullable: true),
                    Ubicazione = table.Column<string>(nullable: true),
                    Norma = table.Column<string>(nullable: true),
                    VerificaPrimoImpianto = table.Column<DateTime>(nullable: true),
                    PrimaVerificaFunzionalita = table.Column<DateTime>(nullable: true),
                    VerificaFunzionalita = table.Column<DateTime>(nullable: true),
                    VerificaIntegrita = table.Column<DateTime>(nullable: true),
                    ScadenzaFunzionalita = table.Column<DateTime>(nullable: true),
                    ScadenzaIntegrita = table.Column<DateTime>(nullable: true),
                    DiscoMontatoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pressioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pressioni_Dischi_DiscoMontatoId",
                        column: x => x.DiscoMontatoId,
                        principalTable: "Dischi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pressioni_AspNetUsers_TecnicoReferenteId",
                        column: x => x.TecnicoReferenteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pressioni_AspNetUsers_TecnicoUltimoAggiornamentoId",
                        column: x => x.TecnicoUltimoAggiornamentoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    File = table.Column<byte[]>(type: "VARBINARY(MAX) FILESTREAM", nullable: true),
                    CreatedTimestamp = table.Column<DateTime>(nullable: false),
                    UpdatedTimestamp = table.Column<DateTime>(nullable: false),
                    ContentType = table.Column<string>(nullable: true),
                    PressioneId = table.Column<int>(nullable: true),
                    ValvolaId = table.Column<int>(nullable: true),
                    DiscoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileDescriptions_Dischi_DiscoId",
                        column: x => x.DiscoId,
                        principalTable: "Dischi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileDescriptions_Pressioni_PressioneId",
                        column: x => x.PressioneId,
                        principalTable: "Pressioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileDescriptions_Valvole_ValvolaId",
                        column: x => x.ValvolaId,
                        principalTable: "Valvole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PressioneValvola",
                columns: table => new
                {
                    PressioneID = table.Column<int>(nullable: false),
                    ValvolaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PressioneValvola", x => new { x.PressioneID, x.ValvolaID });
                    table.ForeignKey(
                        name: "FK_PressioneValvola_Pressioni_PressioneID",
                        column: x => x.PressioneID,
                        principalTable: "Pressioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PressioneValvola_Valvole_ValvolaID",
                        column: x => x.ValvolaID,
                        principalTable: "Valvole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dischi_TecnicoUltimoAggiornamentoId",
                table: "Dischi",
                column: "TecnicoUltimoAggiornamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDescriptions_DiscoId",
                table: "FileDescriptions",
                column: "DiscoId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDescriptions_PressioneId",
                table: "FileDescriptions",
                column: "PressioneId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDescriptions_ValvolaId",
                table: "FileDescriptions",
                column: "ValvolaId");

            migrationBuilder.CreateIndex(
                name: "IX_PressioneValvola_ValvolaID",
                table: "PressioneValvola",
                column: "ValvolaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pressioni_DiscoMontatoId",
                table: "Pressioni",
                column: "DiscoMontatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pressioni_TecnicoReferenteId",
                table: "Pressioni",
                column: "TecnicoReferenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pressioni_TecnicoUltimoAggiornamentoId",
                table: "Pressioni",
                column: "TecnicoUltimoAggiornamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Valvole_TecnicoUltimoAggiornamentoId",
                table: "Valvole",
                column: "TecnicoUltimoAggiornamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FileDescriptions");

            migrationBuilder.DropTable(
                name: "PressioneValvola");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Pressioni");

            migrationBuilder.DropTable(
                name: "Valvole");

            migrationBuilder.DropTable(
                name: "Dischi");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
