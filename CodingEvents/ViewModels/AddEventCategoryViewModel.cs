using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventCategoryViewModel
    {
        [Required, StringLength(20, MinimumLength = 3, ErrorMessage = "Must be between 3 and 20 characters.")]
        public string Name { get; set; }
    }
}