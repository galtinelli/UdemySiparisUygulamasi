using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySiparisUygulamasi.Models
{
    public class Cart
    {
        //Id yazdığımız için Key yazmamıza gerek yok
        [Key]
        public int Id { get; set; }

        //Identityden gelen Id string geliyor
        public string AppUserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        //Bir sepet bir kişiye ait olabilir

        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }


        //Bir sepette birden fazla ürün olur
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public Cart()
        {
            Count = 1;
        }
    }
}
