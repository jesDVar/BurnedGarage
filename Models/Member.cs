using Microsoft.AspNetCore.Identity;

namespace BurnedGarage.Models
{
    public class Member : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int? Age { get; set; }
        public string? Avatar { get; set; }
        public string? PersonNr { get; set; }

        //vehicle, [0,I)
        // Nav prop

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
