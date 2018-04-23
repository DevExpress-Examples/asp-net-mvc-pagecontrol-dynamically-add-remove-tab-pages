using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E4864.Models;

namespace E4864.Controllers
{
    public class HomeController : Controller
    {
        static int counter;

        public ActionResult Index() {
            return View();
        }

        [HttpGet]
        public ActionResult PageControlPartial() {
            List<TabInfo> data = new List<TabInfo>();

            data.Add(new TabInfo() {
                Name = Guid.NewGuid().ToString(),
                Text = "Tab",
                Content = "Tab Content"
            });

            Session["TabData"] = data;
            return PartialView("_PageControlPartial", data);
        }

        [HttpPost]
        public ActionResult PageControlPartial(string command, string parameter) {
            List<TabInfo> data = ((List<TabInfo>) Session["TabData"]) ?? new List<TabInfo>();

            switch (command) {
                case "ADD":
                    data.Add(new TabInfo() {
                        Name = Guid.NewGuid().ToString(),
                        Text = String.Format("Tab {0}", counter),
                        Content = String.Format("Tab {0} content", counter)
                    });
                    counter++;
                    break;
                case "REMOVE":
                    if (data.Count > 1)
                        data.RemoveAll(info => info.Name == parameter);
                    break;

            }

            Session["TabData"] = data;
            return PartialView("_PageControlPartial", data);
        }
    }
}