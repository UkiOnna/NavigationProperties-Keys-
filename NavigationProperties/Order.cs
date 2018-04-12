using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationProperties
{
    public class Order
    {
        [Key]
        public Guid Id { get; private set; }
        public String ItemName { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Person Person { get; set; }
        public Guid PersonId { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
        }
    }
}
