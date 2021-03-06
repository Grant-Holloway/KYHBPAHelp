﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYHBPA_TeamA.Models
{
    public class AddBoardofDirectorsViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public HttpPostedFileBase File { get; set; } = null;
    }
    public class DisplayBoardOfDirectorsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public byte[] PhotoContent { get; set; }
    }
}