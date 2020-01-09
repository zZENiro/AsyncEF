using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncEF.DatabaseContext
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string ClientName { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string ClientPhone { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string ClientEmail { get; set; }
    }
}
