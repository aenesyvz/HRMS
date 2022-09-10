using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Employer : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebSite { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsStatus { get; set; }
    }
}
