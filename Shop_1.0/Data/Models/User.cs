using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Введите логин")]
        [StringLength(20)]
        [Required(ErrorMessage = "Днина логина не более 20-ти символов")]
        [Index(IsUnique =true)]
        public string Login { get; set; }

        [Display(Name = "Введите пароль")]
        [StringLength(20)]
        [Required(ErrorMessage = "Днина пароля не более 20-ти символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Днина имени не более 20-ти символов")]
        public string FirstName { get; set; }

        [Display(Name = "Введите Фамилию")]
        [StringLength(20)]
        [Required(ErrorMessage = "Днина фамилии не более 20-ти символов")]
        public string SecondName { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
