using System;
namespace CodingEvents.Models
{
    public class Event
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string Location { get; set; }
        public int NumberAttendees { get; set; }
        public bool MustRegister { get; set; }


        public Event(string name, string description, string contactEmail, string location, int attendees, bool register) : this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            Location = location;
            NumberAttendees = attendees;
            MustRegister = register;
        }

        public Event()
        {
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}