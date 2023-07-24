using Microsoft.AspNetCore.Mvc;
using WebApp_Mvc_Db.Models;
namespace WebApp_Mvc_Db.Controllers
{
    public class EmployeeController : Controller
    {

          private readonly AppdbContext context;

            public EmployeeController(AppdbContext context)
            {
                this.context=context;
            }

            [HttpGet]
            public IActionResult Index()
            {
               
                return View(context.Employees.ToList<Employee>());
            }

            [HttpGet]
            public IActionResult Details(int id)
            {
            Employee obj = context.Employees.FirstOrDefault(emp => emp.Id == id);
                return View(obj);
            }

        public ActionResult Create() { 
        return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if(ModelState.IsValid){
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                } }
            catch
            {
                return View();
            }
            return View();
        }
       
        public ActionResult Edit(int id)
        {
            Employee obj=context.Employees.Find(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Employees.Update(emp);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
        {
            try
            {
               
                
                    context.Employees.Remove(emp);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }
            
        }

    }
}
    

