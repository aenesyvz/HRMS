using Core.Entities;

namespace Entities.Dtos
{
    public class EmployerDto : IDto
    {
        public int Id { get; set; }
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public string EmployerMail { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebSite { get; set; }
        public string PhoneNumber { get; set; }
    }
}
