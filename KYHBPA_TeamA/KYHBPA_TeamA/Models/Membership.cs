using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYHBPA_TeamA.Models
{
    public class Membership
    {
        public int MembershipID { get; set; }
        public int MemberID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string StableName { get; set; }
        public bool IsOwner { get; set; }
        public bool IsTrainer { get; set; }
        public bool IsOwnerAndTrainer { get; set; }
        public string Affiliation { get; set; }
        public string ManagingPartner { get; set; }
        public bool AgreedToTerms { get; set; }
        public string Signature { get; set; }
    }
}