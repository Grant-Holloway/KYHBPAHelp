using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYHBPA_TeamA.Models
{
    public class Member //member table
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }   
        public Membership Membership { get; set; }
       
    }
}