using CommunityToolkit.Mvvm.Input;
using RoomToRentRadar.Models;

namespace RoomToRentRadar.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}