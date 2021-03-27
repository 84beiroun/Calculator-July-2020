using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.TwoArgsClasses;
using Calculator.OneArgClasses;

namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "mult", Text = "multiply" },
                new SelectListItem() { Value = "plus", Text = "sum" },
                new SelectListItem() { Value = "minus", Text = "minus" },
                new SelectListItem() { Value = "div", Text = "division" },
                new SelectListItem() { Value = "sin", Text = "sin" },
                new SelectListItem() { Value = "cos", Text = "cos" },
                new SelectListItem() { Value = "tg", Text = "tg" },
                new SelectListItem() { Value = "ctg", Text = "ctg" },
                new SelectListItem() { Value = "sqrt", Text = "sqrt" }
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(
            double firstNumber,
            double secondNumber,
            string operation)
        {
            string[] arr = { "mult", "div", "plus", "minus" };
            double result;
            if (arr.Contains(operation))
            {
                ITwoArgCalculator calculator = TwoArgFactory.CreateCalculator(operation);
                result = calculator.Calculate(firstNumber, secondNumber);
            }
            else
            {
                IOneArgCalculator calculator = OneArgFactory.CreateCalculator(operation);
                result = calculator.Calculate(firstNumber);
            }

            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "mult", Text = "multiply" },
                new SelectListItem() { Value = "plus", Text = "sum" },
                new SelectListItem() { Value = "minus", Text = "minus" },
                new SelectListItem() { Value = "div", Text = "division" },
                new SelectListItem() { Value = "sin", Text = "sin" },
                new SelectListItem() { Value = "cos", Text = "cos" },
                new SelectListItem() { Value = "tg", Text = "tg" },
                new SelectListItem() { Value = "ctg", Text = "ctg" },
                new SelectListItem() { Value = "sqrt", Text = "sqrt" }
            };
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
    }
}