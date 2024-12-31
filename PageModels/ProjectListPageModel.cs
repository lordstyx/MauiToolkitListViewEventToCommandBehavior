#nullable disable
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiToolkitListViewEventToCommandBehavior.Models;

namespace MauiToolkitListViewEventToCommandBehavior.PageModels
{
    public partial class ProjectListPageModel : ObservableObject
    {
        private readonly ProjectRepository _projectRepository;

        [ObservableProperty]
        private List<Project> _projects = [];

        public ProjectListPageModel(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [RelayCommand]
        private Task Appearing()
        {
            Projects = [
                new Project { ID = 1, Name = "Project1", Description = "Project 1 description" },
                new Project { ID = 2, Name = "Project2", Description = "Project 2 description" }
            ];
            return Task.CompletedTask;
        }

        [RelayCommand]
        Task NavigateToProject(Project project)
            => Shell.Current.GoToAsync($"project?id={project.ID}");

        [RelayCommand]
        async Task AddProject()
        {
            await Shell.Current.GoToAsync($"project");
        }
    }
}