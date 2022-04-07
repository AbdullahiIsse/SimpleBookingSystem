using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimpleBookingSystemApi.Model
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        
        
        public DateTime DateFrom { get; set; } = DateTime.Now;
        
       
        public DateTime DateTo { get; set; } = DateTime.Now.AddDays(2);

        public int BookedQuantity { get; set; } = 1;

        [JsonIgnore]
        public Resource Resource { get; set; }
    }
}