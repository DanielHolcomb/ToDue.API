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
    }
}
