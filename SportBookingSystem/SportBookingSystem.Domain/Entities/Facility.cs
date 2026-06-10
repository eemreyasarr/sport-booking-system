using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Domain.Entities
{
    public class Facility
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public Facility(string name, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
        }
    }
}
