﻿using GymManger.DataAccess.Reports;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System;
using System.IO;
using System.Threading;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IGeneratePdf _generatePdf;
        private readonly IWebHostEnvironment _environment;
        public ReportsController(IWebHostEnvironment environment, IGeneratePdf generatePdf) 
        {
            _generatePdf= generatePdf;
            _environment= environment;
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

            report.SetParameters(new ReportParameter[] { new ReportParameter("DateForm", DateTime.Today.AddDays(-10).ToString()),
             new ReportParameter("DateTo", DateTime.Today.ToString())});

            report.DataSources.Add(new ReportDataSource("Members", (System.Data.DataTable)dataSet.Member));

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);


            return File(streamBytes, mimeType, $"{ reportName}.{filenameExtension}");
        }
    }
}