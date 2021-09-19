using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string ContactEmail { get; set; }

        [Required]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage = "Attendance between 0 and 100,000")]
        public int NumberAttendees { get; set; }

        public bool IsTrue { get { return true; } }

        [Compare(nameof(IsTrue), ErrorMessage = "You must register.")]
        public bool MustRegister { get; set; }
    }
}