using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VamBlazor.Client.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AMALKARD",
                columns: table => new
                {
                    date = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    mandeh = table.Column<decimal>(type: "numeric(19,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HESAB",
                columns: table => new
                {
                    hesab_no = table.Column<long>(type: "bigint", nullable: false),
                    scode = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    pcode = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    firstqty = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0m),
                    date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    curqty = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0m),
                    monthqty = table.Column<long>(type: "bigint", nullable: true),
                    p = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    p1 = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    id___di = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HESAB", x => x.hesab_no);
                });

            migrationBuilder.CreateTable(
                name: "PARDAR",
                columns: table => new
                {
                    id___di = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scode = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true, defaultValue: "01"),
                    pcode = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    action = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    mblg = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0m),
                    date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    req_no = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, defaultValueSql: "(space((1)))"),
                    babat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(space((1)))"),
                    Khayer = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, defaultValueSql: "(space((1)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARDAR", x => x.id___di);
                });

            migrationBuilder.CreateTable(
                name: "PERSON",
                columns: table => new
                {
                    code = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    family = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    father = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    sex = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    issue_no = table.Column<string>(type: "char(15)", unicode: false, fixedLength: true, maxLength: 15, nullable: true),
                    tel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    city = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    mellicode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    id___di = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "((1))"),
                    CardBank = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    BankType = table.Column<int>(type: "int", nullable: true),
                    HesabBank = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSON", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "QVAM",
                columns: table => new
                {
                    REQ_NO = table.Column<int>(type: "int", nullable: false),
                    PCODE = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    MBLG = table.Column<long>(type: "bigint", nullable: true),
                    DATE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SABTDATE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "(space((8)))"),
                    TYPE = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QVAM", x => x.REQ_NO);
                });

            migrationBuilder.CreateTable(
                name: "SANDOGH",
                columns: table => new
                {
                    code = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    onvan = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: true),
                    maxetebar = table.Column<decimal>(type: "numeric(19,0)", nullable: true),
                    firstqty = table.Column<decimal>(type: "numeric(19,0)", nullable: true),
                    curqty = table.Column<decimal>(type: "numeric(19,0)", nullable: true),
                    etebar = table.Column<decimal>(type: "numeric(19,0)", nullable: true),
                    type = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                columns: table => new
                {
                    id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    Sobh = table.Column<bool>(type: "bit", nullable: false),
                    Zohr = table.Column<bool>(type: "bit", nullable: false),
                    Shab = table.Column<bool>(type: "bit", nullable: false),
                    Vahed1 = table.Column<bool>(type: "bit", nullable: false),
                    Vahed2 = table.Column<bool>(type: "bit", nullable: false),
                    Vahed3 = table.Column<bool>(type: "bit", nullable: true),
                    Lab = table.Column<bool>(type: "bit", nullable: false),
                    Tolid = table.Column<bool>(type: "bit", nullable: false),
                    Control = table.Column<bool>(type: "bit", nullable: false),
                    Energy = table.Column<bool>(type: "bit", nullable: false),
                    Anbar = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblDate10",
                columns: table => new
                {
                    GDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    HYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    GYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    HYrMth = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    GYrMth = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    HMonthNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GMonthNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HMonthName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GMonthName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HWeekNo = table.Column<byte>(type: "tinyint", nullable: true),
                    GWeekNo = table.Column<byte>(type: "tinyint", nullable: true),
                    HDay = table.Column<byte>(type: "tinyint", nullable: true),
                    GDay = table.Column<byte>(type: "tinyint", nullable: true),
                    HMonthLen = table.Column<byte>(type: "tinyint", nullable: true),
                    GMonthLen = table.Column<byte>(type: "tinyint", nullable: true),
                    HWeekDayName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GWeekDayName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    HWeekDayNo = table.Column<byte>(type: "tinyint", nullable: true),
                    GWeekDayNo = table.Column<byte>(type: "tinyint", nullable: true),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDate10", x => x.GDate);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Password = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Access = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    Menu1Option = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Menu2Option = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Menu3Option = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Menu4Option = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    SubMenu1 = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    SubMenu2 = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    SubMenu3 = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    SubMenu4 = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    ToolBar = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    StartTime = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    EndTime = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UsersLog",
                columns: table => new
                {
                    id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    actionDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    ActionTime = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    station = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    System = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PVAM",
                columns: table => new
                {
                    req_no = table.Column<int>(type: "int", nullable: false),
                    scode = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true, defaultValue: "01"),
                    mblgvam = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    gst1 = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    gst2 = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    gst_no = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    date_d = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    date_g = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    gst_pay = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    status = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    sabtdate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    pkarmozd = table.Column<int>(type: "int", nullable: true),
                    mkarmozd = table.Column<int>(type: "int", nullable: true),
                    lastdate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    type = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    mblgmain = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PVAM", x => x.req_no);
                    table.ForeignKey(
                        name: "FK_PVAM_QVAM",
                        column: x => x.req_no,
                        principalTable: "QVAM",
                        principalColumn: "REQ_NO");
                });

            migrationBuilder.CreateTable(
                name: "DARGST",
                columns: table => new
                {
                    req_no = table.Column<int>(type: "int", nullable: false),
                    gst_no = table.Column<byte>(type: "tinyint", nullable: false),
                    date_g = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "(space((1)))"),
                    date_p = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "(space((1)))"),
                    status = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "(space((1)))"),
                    pasandaz = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    gstmblg = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DARGST", x => new { x.req_no, x.gst_no });
                    table.ForeignKey(
                        name: "FK_DARGST_PVAM",
                        column: x => x.req_no,
                        principalTable: "PVAM",
                        principalColumn: "req_no",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PARDAR",
                table: "PARDAR",
                columns: new[] { "date", "pcode", "action" })
                .Annotation("SqlServer:Clustered", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AMALKARD");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "DARGST");

            migrationBuilder.DropTable(
                name: "HESAB");

            migrationBuilder.DropTable(
                name: "PARDAR");

            migrationBuilder.DropTable(
                name: "PERSON");

            migrationBuilder.DropTable(
                name: "SANDOGH");

            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DropTable(
                name: "tblDate10");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersLog");

            migrationBuilder.DropTable(
                name: "PVAM");

            migrationBuilder.DropTable(
                name: "QVAM");
        }
    }
}
