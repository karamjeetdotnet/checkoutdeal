using CheckoutDeal.Components;
using CheckoutDealDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckoutDeal.Areas.Admin.Controllers
{
    public class ManagementController : Controller
    {
        //
        // GET: /Admin/User/

        public ActionResult Index()
        {
            return View(Utils.GetPathFromNameSpace(this,"User"));
        }

        public ActionResult ProductView()
        {
            return View(Utils.GetPathFromNameSpace(this, "Product"));
        }

        public ActionResult UserView()
        {
            return Index();
        }
    }
}
