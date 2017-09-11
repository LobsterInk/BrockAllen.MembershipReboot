using System;

namespace BrockAllen.MembershipReboot
{
    public interface IDateCreatedUpdated
    {
        DateTimeOffset? Created { get; set; }
        DateTimeOffset? LastUpdated { get; set; }
    }
}
