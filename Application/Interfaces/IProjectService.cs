using Domain;


namespace Application.Interfaces;

public interface IProjectService
{
    List<Project> GetProjects();
    Project GetProjectById(int id);
    void UpdateProject(int id, Project project);
    void DeleteProject(int id);
}