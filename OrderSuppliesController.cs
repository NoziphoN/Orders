using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GateBoys.Models;
using IdentitySample.Models;
using Rotativa;

namespace GateBoys.Controllers
{
    public class OrderSuppliesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OrderSupplies
        public ActionResult Index()
        {
            return View(db.OrderSupplies.ToList());
        }
       // GET: OrderSupplies
        public ActionResult IndexPrintAll()
        {
            var fileP = db.OrderSupplies.ToList().Where(x => x.status == "Pending");
            return new Rotativa.ViewAsPdf(fileP) { FileName = $"pending_gateboys_orders_{DateTime.Now.ToShortDateString()}.pdf" };
        }
       // GET: OrderSupplies
        public ActionResult IndexPrintAllOrdered()
        {
            var fileP = db.OrderSupplies.ToList().Where(x => x.status == "Delivered");
            return new Rotativa.ViewAsPdf(fileP) { FileName = $"allDelivered_gateboys_orders_{DateTime.Now.ToShortDateString()}.pdf" };
        }

        public ActionResult PrintToPdf(int? id)
        {
            var fileP = db.OrderSupplies.Where(x => x.orderId == id).First();
            return new Rotativa.ViewAsPdf(fileP) { FileName = $"gateboys_order{fileP.OrderNum}_{DateTime.Now.ToShortDateString()}.pdf" };
            //return View(fileP);
        }
        // GET: OrderSupplies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderSupply orderSupply = db.OrderSupplies.Find(id);
            if (orderSupply == null)
            {
                return HttpNotFound();
            }
            return View(orderSupply);
        }

        // GET: OrderSupplies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderSupplies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "orderId,OrderNum,supplier,supplierEmail,suplyNum,itemQty,ProductsList,NumOfProdOrdered,orderedBy,totalOrder,dateOrdered,status,isOrdered")] OrderSupply orderSupply)
        {
            if (ModelState.IsValid)
            {
                db.OrderSupplies.Add(orderSupply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderSupply);
        }

        // GET: OrderSupplies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderSupply orderSupply = db.OrderSupplies.Find(id);
            if (orderSupply == null)
            {
                return HttpNotFound();
            }
            return View(orderSupply);
        }

        // POST: OrderSupplies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "orderId,OrderNum,supplier,supplierEmail,suplyNum,itemQty,ProductsList,NumOfProdOrdered,orderedBy,totalOrder,dateOrdered,status,isOrdered")] OrderSupply orderSupply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderSupply).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderSupply);
        }

        // GET: OrderSupplies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderSupply orderSupply = db.OrderSupplies.Find(id);
            if (orderSupply == null)
            {
                return HttpNotFound();
            }
            return View(orderSupply);
        }

        // POST: OrderSupplies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderSupply orderSupply = db.OrderSupplies.Find(id);
            db.OrderSupplies.Remove(orderSupply);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
