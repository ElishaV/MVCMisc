using System.ComponentModel.DataAnnotations;

namespace MVCMiscellaneous.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } //navigation property
        public byte MembershipTypeId { get; set; } //foreign key
    }
}