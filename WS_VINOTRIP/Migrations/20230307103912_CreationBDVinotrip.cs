using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WS_VINOTRIP.Migrations
{
    public partial class CreationBDVinotrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_e_boncadeau_bcd",
                columns: table => new
                {
                    bcd_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bcd_dateexpirationbon = table.Column<DateTime>(type: "date", nullable: false),
                    bcd_codereduction = table.Column<string>(type: "char(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_boncadeau_bcd", x => x.bcd_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_catvignoble_cvg",
                columns: table => new
                {
                    cvg_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cvg_libelle = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_catvignoble_cvg", x => x.cvg_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_lien_len",
                columns: table => new
                {
                    len_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    len_url = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    len_type = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_lien_len", x => x.len_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_motdepasse_mdp",
                columns: table => new
                {
                    mdp_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mdp_mdp = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_motdepasse_mdp", x => x.mdp_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_partenaire_ptn",
                columns: table => new
                {
                    prs_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ptn_telpartenaire = table.Column<string>(type: "char(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_partenaire_ptn", x => x.prs_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_personne_prs",
                columns: table => new
                {
                    prs_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    prs_nompersonne = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    prs_mailpersonne = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_personne_prs", x => x.prs_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_refcartebancaire_rcb",
                columns: table => new
                {
                    rcb_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rcb_numcarte = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    rcb_dateexpirationcarte = table.Column<DateTime>(type: "date", nullable: false),
                    rcb_nomcarte = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_refcartebancaire_rcb", x => x.rcb_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_typecompte_tpc",
                columns: table => new
                {
                    tpc_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tpc_libelletypecompte = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_typecompte_tpc", x => x.tpc_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_typeelementetape_tee",
                columns: table => new
                {
                    tee_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tee_libelletypecompte = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_typeelementetape_tee", x => x.tee_id);
                });

            migrationBuilder.CreateTable(
                name: "t_e_chequecadeau_cqc",
                columns: table => new
                {
                    bcd_id = table.Column<int>(type: "integer", nullable: false),
                    cqc_montant = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_chequecadeau_cqc", x => x.bcd_id);
                    table.ForeignKey(
                        name: "FK_t_e_chequecadeau_cqc_t_e_boncadeau_bcd_bcd_id",
                        column: x => x.bcd_id,
                        principalTable: "t_e_boncadeau_bcd",
                        principalColumn: "bcd_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_catparticipant_cpp",
                columns: table => new
                {
                    cpp_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vgb_titre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_catparticipant_cpp", x => x.cpp_id);
                    table.ForeignKey(
                        name: "FK_t_e_catparticipant_cpp_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_catsejour_csj",
                columns: table => new
                {
                    csj_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    csj_libelle = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_catsejour_csj", x => x.csj_id);
                    table.ForeignKey(
                        name: "FK_t_e_catsejour_csj_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_vignoble_vgb",
                columns: table => new
                {
                    vgb_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vgb_titre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    vgb_description = table.Column<string>(type: "text", nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_vignoble_vgb", x => x.vgb_id);
                    table.ForeignKey(
                        name: "FK_t_e_vignoble_vgb_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_partenaireactivite_pta",
                columns: table => new
                {
                    pta_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ptn_id = table.Column<int>(type: "integer", nullable: false),
                    pta_typeactivite = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    pta_lieurdv = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_partenaireactivite_pta", x => x.pta_id);
                    table.ForeignKey(
                        name: "FK_t_e_partenaireactivite_pta_t_e_partenaire_ptn_ptn_id",
                        column: x => x.ptn_id,
                        principalTable: "t_e_partenaire_ptn",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_partenairecave_ptc",
                columns: table => new
                {
                    ptc_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ptn_id = table.Column<int>(type: "integer", nullable: false),
                    ptc_typedegustation = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_partenairecave_ptc", x => x.ptc_id);
                    table.ForeignKey(
                        name: "FK_t_e_partenairecave_ptc_t_e_partenaire_ptn_ptn_id",
                        column: x => x.ptn_id,
                        principalTable: "t_e_partenaire_ptn",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_partenairehebergement_pth",
                columns: table => new
                {
                    pth_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ptn_id = table.Column<int>(type: "integer", nullable: false),
                    pth_typehebergement = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    pth_nbchambre = table.Column<int>(type: "integer", nullable: false),
                    pth_etoileshebergement = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_partenairehebergement_pth", x => x.pth_id);
                    table.ForeignKey(
                        name: "FK_t_e_partenairehebergement_pth_t_e_partenaire_ptn_ptn_id",
                        column: x => x.ptn_id,
                        principalTable: "t_e_partenaire_ptn",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_partenairerestaurant_ptr",
                columns: table => new
                {
                    ptr_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ptn_id = table.Column<int>(type: "integer", nullable: false),
                    ptr_typecuisine = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ptr_specialite = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    ptr_etoilesrestaurant = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_partenairerestaurant_ptr", x => x.ptr_id);
                    table.ForeignKey(
                        name: "FK_t_e_partenairerestaurant_ptr_t_e_partenaire_ptn_ptn_id",
                        column: x => x.ptn_id,
                        principalTable: "t_e_partenaire_ptn",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_client_clt",
                columns: table => new
                {
                    prs_id = table.Column<int>(type: "integer", nullable: false),
                    ctl_titreclient = table.Column<string>(type: "char(5)", nullable: true),
                    ctl_prenomclient = table.Column<string>(type: "text", nullable: false),
                    ctl_datenaissance = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_client_clt", x => x.prs_id);
                    table.ForeignKey(
                        name: "FK_t_e_client_clt_t_e_personne_prs_prs_id",
                        column: x => x.prs_id,
                        principalTable: "t_e_personne_prs",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_elementetape_ele",
                columns: table => new
                {
                    ele_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    prs_id = table.Column<int>(type: "integer", nullable: false),
                    tpe_id = table.Column<int>(type: "integer", nullable: false),
                    ele_libelle = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ele_description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_elementetape_ele", x => x.ele_id);
                    table.ForeignKey(
                        name: "FK_t_e_elementetape_ele_t_e_partenaire_ptn_prs_id",
                        column: x => x.prs_id,
                        principalTable: "t_e_partenaire_ptn",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_elementetape_ele_t_e_typeelementetape_tee_tpe_id",
                        column: x => x.tpe_id,
                        principalTable: "t_e_typeelementetape_tee",
                        principalColumn: "tee_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_elementvignoble_evg",
                columns: table => new
                {
                    evg_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vgb_id = table.Column<int>(type: "integer", nullable: false),
                    evg_titre = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    evg_description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_elementvignoble_evg", x => x.evg_id);
                    table.ForeignKey(
                        name: "FK_t_e_elementvignoble_evg_t_e_vignoble_vgb_vgb_id",
                        column: x => x.vgb_id,
                        principalTable: "t_e_vignoble_vgb",
                        principalColumn: "vgb_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_routedesvins_rdv",
                columns: table => new
                {
                    rdv_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vgb_id = table.Column<int>(type: "integer", nullable: false),
                    rdv_titre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_routedesvins_rdv", x => x.rdv_id);
                    table.ForeignKey(
                        name: "FK_t_e_routedesvins_rdv_t_e_vignoble_vgb_vgb_id",
                        column: x => x.vgb_id,
                        principalTable: "t_e_vignoble_vgb",
                        principalColumn: "vgb_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_clientcarte_clc",
                columns: table => new
                {
                    ctl_id = table.Column<int>(type: "integer", nullable: false),
                    rcb_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_clc", x => new { x.ctl_id, x.rcb_id });
                    table.ForeignKey(
                        name: "FK_t_e_clientcarte_clc_t_e_client_clt_ctl_id",
                        column: x => x.ctl_id,
                        principalTable: "t_e_client_clt",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_clientcarte_clc_t_e_refcartebancaire_rcb_rcb_id",
                        column: x => x.rcb_id,
                        principalTable: "t_e_refcartebancaire_rcb",
                        principalColumn: "rcb_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_compte_cmp",
                columns: table => new
                {
                    cmp_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mdp_id = table.Column<int>(type: "integer", nullable: false),
                    tpc_id = table.Column<int>(type: "integer", nullable: false),
                    clt_id = table.Column<int>(type: "integer", nullable: false),
                    cmp_telcompte = table.Column<string>(type: "char(10)", nullable: false),
                    cmp_newsletter = table.Column<bool>(type: "boolean", nullable: false),
                    cmp_estverifie = table.Column<bool>(type: "boolean", nullable: false),
                    cmp_estadmin = table.Column<bool>(type: "boolean", nullable: false),
                    cmp_dateconnexion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_compte_cmp", x => x.cmp_id);
                    table.ForeignKey(
                        name: "FK_t_e_compte_cmp_t_e_client_clt_clt_id",
                        column: x => x.clt_id,
                        principalTable: "t_e_client_clt",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_compte_cmp_t_e_motdepasse_mdp_mdp_id",
                        column: x => x.mdp_id,
                        principalTable: "t_e_motdepasse_mdp",
                        principalColumn: "mdp_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_compte_cmp_t_e_typecompte_tpc_tpc_id",
                        column: x => x.tpc_id,
                        principalTable: "t_e_typecompte_tpc",
                        principalColumn: "tpc_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_historiquecadeau_htc",
                columns: table => new
                {
                    ctl_id = table.Column<int>(type: "integer", nullable: false),
                    bcd_id = table.Column<int>(type: "integer", nullable: false),
                    htc_typecadeau = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_htc", x => new { x.ctl_id, x.bcd_id });
                    table.ForeignKey(
                        name: "FK_t_e_historiquecadeau_htc_t_e_boncadeau_bcd_bcd_id",
                        column: x => x.bcd_id,
                        principalTable: "t_e_boncadeau_bcd",
                        principalColumn: "bcd_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_historiquecadeau_htc_t_e_client_clt_ctl_id",
                        column: x => x.ctl_id,
                        principalTable: "t_e_client_clt",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_j_contient_ctn",
                columns: table => new
                {
                    ele_id = table.Column<int>(type: "integer", nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ctn", x => new { x.len_id, x.ele_id });
                    table.ForeignKey(
                        name: "FK_t_j_contient_ctn_t_e_elementetape_ele_ele_id",
                        column: x => x.ele_id,
                        principalTable: "t_e_elementetape_ele",
                        principalColumn: "ele_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_j_contient_ctn_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_j_lienelementvignoble_lev",
                columns: table => new
                {
                    evg_id = table.Column<int>(type: "integer", nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_lev", x => new { x.len_id, x.evg_id });
                    table.ForeignKey(
                        name: "FK_t_j_lienelementvignoble_lev_t_e_elementvignoble_evg_evg_id",
                        column: x => x.evg_id,
                        principalTable: "t_e_elementvignoble_evg",
                        principalColumn: "evg_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_j_lienelementvignoble_lev_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_sejour_sjr",
                columns: table => new
                {
                    sjr_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rdv_id = table.Column<int>(type: "integer", nullable: false),
                    csj_id = table.Column<int>(type: "integer", nullable: false),
                    cvg_id = table.Column<int>(type: "integer", nullable: false),
                    sjr_titre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    sjr_description = table.Column<string>(type: "text", nullable: false),
                    sjr_prix = table.Column<decimal>(type: "numeric(7,2)", nullable: false),
                    sjr_nbjour = table.Column<decimal>(type: "numeric(3,2)", nullable: false),
                    sjr_nbnuit = table.Column<int>(type: "integer", nullable: false),
                    sjr_promotion = table.Column<int>(type: "integer", nullable: false),
                    sjr_est_valide = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sjr", x => x.sjr_id);
                    table.ForeignKey(
                        name: "fk_sjr_csj",
                        column: x => x.csj_id,
                        principalTable: "t_e_catsejour_csj",
                        principalColumn: "csj_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sjr_cvg",
                        column: x => x.cvg_id,
                        principalTable: "t_e_catvignoble_cvg",
                        principalColumn: "cvg_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sjr_rdv",
                        column: x => x.rdv_id,
                        principalTable: "t_e_routedesvins_rdv",
                        principalColumn: "rdv_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_j_lienroutedesvins_lrv",
                columns: table => new
                {
                    rdv_id = table.Column<int>(type: "integer", nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_lrv", x => new { x.len_id, x.rdv_id });
                    table.ForeignKey(
                        name: "FK_t_j_lienroutedesvins_lrv_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_j_lienroutedesvins_lrv_t_e_routedesvins_rdv_rdv_id",
                        column: x => x.rdv_id,
                        principalTable: "t_e_routedesvins_rdv",
                        principalColumn: "rdv_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_avis_avi",
                columns: table => new
                {
                    avi_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    prs_id = table.Column<int>(type: "integer", nullable: false),
                    avi_titre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    avi_note = table.Column<int>(type: "integer", nullable: false),
                    avi_desvription = table.Column<string>(type: "text", nullable: false),
                    avi_dateavis = table.Column<DateTime>(type: "date", nullable: false),
                    sjr_id = table.Column<int>(type: "integer", nullable: false),
                    avi_reponse = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_avis_avi", x => x.avi_id);
                    table.ForeignKey(
                        name: "FK_t_e_avis_avi_t_e_personne_prs_prs_id",
                        column: x => x.prs_id,
                        principalTable: "t_e_personne_prs",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_avis_avi_t_e_sejour_sjr_sjr_id",
                        column: x => x.sjr_id,
                        principalTable: "t_e_sejour_sjr",
                        principalColumn: "sjr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_etape_etp",
                columns: table => new
                {
                    etp_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sjr_id = table.Column<int>(type: "integer", nullable: false),
                    etp_titre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    etp_description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_etape_etp", x => x.etp_id);
                    table.ForeignKey(
                        name: "FK_t_e_etape_etp_t_e_sejour_sjr_sjr_id",
                        column: x => x.sjr_id,
                        principalTable: "t_e_sejour_sjr",
                        principalColumn: "sjr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_favori_fav",
                columns: table => new
                {
                    ctl_id = table.Column<int>(type: "integer", nullable: false),
                    sjr_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_fav", x => new { x.sjr_id, x.ctl_id });
                    table.ForeignKey(
                        name: "FK_t_e_favori_fav_t_e_client_clt_ctl_id",
                        column: x => x.ctl_id,
                        principalTable: "t_e_client_clt",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_favori_fav_t_e_sejour_sjr_sjr_id",
                        column: x => x.sjr_id,
                        principalTable: "t_e_sejour_sjr",
                        principalColumn: "sjr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_panier_pnr",
                columns: table => new
                {
                    pnr_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sjr_id = table.Column<int>(type: "integer", nullable: false),
                    pnr_nbadultes = table.Column<int>(type: "integer", nullable: false),
                    pnr_nbenfants = table.Column<int>(type: "integer", nullable: false),
                    pnr_nbchambres = table.Column<int>(type: "integer", nullable: false),
                    pnr_offert = table.Column<bool>(type: "boolean", nullable: false),
                    pnr_prixtotal = table.Column<decimal>(type: "numeric(9,2)", nullable: false),
                    pnr_datesejour = table.Column<DateTime>(type: "date", nullable: false),
                    CompteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_panier_pnr", x => x.pnr_id);
                    table.ForeignKey(
                        name: "FK_t_e_panier_pnr_t_e_compte_cmp_CompteId",
                        column: x => x.CompteId,
                        principalTable: "t_e_compte_cmp",
                        principalColumn: "cmp_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_panier_pnr_t_e_sejour_sjr_sjr_id",
                        column: x => x.sjr_id,
                        principalTable: "t_e_sejour_sjr",
                        principalColumn: "sjr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_e_sejourcadeau_sjc",
                columns: table => new
                {
                    bcd_id = table.Column<int>(type: "integer", nullable: false),
                    sjr_id = table.Column<int>(type: "integer", nullable: false),
                    sjc_choixdestination = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_e_sejourcadeau_sjc", x => x.bcd_id);
                    table.ForeignKey(
                        name: "FK_t_e_sejourcadeau_sjc_t_e_boncadeau_bcd_bcd_id",
                        column: x => x.bcd_id,
                        principalTable: "t_e_boncadeau_bcd",
                        principalColumn: "bcd_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_e_sejourcadeau_sjc_t_e_sejour_sjr_sjr_id",
                        column: x => x.sjr_id,
                        principalTable: "t_e_sejour_sjr",
                        principalColumn: "sjr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_j_comporte_cpt",
                columns: table => new
                {
                    sjr_id = table.Column<int>(type: "integer", nullable: false),
                    cpp_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cpt", x => new { x.sjr_id, x.cpp_id });
                    table.ForeignKey(
                        name: "fk_cpt_cpp",
                        column: x => x.cpp_id,
                        principalTable: "t_e_catparticipant_cpp",
                        principalColumn: "cpp_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cpt_sjr",
                        column: x => x.sjr_id,
                        principalTable: "t_e_sejour_sjr",
                        principalColumn: "sjr_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_j_liensejour_lsj",
                columns: table => new
                {
                    sjr_id = table.Column<int>(type: "integer", nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_lsj", x => new { x.len_id, x.sjr_id });
                    table.ForeignKey(
                        name: "FK_t_j_liensejour_lsj_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_j_liensejour_lsj_t_e_sejour_sjr_sjr_id",
                        column: x => x.sjr_id,
                        principalTable: "t_e_sejour_sjr",
                        principalColumn: "sjr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_j_reported_rep",
                columns: table => new
                {
                    cmp_id = table.Column<int>(type: "integer", nullable: false),
                    avi_id = table.Column<int>(type: "integer", nullable: false),
                    rep_a_signale = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rep", x => new { x.avi_id, x.cmp_id });
                    table.ForeignKey(
                        name: "FK_t_j_reported_rep_t_e_avis_avi_avi_id",
                        column: x => x.avi_id,
                        principalTable: "t_e_avis_avi",
                        principalColumn: "avi_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_j_reported_rep_t_e_compte_cmp_cmp_id",
                        column: x => x.cmp_id,
                        principalTable: "t_e_compte_cmp",
                        principalColumn: "cmp_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_j_concerne_ccr",
                columns: table => new
                {
                    etp_id = table.Column<int>(type: "integer", nullable: false),
                    ele_id = table.Column<int>(type: "integer", nullable: false),
                    ccr_horaire = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ccr", x => new { x.etp_id, x.ele_id });
                    table.ForeignKey(
                        name: "fk_ccr_ele",
                        column: x => x.ele_id,
                        principalTable: "t_e_elementetape_ele",
                        principalColumn: "ele_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ccr_etp",
                        column: x => x.etp_id,
                        principalTable: "t_e_etape_etp",
                        principalColumn: "etp_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_j_lienetape_lep",
                columns: table => new
                {
                    etp_id = table.Column<int>(type: "integer", nullable: false),
                    len_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_lep", x => new { x.len_id, x.etp_id });
                    table.ForeignKey(
                        name: "FK_t_j_lienetape_lep_t_e_etape_etp_etp_id",
                        column: x => x.etp_id,
                        principalTable: "t_e_etape_etp",
                        principalColumn: "etp_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_j_lienetape_lep_t_e_lien_len_len_id",
                        column: x => x.len_id,
                        principalTable: "t_e_lien_len",
                        principalColumn: "len_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_e_avis_avi_prs_id",
                table: "t_e_avis_avi",
                column: "prs_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_avis_avi_sjr_id",
                table: "t_e_avis_avi",
                column: "sjr_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_catparticipant_cpp_len_id",
                table: "t_e_catparticipant_cpp",
                column: "len_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_catsejour_csj_len_id",
                table: "t_e_catsejour_csj",
                column: "len_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_clientcarte_clc_rcb_id",
                table: "t_e_clientcarte_clc",
                column: "rcb_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t_e_compte_cmp_clt_id",
                table: "t_e_compte_cmp",
                column: "clt_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_compte_cmp_mdp_id",
                table: "t_e_compte_cmp",
                column: "mdp_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_compte_cmp_tpc_id",
                table: "t_e_compte_cmp",
                column: "tpc_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_elementetape_ele_prs_id",
                table: "t_e_elementetape_ele",
                column: "prs_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_elementetape_ele_tpe_id",
                table: "t_e_elementetape_ele",
                column: "tpe_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_elementvignoble_evg_vgb_id",
                table: "t_e_elementvignoble_evg",
                column: "vgb_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_etape_etp_sjr_id",
                table: "t_e_etape_etp",
                column: "sjr_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_favori_fav_ctl_id",
                table: "t_e_favori_fav",
                column: "ctl_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_historiquecadeau_htc_bcd_id",
                table: "t_e_historiquecadeau_htc",
                column: "bcd_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_panier_pnr_CompteId",
                table: "t_e_panier_pnr",
                column: "CompteId");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_panier_pnr_sjr_id",
                table: "t_e_panier_pnr",
                column: "sjr_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_partenaireactivite_pta_ptn_id",
                table: "t_e_partenaireactivite_pta",
                column: "ptn_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_partenairecave_ptc_ptn_id",
                table: "t_e_partenairecave_ptc",
                column: "ptn_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_partenairehebergement_pth_ptn_id",
                table: "t_e_partenairehebergement_pth",
                column: "ptn_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_partenairerestaurant_ptr_ptn_id",
                table: "t_e_partenairerestaurant_ptr",
                column: "ptn_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_routedesvins_rdv_vgb_id",
                table: "t_e_routedesvins_rdv",
                column: "vgb_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_sejour_sjr_csj_id",
                table: "t_e_sejour_sjr",
                column: "csj_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_sejour_sjr_cvg_id",
                table: "t_e_sejour_sjr",
                column: "cvg_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_sejour_sjr_rdv_id",
                table: "t_e_sejour_sjr",
                column: "rdv_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_sejourcadeau_sjc_sjr_id",
                table: "t_e_sejourcadeau_sjc",
                column: "sjr_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_e_vignoble_vgb_len_id",
                table: "t_e_vignoble_vgb",
                column: "len_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_comporte_cpt_cpp_id",
                table: "t_j_comporte_cpt",
                column: "cpp_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_concerne_ccr_ele_id",
                table: "t_j_concerne_ccr",
                column: "ele_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_contient_ctn_ele_id",
                table: "t_j_contient_ctn",
                column: "ele_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_lienelementvignoble_lev_evg_id",
                table: "t_j_lienelementvignoble_lev",
                column: "evg_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_lienetape_lep_etp_id",
                table: "t_j_lienetape_lep",
                column: "etp_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_lienroutedesvins_lrv_rdv_id",
                table: "t_j_lienroutedesvins_lrv",
                column: "rdv_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_liensejour_lsj_sjr_id",
                table: "t_j_liensejour_lsj",
                column: "sjr_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_j_reported_rep_cmp_id",
                table: "t_j_reported_rep",
                column: "cmp_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_e_chequecadeau_cqc");

            migrationBuilder.DropTable(
                name: "t_e_clientcarte_clc");

            migrationBuilder.DropTable(
                name: "t_e_favori_fav");

            migrationBuilder.DropTable(
                name: "t_e_historiquecadeau_htc");

            migrationBuilder.DropTable(
                name: "t_e_panier_pnr");

            migrationBuilder.DropTable(
                name: "t_e_partenaireactivite_pta");

            migrationBuilder.DropTable(
                name: "t_e_partenairecave_ptc");

            migrationBuilder.DropTable(
                name: "t_e_partenairehebergement_pth");

            migrationBuilder.DropTable(
                name: "t_e_partenairerestaurant_ptr");

            migrationBuilder.DropTable(
                name: "t_e_sejourcadeau_sjc");

            migrationBuilder.DropTable(
                name: "t_j_comporte_cpt");

            migrationBuilder.DropTable(
                name: "t_j_concerne_ccr");

            migrationBuilder.DropTable(
                name: "t_j_contient_ctn");

            migrationBuilder.DropTable(
                name: "t_j_lienelementvignoble_lev");

            migrationBuilder.DropTable(
                name: "t_j_lienetape_lep");

            migrationBuilder.DropTable(
                name: "t_j_lienroutedesvins_lrv");

            migrationBuilder.DropTable(
                name: "t_j_liensejour_lsj");

            migrationBuilder.DropTable(
                name: "t_j_reported_rep");

            migrationBuilder.DropTable(
                name: "t_e_refcartebancaire_rcb");

            migrationBuilder.DropTable(
                name: "t_e_boncadeau_bcd");

            migrationBuilder.DropTable(
                name: "t_e_catparticipant_cpp");

            migrationBuilder.DropTable(
                name: "t_e_elementetape_ele");

            migrationBuilder.DropTable(
                name: "t_e_elementvignoble_evg");

            migrationBuilder.DropTable(
                name: "t_e_etape_etp");

            migrationBuilder.DropTable(
                name: "t_e_avis_avi");

            migrationBuilder.DropTable(
                name: "t_e_compte_cmp");

            migrationBuilder.DropTable(
                name: "t_e_partenaire_ptn");

            migrationBuilder.DropTable(
                name: "t_e_typeelementetape_tee");

            migrationBuilder.DropTable(
                name: "t_e_sejour_sjr");

            migrationBuilder.DropTable(
                name: "t_e_client_clt");

            migrationBuilder.DropTable(
                name: "t_e_motdepasse_mdp");

            migrationBuilder.DropTable(
                name: "t_e_typecompte_tpc");

            migrationBuilder.DropTable(
                name: "t_e_catsejour_csj");

            migrationBuilder.DropTable(
                name: "t_e_catvignoble_cvg");

            migrationBuilder.DropTable(
                name: "t_e_routedesvins_rdv");

            migrationBuilder.DropTable(
                name: "t_e_personne_prs");

            migrationBuilder.DropTable(
                name: "t_e_vignoble_vgb");

            migrationBuilder.DropTable(
                name: "t_e_lien_len");
        }
    }
}
