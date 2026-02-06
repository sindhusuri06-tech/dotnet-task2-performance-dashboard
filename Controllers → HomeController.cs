using System.Collections.Generic;
using System.Web.Mvc;
using PerformanceDashboard.Models;

namespace PerformanceDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Metric> data = new List<Metric>()
            {
                new Metric{Name="CPU Usage",Value="45%"},
                new Metric{Name="Memory Usage",Value="2.1 GB"},
                new Metric{Name="Requests/sec",Value="120"},
                new Metric{Name="Response Time",Value="250 ms"}
            };

            return View(data);
        }
    }
}
