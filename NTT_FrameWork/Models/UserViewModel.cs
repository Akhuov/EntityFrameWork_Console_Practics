using NTT_FrameWork.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_FrameWork.Models
{
    internal class UserViewModel
    {
        public int? userId { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }
    }
}
