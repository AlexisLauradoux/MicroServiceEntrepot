using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroServiceEntrepot
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Type { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }


        public int Quantity { get; set; }
    }
}
