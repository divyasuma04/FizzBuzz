using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Models;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult GetOutputValues(GivenValues gv)
        {
            try
            {
                var num = gv.InputValues.Split(',');
                string[] outputarr = new string[num.Length];
                int cur = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if (int.TryParse(num[i], out cur))
                    {
                        if (cur % 3 == 0 && cur % 5 == 0)
                        {
                            outputarr[i] = "FizzBuzz";
                        }
                        else if (cur % 3 != 0 && cur % 5 == 0)
                        {
                            outputarr[i] = "Buzz";
                        }
                        else if (cur % 3 == 0 && cur % 5 != 0)
                        {
                            outputarr[i] = "Fizz";
                        }
                        else if (cur % 3 != 0 && cur % 5 != 0)
                        {
                            outputarr[i] = "Divided "+cur +" by 3, Divided "+cur+" by 5";
                        }
                    }
                    else
                    {
                        outputarr[i] = "Invalid Item";
                    }
                }
                gv.OutPutValues = outputarr;
            }
            catch (Exception ex)
            {
                //do nothing
            }
            finally
            {
                //do nothing
            }
            return View(gv);
        }
    }
}