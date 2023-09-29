using System.ComponentModel.DataAnnotations;

namespace NZWalksAPI.Models.DTO
{
    public class UpdateRegionDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "code has to be 3 characters")]
        [MaxLength(3, ErrorMessage = "code has to be 3 characters")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "name has to be maximum 100 characters long")]
        public string Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}