using Application.Interfaces;
using Domain;
using Infrastructure.EntityFramework;

namespace Infrastructure.Services;

public class ProjectService : IProjectService
{
    private readonly ApplicationDbContext _dbContext;

    public ProjectService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Project> GetProjects()
    {
        return _dbContext.Projects.ToList();
    }

    public Project GetProjectById(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);
        return project;
    }

    public void UpdateProject(int id, Project newProject)
    {
        var project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);
        if (project == null)
            throw new ArgumentException("Project not found!");
        project.Name = newProject.Name;
        project.Priority = newProject.Priority;
        project.StartDate = newProject.StartDate;
        project.EndDate = newProject.EndDate;
        project.Client = newProject.Client;
        project.ExecutiveCompanyName = newProject.ExecutiveCompanyName;

        _dbContext.SaveChanges();
    }

    public void DeleteProject(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);
        if (project is null)
            return;
        _dbContext.Projects.Remove(project);
        _dbContext.SaveChanges();
    }
}