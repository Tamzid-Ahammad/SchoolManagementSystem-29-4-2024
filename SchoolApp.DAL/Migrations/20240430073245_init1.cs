using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicYear",
                columns: table => new
                {
                    AcademicYearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicYear", x => x.AcademicYearId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    AttendanceIdentificationNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.AttendanceId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "ExamSchedule",
                columns: table => new
                {
                    ExamScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSchedule", x => x.ExamScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "ExamType",
                columns: table => new
                {
                    ExamTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamType", x => x.ExamTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FeeType",
                columns: table => new
                {
                    FeeTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeType", x => x.FeeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "StaffSalary",
                columns: table => new
                {
                    StaffSalaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FestivalBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HousingAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TransportationAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SavingFund = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Taxes = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffSalary", x => x.StaffSalaryId);
                });

            migrationBuilder.CreateTable(
                name: "Standard",
                columns: table => new
                {
                    StandardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandardCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standard", x => x.StandardId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.UserId, x.LoginProvider, x.ProviderKey });
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueStaffAttendanceNumber = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporaryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Designation = table.Column<int>(type: "int", nullable: true),
                    BankAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNumber = table.Column<int>(type: "int", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    StaffSalaryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId");
                    table.ForeignKey(
                        name: "FK_Staff_StaffSalary_StaffSalaryId",
                        column: x => x.StaffSalaryId,
                        principalTable: "StaffSalary",
                        principalColumn: "StaffSalaryId");
                });

            migrationBuilder.CreateTable(
                name: "dbsExamScheduleStandard",
                columns: table => new
                {
                    ExamScheduleStandardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScheduleId = table.Column<int>(type: "int", nullable: true),
                    StandardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbsExamScheduleStandard", x => x.ExamScheduleStandardId);
                    table.ForeignKey(
                        name: "FK_dbsExamScheduleStandard_ExamSchedule_ExamScheduleId",
                        column: x => x.ExamScheduleId,
                        principalTable: "ExamSchedule",
                        principalColumn: "ExamScheduleId");
                    table.ForeignKey(
                        name: "FK_dbsExamScheduleStandard_Standard_StandardId",
                        column: x => x.StandardId,
                        principalTable: "Standard",
                        principalColumn: "StandardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionNo = table.Column<int>(type: "int", nullable: false),
                    EnrollmentNo = table.Column<int>(type: "int", nullable: false),
                    UniqueStudentAttendanceNumber = table.Column<int>(type: "int", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentGender = table.Column<int>(type: "int", nullable: true),
                    StudentReligion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentBloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNIDNumber = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    StudentContactNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentContactNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporaryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherNID = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    FatherContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherNID = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    MotherContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGuardianContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Standard_StandardId",
                        column: x => x.StandardId,
                        principalTable: "Standard",
                        principalColumn: "StandardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectCode = table.Column<int>(type: "int", nullable: true),
                    StandardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subject_Standard_StandardId",
                        column: x => x.StandardId,
                        principalTable: "Standard",
                        principalColumn: "StandardId");
                });

            migrationBuilder.CreateTable(
                name: "StaffExperience",
                columns: table => new
                {
                    StaffExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffExperience", x => x.StaffExperienceId);
                    table.ForeignKey(
                        name: "FK_StaffExperience_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "MonthlyPayment",
                columns: table => new
                {
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    TotalFeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Waver = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreviousDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountRemaining = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyPayment", x => x.MonthlyPaymentId);
                    table.ForeignKey(
                        name: "FK_MonthlyPayment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "OthersPayment",
                columns: table => new
                {
                    OthersPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountRemaining = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OthersPayment", x => x.OthersPaymentId);
                    table.ForeignKey(
                        name: "FK_OthersPayment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "ExamSubject",
                columns: table => new
                {
                    ExamSubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScheduleStandardId = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ExamTypeId = table.Column<int>(type: "int", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExamStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExamEndTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSubject", x => x.ExamSubjectId);
                    table.ForeignKey(
                        name: "FK_ExamSubject_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "ExamTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamSubject_dbsExamScheduleStandard_ExamScheduleStandardId",
                        column: x => x.ExamScheduleStandardId,
                        principalTable: "dbsExamScheduleStandard",
                        principalColumn: "ExamScheduleStandardId");
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    MarkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalMarks = table.Column<int>(type: "int", nullable: false),
                    PassMarks = table.Column<int>(type: "int", nullable: false),
                    ObtainedScore = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    PassStatus = table.Column<int>(type: "int", nullable: false),
                    MarkEntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.MarkId);
                    table.ForeignKey(
                        name: "FK_Mark_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mark_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mark_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId");
                });

            migrationBuilder.CreateTable(
                name: "AcademicMonth",
                columns: table => new
                {
                    MonthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicMonth", x => x.MonthId);
                    table.ForeignKey(
                        name: "FK_AcademicMonth_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalTable: "MonthlyPayment",
                        principalColumn: "MonthlyPaymentId");
                });

            migrationBuilder.CreateTable(
                name: "DueBalance",
                columns: table => new
                {
                    DueBalanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    DueBalanceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DueBalance", x => x.DueBalanceId);
                    table.ForeignKey(
                        name: "FK_DueBalance_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalTable: "MonthlyPayment",
                        principalColumn: "MonthlyPaymentId");
                    table.ForeignKey(
                        name: "FK_DueBalance_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetail",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: false),
                    FeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetail", x => x.PaymentDetailId);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalTable: "MonthlyPayment",
                        principalColumn: "MonthlyPaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMonth",
                columns: table => new
                {
                    PaymentMonthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: false),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMonth", x => x.PaymentMonthId);
                    table.ForeignKey(
                        name: "FK_PaymentMonth_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalTable: "MonthlyPayment",
                        principalColumn: "MonthlyPaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fee",
                columns: table => new
                {
                    FeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeTypeId = table.Column<int>(type: "int", nullable: false),
                    StandardId = table.Column<int>(type: "int", nullable: false),
                    PaymentFrequency = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: true),
                    OthersPaymentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fee", x => x.FeeId);
                    table.ForeignKey(
                        name: "FK_Fee_FeeType_FeeTypeId",
                        column: x => x.FeeTypeId,
                        principalTable: "FeeType",
                        principalColumn: "FeeTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fee_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalTable: "MonthlyPayment",
                        principalColumn: "MonthlyPaymentId");
                    table.ForeignKey(
                        name: "FK_Fee_OthersPayment_OthersPaymentId",
                        column: x => x.OthersPaymentId,
                        principalTable: "OthersPayment",
                        principalColumn: "OthersPaymentId");
                    table.ForeignKey(
                        name: "FK_Fee_Standard_StandardId",
                        column: x => x.StandardId,
                        principalTable: "Standard",
                        principalColumn: "StandardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherPaymentDetail",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OthersPaymentId = table.Column<int>(type: "int", nullable: false),
                    FeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherPaymentDetail", x => x.PaymentDetailId);
                    table.ForeignKey(
                        name: "FK_OtherPaymentDetail_OthersPayment_OthersPaymentId",
                        column: x => x.OthersPaymentId,
                        principalTable: "OthersPayment",
                        principalColumn: "OthersPaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicMonth_MonthlyPaymentId",
                table: "AcademicMonth",
                column: "MonthlyPaymentId");

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
                name: "IX_dbsExamScheduleStandard_ExamScheduleId",
                table: "dbsExamScheduleStandard",
                column: "ExamScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_dbsExamScheduleStandard_StandardId",
                table: "dbsExamScheduleStandard",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_DueBalance_MonthlyPaymentId",
                table: "DueBalance",
                column: "MonthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_DueBalance_StudentId",
                table: "DueBalance",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubject_ExamScheduleStandardId",
                table: "ExamSubject",
                column: "ExamScheduleStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubject_ExamTypeId",
                table: "ExamSubject",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubject_SubjectId",
                table: "ExamSubject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_FeeTypeId",
                table: "Fee",
                column: "FeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_MonthlyPaymentId",
                table: "Fee",
                column: "MonthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_OthersPaymentId",
                table: "Fee",
                column: "OthersPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_StandardId",
                table: "Fee",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StaffId",
                table: "Mark",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StudentId",
                table: "Mark",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_SubjectId",
                table: "Mark",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyPayment_StudentId",
                table: "MonthlyPayment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherPaymentDetail_OthersPaymentId",
                table: "OtherPaymentDetail",
                column: "OthersPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_OthersPayment_StudentId",
                table: "OthersPayment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_MonthlyPaymentId",
                table: "PaymentDetail",
                column: "MonthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMonth_MonthlyPaymentId",
                table: "PaymentMonth",
                column: "MonthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DepartmentId",
                table: "Staff",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_StaffSalaryId",
                table: "Staff",
                column: "StaffSalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_UniqueStaffAttendanceNumber",
                table: "Staff",
                column: "UniqueStaffAttendanceNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StaffExperience_StaffId",
                table: "StaffExperience",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_AdmissionNo",
                table: "Student",
                column: "AdmissionNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_EnrollmentNo",
                table: "Student",
                column: "EnrollmentNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_StandardId",
                table: "Student",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UniqueStudentAttendanceNumber",
                table: "Student",
                column: "UniqueStudentAttendanceNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StandardId",
                table: "Subject",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectCode",
                table: "Subject",
                column: "SubjectCode",
                unique: true,
                filter: "[SubjectCode] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicMonth");

            migrationBuilder.DropTable(
                name: "AcademicYear");

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
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "DueBalance");

            migrationBuilder.DropTable(
                name: "ExamSubject");

            migrationBuilder.DropTable(
                name: "Fee");

            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "OtherPaymentDetail");

            migrationBuilder.DropTable(
                name: "PaymentDetail");

            migrationBuilder.DropTable(
                name: "PaymentMonth");

            migrationBuilder.DropTable(
                name: "StaffExperience");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ExamType");

            migrationBuilder.DropTable(
                name: "dbsExamScheduleStandard");

            migrationBuilder.DropTable(
                name: "FeeType");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "OthersPayment");

            migrationBuilder.DropTable(
                name: "MonthlyPayment");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "ExamSchedule");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "StaffSalary");

            migrationBuilder.DropTable(
                name: "Standard");
        }
    }
}
