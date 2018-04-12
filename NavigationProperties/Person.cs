using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationProperties
{
  public  class Person
    {
        [Key]
        public Guid Id { get; private set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }

    }
}
