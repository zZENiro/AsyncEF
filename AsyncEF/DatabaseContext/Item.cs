using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncEF.DatabaseContext
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ItemName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ItemCost { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ItemType { get; set; }
    }
}
