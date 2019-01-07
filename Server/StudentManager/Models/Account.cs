using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class Account
    {
        private MD5 _algorithm = MD5.Create();
        public Account()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            DeletedAt = DateTime.Now;
            Status = AccountStatus.Actived;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public AccountStatus Status { get; set; }
        public Person Person { get; set; }
        public List<GradeStudent> GradeStudents { get; set; }
        public List<Mark> Marks { get; set; }
        public List<AccountRole> AccountRoles { get; set; }

        // Tu sinh muoi Salt
        public void GenerateSalt()
        {
            this.Salt = Guid.NewGuid().ToString();
        }

        // Ma Hoa chuoi chuyen vao
        public string EncrytString(string stringToEncrytString)
        {
            var hash = _algorithm.ComputeHash(Encoding.UTF8.GetBytes(stringToEncrytString));
            return Convert.ToBase64String(hash);
        }
        
        public void EncrytPassword()
        {
            this.Password += this.Salt;
            this.Password = EncrytString(this.Password);
        }

    }
    public enum AccountStatus {
        Actived = 1,
        Deactived = 0
    }
}
