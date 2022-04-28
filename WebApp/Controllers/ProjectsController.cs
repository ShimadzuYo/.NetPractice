using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Projects;

namespace WebApp.Controllers;

[Route("[controller]/[action]")]
public class ProjectsController : Controller
{
    private readonly IProjectService _projectService;

    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpGet]
    public IActionResult List()
    {
        var projects = _projectService.GetProjects();
        var viewModel = new ProjectListViewModel
        {
            Projects = projects
        };
        return View(viewModel);
    }

    [HttpGet("{id:int}")]
    public IActionResult Details(int id)
    {
        var project = _projectService.GetProjectById(id);
        if (project is null)
            return RedirectToAction(nameof(List));
        var viewModel = new ProjectDetailsViewModel
        {
            Project = project
        };
        return View(viewModel);
    }

    [HttpGet("{id:int}")]
    public IActionResult Delete(int id)
    {
        _projectService.DeleteProject(id);
        return RedirectToAction(nameof(List));
    }
}