using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace trialBusiness
{
    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isComplete { get; set; }
    }
}
