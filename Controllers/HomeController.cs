using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
    public class HomeController : Controller
    {
        [Route("/form")]
            public ActionResult Form()
            {
              return View();
            }

        [Route("/parcels")]
            public ActionResult Parcels()
            {
                ParcelVariable myParcelVariable = new ParcelVariable();
                myParcelVariable.SetRecipient(Request.Query["recip"]);
                string stringWeight = Request.Query["weight"];
                myParcelVariable.SetWeight(int.Parse(stringWeight));
                string stringDimX = Request.Query["dimX"];
                myParcelVariable.SetDimX(int.Parse(stringDimX));
                string stringDimY = Request.Query["dimY"];
                myParcelVariable.SetDimY(int.Parse(stringDimY));
                string stringDimZ = Request.Query["dimZ"];
                myParcelVariable.SetDimZ(int.Parse(stringDimZ));
                return View("Parcels", myParcelVariable);
            }


        public string Hello() { return "Hello friend!"; }
    }
}
