using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazingPizzaApp.Model
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }

        [Required, MinLength(5), MaxLength(100)]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string City { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string Region { get; set; }

        [Required, RegularExpression(@"^\d{5}(-\d{4})?$")]
        public string PostalCode { get; set; }
    }
}
