using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Models
{
    public class EventCategory
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public List<Event> events { get; set; }

        public EventCategory(string name)
        {
            Name = name;
        }

        public EventCategory()
        {
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