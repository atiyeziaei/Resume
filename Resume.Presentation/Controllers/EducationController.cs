using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Presentation.Controllers;

public class EducationController : Controller
{
    private readonly ResumeDbContext _context;

    public EducationController(ResumeDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult ListOfEducation()
    {
        //list of education
        List<Education> educations = _context.Educations.ToList();

        //Get a education
        Education education = _context.Educations.First();
        return View();
    }
    public IActionResult CreateAnEducation()
    {

        Education education =new Education()
        {
            EducationTitle = "testi",
            EducationDuration = "2023",
            Description = "Degree"
        };
        
        _context.Educations.Add(education);
        _context.SaveChanges();
        return View();
    }
}
