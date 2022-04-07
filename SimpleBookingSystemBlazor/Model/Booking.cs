using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimpleBookingSystemBlazor.Model
{
    public class Booking
    {
        public int Id { get; set; }
        
        [Required]
        
        public DateTime DateFrom { get; set; } = DateTime.Now;
        
        [Required] public DateTime DateTo { get; set; } = DateTime.Now.AddDays(2);
        [Required] public int BookedQuantity { get; set; } = 1;
        
        [JsonIgnore]
        public Resource Resource { get; set; }
    }
}