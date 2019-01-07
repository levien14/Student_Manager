using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class MyCredential
    {
        public MyCredential()
        {

        }
        public MyCredential(int id)
        {
            this.AccessToken = Guid.NewGuid().ToString();
            this.OwnId = id;
            this.ExpiredAt = DateTime.Now.AddDays(7);
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.DeletedAt = DateTime.Now;
        }
        [Key]
        public string AccessToken { get; set; }
        public int OwnId { get; set; }
        public DateTime CreatedAt{ get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public MyCredentialStatus Status { get; set; }

        public bool checkToken()
        {
            return DateTime.Now < ExpiredAt;
        }
    }
    public enum MyCredentialStatus {
        Actived = 1,
        Deactive = 0
    }
}
