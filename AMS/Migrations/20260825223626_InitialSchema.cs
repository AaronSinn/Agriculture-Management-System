using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AMS.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cooperators",
                columns: table => new
                {
                    CooperatorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Organization = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperators", x => x.CooperatorId);
                });

            migrationBuilder.CreateTable(
                name: "Descriptors",
                columns: table => new
                {
                    DescriptorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccesssionId = table.Column<int>(type: "integer", nullable: false),
                    FruitShape = table.Column<double>(type: "double precision", nullable: false),
                    FruitLenght = table.Column<double>(type: "double precision", nullable: false),
                    FruitWidth = table.Column<double>(type: "double precision", nullable: false),
                    FruitWeight = table.Column<double>(type: "double precision", nullable: false),
                    FruitStemThick = table.Column<double>(type: "double precision", nullable: false),
                    FruitStemLength = table.Column<double>(type: "double precision", nullable: false),
                    FruitTexture = table.Column<double>(type: "double precision", nullable: false),
                    FruitFleshOXI = table.Column<double>(type: "double precision", nullable: false),
                    SeedColour = table.Column<string>(type: "text", nullable: false),
                    SeedQuantity = table.Column<double>(type: "double precision", nullable: false),
                    SeedLength = table.Column<double>(type: "double precision", nullable: false),
                    SeedWidth = table.Column<double>(type: "double precision", nullable: false),
                    SeedNumber = table.Column<double>(type: "double precision", nullable: false),
                    SeedShape = table.Column<string>(type: "text", nullable: false),
                    Colour = table.Column<string>(type: "text", nullable: false),
                    Density = table.Column<double>(type: "double precision", nullable: false),
                    Cmt = table.Column<string>(type: "text", nullable: false),
                    FirstBloomDate = table.Column<string>(type: "text", nullable: false),
                    FullBloomDate = table.Column<string>(type: "text", nullable: false),
                    FireblightRating = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptors", x => x.DescriptorId);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    SiteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.SiteId);
                });

            migrationBuilder.CreateTable(
                name: "Taxons",
                columns: table => new
                {
                    TaxonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Genus = table.Column<string>(type: "text", nullable: false),
                    Species = table.Column<string>(type: "text", nullable: false),
                    Family = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxons", x => x.TaxonId);
                });

            migrationBuilder.CreateTable(
                name: "Acessions",
                columns: table => new
                {
                    AccessionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccessionCode = table.Column<string>(type: "text", nullable: false),
                    AccessionPrefix = table.Column<string>(type: "text", nullable: false),
                    AccessionNumber = table.Column<string>(type: "text", nullable: false),
                    CultivarName = table.Column<string>(type: "text", nullable: false),
                    LabelName = table.Column<string>(type: "text", nullable: false),
                    TaxonId = table.Column<int>(type: "integer", nullable: false),
                    SiteId = table.Column<int>(type: "integer", nullable: false),
                    PlantType = table.Column<string>(type: "text", nullable: false),
                    LifeForm = table.Column<string>(type: "text", nullable: false),
                    LevelOfImprovement = table.Column<string>(type: "text", nullable: false),
                    BreederOrCollector = table.Column<string>(type: "text", nullable: false),
                    ReleasedYear = table.Column<int>(type: "integer", nullable: false),
                    ReleasedDateFormat = table.Column<string>(type: "text", nullable: false),
                    MyProperty = table.Column<int>(type: "integer", nullable: false),
                    SiteComment = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    DescriptorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessions", x => x.AccessionId);
                    table.ForeignKey(
                        name: "FK_Acessions_Descriptors_DescriptorId",
                        column: x => x.DescriptorId,
                        principalTable: "Descriptors",
                        principalColumn: "DescriptorId");
                    table.ForeignKey(
                        name: "FK_Acessions_Taxons_TaxonId",
                        column: x => x.TaxonId,
                        principalTable: "Taxons",
                        principalColumn: "TaxonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessionCooperator",
                columns: table => new
                {
                    AccessionsAccessionId = table.Column<int>(type: "integer", nullable: false),
                    CooperatorsCooperatorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessionCooperator", x => new { x.AccessionsAccessionId, x.CooperatorsCooperatorId });
                    table.ForeignKey(
                        name: "FK_AccessionCooperator_Acessions_AccessionsAccessionId",
                        column: x => x.AccessionsAccessionId,
                        principalTable: "Acessions",
                        principalColumn: "AccessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessionCooperator_Cooperators_CooperatorsCooperatorId",
                        column: x => x.CooperatorsCooperatorId,
                        principalTable: "Cooperators",
                        principalColumn: "CooperatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessionSources",
                columns: table => new
                {
                    AccessionSourceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccessionId = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    ProvinceState = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    IsOrgin = table.Column<bool>(type: "boolean", nullable: false),
                    SourceSeq = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessionSources", x => x.AccessionSourceId);
                    table.ForeignKey(
                        name: "FK_AccessionSources_Acessions_AccessionId",
                        column: x => x.AccessionId,
                        principalTable: "Acessions",
                        principalColumn: "AccessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireblightRatings",
                columns: table => new
                {
                    FireblightRatingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccessionId = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    ObservationSeq = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireblightRatings", x => x.FireblightRatingId);
                    table.ForeignKey(
                        name: "FK_FireblightRatings_Acessions_AccessionId",
                        column: x => x.AccessionId,
                        principalTable: "Acessions",
                        principalColumn: "AccessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccessionId = table.Column<int>(type: "integer", nullable: false),
                    InventoryType = table.Column<string>(type: "text", nullable: false),
                    MaintenancePolicy = table.Column<string>(type: "text", nullable: false),
                    AvailabilityStatus = table.Column<string>(type: "text", nullable: false),
                    IsDistributable = table.Column<string>(type: "text", nullable: false),
                    LocationSelection1 = table.Column<string>(type: "text", nullable: false),
                    LocationSelection2 = table.Column<string>(type: "text", nullable: false),
                    LocationSelection3 = table.Column<string>(type: "text", nullable: false),
                    LocationSelection4 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_Inventories_Acessions_AccessionId",
                        column: x => x.AccessionId,
                        principalTable: "Acessions",
                        principalColumn: "AccessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Iprs",
                columns: table => new
                {
                    IprId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccessionId = table.Column<int>(type: "integer", nullable: false),
                    IprType = table.Column<string>(type: "text", nullable: false),
                    CooperatorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iprs", x => x.IprId);
                    table.ForeignKey(
                        name: "FK_Iprs_Acessions_AccessionId",
                        column: x => x.AccessionId,
                        principalTable: "Acessions",
                        principalColumn: "AccessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Iprs_Cooperators_CooperatorId",
                        column: x => x.CooperatorId,
                        principalTable: "Cooperators",
                        principalColumn: "CooperatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Narratives",
                columns: table => new
                {
                    NarrativeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccessionId = table.Column<int>(type: "integer", nullable: false),
                    NarrativeType = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narratives", x => x.NarrativeId);
                    table.ForeignKey(
                        name: "FK_Narratives_Acessions_AccessionId",
                        column: x => x.AccessionId,
                        principalTable: "Acessions",
                        principalColumn: "AccessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedigrees",
                columns: table => new
                {
                    PedigreeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccessionId = table.Column<int>(type: "integer", nullable: false),
                    MaleAccessionId = table.Column<int>(type: "integer", nullable: true),
                    FemaleAccessionId = table.Column<int>(type: "integer", nullable: true),
                    ExternalMaleName = table.Column<string>(type: "text", nullable: true),
                    ExternalFemaleName = table.Column<string>(type: "text", nullable: true),
                    CrossMethod = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedigrees", x => x.PedigreeId);
                    table.ForeignKey(
                        name: "FK_Pedigrees_Acessions_AccessionId",
                        column: x => x.AccessionId,
                        principalTable: "Acessions",
                        principalColumn: "AccessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessionCooperator_CooperatorsCooperatorId",
                table: "AccessionCooperator",
                column: "CooperatorsCooperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessionSources_AccessionId",
                table: "AccessionSources",
                column: "AccessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Acessions_DescriptorId",
                table: "Acessions",
                column: "DescriptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Acessions_TaxonId",
                table: "Acessions",
                column: "TaxonId");

            migrationBuilder.CreateIndex(
                name: "IX_FireblightRatings_AccessionId",
                table: "FireblightRatings",
                column: "AccessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_AccessionId",
                table: "Inventories",
                column: "AccessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Iprs_AccessionId",
                table: "Iprs",
                column: "AccessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Iprs_CooperatorId",
                table: "Iprs",
                column: "CooperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Narratives_AccessionId",
                table: "Narratives",
                column: "AccessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedigrees_AccessionId",
                table: "Pedigrees",
                column: "AccessionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessionCooperator");

            migrationBuilder.DropTable(
                name: "AccessionSources");

            migrationBuilder.DropTable(
                name: "FireblightRatings");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Iprs");

            migrationBuilder.DropTable(
                name: "Narratives");

            migrationBuilder.DropTable(
                name: "Pedigrees");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "Cooperators");

            migrationBuilder.DropTable(
                name: "Acessions");

            migrationBuilder.DropTable(
                name: "Descriptors");

            migrationBuilder.DropTable(
                name: "Taxons");
        }
    }
}
