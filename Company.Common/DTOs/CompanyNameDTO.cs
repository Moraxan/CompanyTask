

using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs
{
    public class CompanyNameDTO
    {
        public int Id { get; set; }
        [MaxLength(50), Required]

        public string? Company { get; set; }
    }
}
