using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySiparisUygulamasi.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }

        public DateTime OrderDate { get; set; }
        public double OrderPrice { get; set; }
        public string OrderStatus { get; set; }
        public string OtherAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }

        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }
    }
}
