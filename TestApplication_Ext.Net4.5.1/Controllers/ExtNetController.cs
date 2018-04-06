using System.Web.Mvc;

using Ext.Net;

using Ext.Net.MVC;

using TestApplication.Models;

using System.Data;

using System.Data.SqlClient;

using System.Configuration;

using System.Collections.Generic;

using System.IO;

using System.Web.UI;

namespace TestApplication.Controllers

{

    public class ExtNetController : Controller

    {

        public ActionResult Index()

        {

            return View();

        }



        public ActionResult JobInformation()

        {

            return View(SampleData.GetAllJobs());

        }



        public ActionResult OrderInformation()

        {

            return View(SampleData.GetAllOrders());

        }

    }

}