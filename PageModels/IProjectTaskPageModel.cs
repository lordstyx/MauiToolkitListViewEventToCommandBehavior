using CommunityToolkit.Mvvm.Input;
using MauiToolkitListViewEventToCommandBehavior.Models;

namespace MauiToolkitListViewEventToCommandBehavior.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}