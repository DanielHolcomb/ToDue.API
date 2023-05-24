using ToDue.API.Models;

namespace ToDue.API.Interfaces;

public interface IToDueRepository
{
    Task<ToDueItem> CreateToDueItemAsync(ToDueItem toDueItem);
    Task<List<ToDueItem>> GetAllToDueItemsAsync();
}
