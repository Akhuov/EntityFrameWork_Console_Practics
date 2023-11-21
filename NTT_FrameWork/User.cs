using NTT_FrameWork.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_FrameWork
{
    internal class User
    {
        [Key]//Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Auto increment
        public int userId { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; } = Gender.Male;
    }
}
