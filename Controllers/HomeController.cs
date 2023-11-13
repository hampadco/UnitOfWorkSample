

using Microsoft.AspNetCore.Mvc;

[Route("[Action]")]
[ApiController]

public class HomeController: ControllerBase
{
    private readonly IStudent _student;
   
    //ILog
    private readonly ILog _log;

    public HomeController(IStudent student,ILog log)
    {
        _student = student;
        _log = log;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(_student.GetAllStudent());
    }

    [HttpPost]
    public IActionResult AddStudent(TblStudent student)
    {
        _student.AddStudent(student);
        return Ok();
    }

    [HttpGet]
    //GetAll Log
    public IActionResult GetAllLog()
    {
        return Ok(_log.GetAllLog());
    }



    
}