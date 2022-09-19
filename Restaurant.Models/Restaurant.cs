using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    [Table(name: "Restaurants")]
    public class Restaurant
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
