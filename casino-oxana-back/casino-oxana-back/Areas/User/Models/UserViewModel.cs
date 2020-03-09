using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace casino_oxana_back.Areas.User.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

    }
}