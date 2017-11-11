using System;
using System.Collections.Generic;

namespace WebApplication3
{
    public partial class Staffs
    {
        public Staffs()
        {
            Policys = new HashSet<Policys>();
        }

        public int Id { get; set; }
        public string StaffName { get; set; }
        public string StaffPost { get; set; }
        public string StaffExperience { get; set; }

        public ICollection<Policys> Policys { get; set; }
    }
}

