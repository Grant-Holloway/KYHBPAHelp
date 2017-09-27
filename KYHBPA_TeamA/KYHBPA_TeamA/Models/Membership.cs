using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYHBPA_TeamA.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StableName { get; set; }
        public int MemberType { get; set; }
        public int LicenseNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ESignature { get; set; }
    }

  
}