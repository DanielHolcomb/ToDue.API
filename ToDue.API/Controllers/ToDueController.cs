using Microsoft.AspNetCore.Mvc;
using ToDue.API.Interfaces;
using ToDue.API.Models;
using ToDueViewModels;

namespace ToDue.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDueController : ControllerBase
{
    private readonly ILogger<ToDueController> _logger;
    private readonly IToDueService _toDueService;

    public ToDueController(ILogger<ToDueController> logger, IToDueService toDueService)
    {
        _logger = logger;
        _toDueService = toDueService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateToDueItem([FromBody]ToDueItemViewModel toDueItem)
    {
        var newToDueItem = new ToDueItem
        {
            Name = toDueItem.Name,
            DueDate = toDueItem.DueDate,
        };

        try
        {
            var response = await _toDueService.CreateToDueItem(newToDueItem);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}