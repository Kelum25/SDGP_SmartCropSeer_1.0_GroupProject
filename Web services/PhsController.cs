using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartCropSeerNew;
using System.Web.Script.Serialization;

namespace SmartCropSeerNew.Controllers
{
    [RoutePrefix("api/Phs")]
    public class PhsController : Controller
    {
        private SmartCrop db = new SmartCrop();

        // GET: api/Phs
        [Route("Index")]
        public ActionResult Index()
        {
            string colorCode = this.Request.QueryString["colorCode"];
            //var result = db.Phs.Where(e => e.colourCode == colorCode);
            int[] phValues = new int[db.Phs.Count()];
            int index = 0;
            foreach (Ph ph in db.Phs)
            {
                string[] values = colorCode.Split(',');
                int red = Convert.ToInt16(values[0]);
                int green = Convert.ToInt16(values[1]);
                int blue = Convert.ToInt16(values[2]);

                string[] Phsvalues = ph.colourCode.Split(',');
                int Phsred = Convert.ToInt16(Phsvalues[0]);
                int Phsgreen = Convert.ToInt16(Phsvalues[1]);
                int Phsblue = Convert.ToInt16(Phsvalues[2]);

                phValues[index] = Math.Abs(red - Phsred) + Math.Abs(green - Phsgreen) + Math.Abs(blue - Phsblue);

                index++;
            }

            int pos = Enumerable.Range(0, phValues.Length)
                .Aggregate((a, b) => (phValues[a] < phValues[b]) ? a : b);

            return Content(new JavaScriptSerializer().Serialize(db.Phs.ToArray()[pos]), "application/json"); ;
        }
    }
}
