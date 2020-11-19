using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormExample.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Lütfen adınızı giriniz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="Lütfen soyadı giriniz.")]
        public string LastName { get; set; }
        [Phone(ErrorMessage ="Telefon numarasını doğru bir biçimde giriniz.")]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }
    }
}
