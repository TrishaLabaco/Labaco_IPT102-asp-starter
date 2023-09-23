using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Trisha Labaco", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Winter Labaco", StudentId = "S002", StudentAge = "21" },
            new StudentInfoModel { Name = "Klio Labaco", StudentId = "S003", StudentAge = "23" }
        };

        return View(studentInfoArray);
    }
}
