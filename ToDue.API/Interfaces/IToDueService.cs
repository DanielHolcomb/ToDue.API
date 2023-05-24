using ToDue.API.Models;

namespace ToDue.API.Interfaces;

public interface IToDueService
{
    public Task<ToDueItem> CreateToDueItem(ToDueItem toDueItem);
    public Task<List<ToDueItem>> GetTodaysToDueList();
}
