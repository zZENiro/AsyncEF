using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncEF.DatabaseContext
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; } 

        [Required(AllowEmptyStrings = false)]
        public string CustomerName { get; set; }

        public string CustomerKey { get; set; }
    }
}
