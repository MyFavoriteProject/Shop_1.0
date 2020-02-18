using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Models
{
    public class Order
    {
        [BindNever]
        public int ID { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Днина имени не более 20-ти символов")]
        public string Name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [StringLength(20)]
        [Required(ErrorMessage = "Днина фамилии не более 20-ти символов")]
        public string Surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(30)]
        [Required(ErrorMessage = "Днина адреса не более 30-ти символов")]
        public string Adress { get; set; }

        [Display(Name = "Введите телефон")]
        [StringLength(12)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Днина номера не более 12-ти символов")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Днина email не более 30-ти символов")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
