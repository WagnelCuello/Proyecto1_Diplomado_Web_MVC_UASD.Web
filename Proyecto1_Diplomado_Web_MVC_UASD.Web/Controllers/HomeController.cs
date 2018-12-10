using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1_Diplomado_Web_MVC_UASD.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<html><body>"+
                   "<h1>Universidad Autónoma de Santo Domingo (UASD)</h1>"+
                   "<p>Diplomado Web C#, MVC </p>"+
                   "</body></html>";
        }

        public string DiplomadoWeb()
        {
            return "<html><body>" +
                   "<h1>Estudiantes: </h1>" +
                   "<p>Yorqui Montero Sanchez<br>" +
                   "Junior Maria Araujo<br>" +
                   "Jose Juaquin Bido<br>" +
                   "Miguel Reyes<br>" +
                   "Eusebio de Hostos<br>" +
                   "Yunior Ramirez Perez<br>" +
                   "Roberto De Leon<br>" +
                   "Mario Coiscou Feliz<br>" +
                   "Felipe Zambrano Moyeto<br>" +
                   "Marileidy Manzueta De la rosa</p>" +
                   "</body></html>";
        }
    }
}