using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class HomeControllerTodo : Controller
    {
        private static List<string> tasks = new List<string>
        {
            "Ôn tập HTML",
            "Ôn tập CSS",
            "Ôn tập Bootstrap"
        };
        public IActionResult Index()
        {
            ViewBag.Tasks = tasks;
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string newTask)
        {
            if (!string.IsNullOrEmpty(newTask))
            {
                tasks.Add(newTask);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditGet(int id)
        {
            if (id >= 0 && id < tasks.Count)
            {
                ViewBag.TaskId = id;
                ViewBag.TaskName = tasks[id];
                return View();
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditPost(int id, string updatedTask)
        {
            if (id >= 0 && id < tasks.Count && !string.IsNullOrEmpty(updatedTask))
            {
                tasks[id] = updatedTask;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (id >= 0 && id < tasks.Count)
            {
                tasks.RemoveAt(id);
            }
            return RedirectToAction("Index");
        }
    }
}
