using ToDue.API.Interfaces;
using ToDue.API.Models;

namespace ToDue.API.ToDueService;

public class ToDueService : IToDueService
{
    private readonly IToDueRepository _toDueRepository;

    public ToDueService(IToDueRepository toDueRepository)
    {
        _toDueRepository = toDueRepository;
    }

    public async Task<ToDueItem> CreateToDueItem(ToDueItem toDueItem)
    {
        var newToDueItem = await _toDueRepository.CreateToDueItemAsync(toDueItem);
        return newToDueItem;
    }

    public async Task<List<ToDueItem>> GetTodaysToDueList()
    {
        var allToDueItems = await _toDueRepository.GetAllToDueItemsAsync();
        var todaysToDueItems = new List<ToDueItem>();

        //Logic for determining what should be today's todue items



        return todaysToDueItems;
    }
}
