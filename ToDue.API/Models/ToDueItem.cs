namespace ToDue.API.Models;

public class ToDueItem
{
    public DateTime DueDate { get; set; }
    public string Name { get; set; }
    public int Difficulty { get; set; }
}
