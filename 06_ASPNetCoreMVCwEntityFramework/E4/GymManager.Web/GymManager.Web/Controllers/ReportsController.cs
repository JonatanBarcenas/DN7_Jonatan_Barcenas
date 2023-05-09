using GymManager.AplicationServices.Members;
using GymManger.DataAccess;
using GymManger.DataAccess.Reports;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.NETCore;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IGeneratePdf _generatePdf;
        private readonly IWebHostEnvironment _environment;
        private readonly GymManagerContext _context;
        public ReportsController(IWebHostEnvironment environment, IGeneratePdf generatePdf, GymManagerContext context) 
        {
            _generatePdf= generatePdf;
            _environment= environment;
            _context= context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewMembers()
        {
            string path = System.IO.Path.Combine(_environment.ContentRootPath, "Reports\\NewMembers.rdlc");
            Stream reportsDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages= true;
            report.LoadReportDefinition(reportsDefinition);

            MembersDataSet dataSet = new MembersDataSet();
            Random random = new Random();
            string[] membershipTypes = new string[] { "Basic", "Family", "Gold" };

            for (int i = 0;i < 28; i++)
            {
                var row = dataSet.Member.NewMemberRow();
                row.Name = $"Member Perez{i}";
                int day = random.Next(1, 10) * -1;
                row.RegisteredOn = DateTime.Today.AddDays(day);
                int index = random.Next(0,2);
                row.MembershipType = membershipTypes[index];

                dataSet.Member.Rows.Add(row);
            }

            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string reportName = "NewMembers";
            string[] streamids = null;
            Warning[] warnings= null;

            report.SetParameters(new ReportParameter[] { new ReportParameter("DateFrom", DateTime.Today.AddDays(-10).ToString()),
             new ReportParameter("DateTo", DateTime.Today.ToString())});

            report.DataSources.Add(new ReportDataSource("Members", (System.Data.DataTable)dataSet.Member));

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);


            return File(streamBytes, mimeType, $"{ reportName}.{filenameExtension}");
        }

        public IActionResult Attendance()
        {
     
            var startDate = DateTime.Today.AddDays(-30);
            var endDate = DateTime.Today;
            var membersAttendance = _context.Members
                .Select(m => new
                {
                    MemberName = m.Name,
                    AttendanceCount = m.Attendances
                    .Where(a => a.AttendanceDate >= startDate && a.AttendanceDate <= endDate)
                        .Count()
                })
                .OrderByDescending(m => m.AttendanceCount)
                .Take(20)
                .ToList();

            

            var daysOfWeek = new[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            var attendanceByDayOfWeek = _context.Attendances
    .Where(a => a.AttendanceDate >= DateTime.Today.AddDays(-7))
    .AsEnumerable()
    .GroupBy(a => a.AttendanceDate.DayOfWeek)
    .Select(group => new {
        DayOfWeek = group.Key,
        Count = group.Count()
    })
    .ToList();

            MembersDataSet dataSet = new MembersDataSet();

            foreach (var memberAttendance in membersAttendance)
            {
                var row = dataSet.MemberAttendace.NewMemberAttendaceRow();
        
                row.Name = memberAttendance.MemberName;
                row.Count = memberAttendance.AttendanceCount;
                dataSet.MemberAttendace.AddMemberAttendaceRow(row);
                
            }

            foreach (var attendanceByDay in attendanceByDayOfWeek)
            {
                var row = dataSet.AttendanceByDayOfWeek.NewAttendanceByDayOfWeekRow();
                row.DayOfWeek = daysOfWeek[(int)attendanceByDay.DayOfWeek];
                row.AttendanceCount = attendanceByDay.Count;
                dataSet.AttendanceByDayOfWeek.AddAttendanceByDayOfWeekRow(row);
            }

            string path = System.IO.Path.Combine(_environment.ContentRootPath, "Reports\\Attendance.rdlc");
            Stream reportsDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages = true;
            report.LoadReportDefinition(reportsDefinition);

            
            report.DataSources.Add(new ReportDataSource("MembersAttendance", (DataTable)dataSet.MemberAttendace));
            report.DataSources.Add(new ReportDataSource("AttendanceByDayOfWeek", (DataTable)dataSet.AttendanceByDayOfWeek));

            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string reportName = "Attendance";
            string[] streamids = null;
            Warning[] warnings = null;
            report.SetParameters(new ReportParameter[] { new ReportParameter("DateFrom", DateTime.Today.AddDays(-10).ToString()),
             new ReportParameter("DateTo", DateTime.Today.ToString())});

            

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);


            return File(streamBytes, mimeType, $"{reportName}.{filenameExtension}");
        }



    }
}
