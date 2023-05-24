using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDueViewModels;

public class ToDueItemViewModel
{
    [Required]
    [StringLength(100, MinimumLength = 4)]
    public string Name { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    [Range(0, 55)]
    public int Difficulty { get; set; }
}
