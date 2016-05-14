﻿using System.Collections.Generic;

namespace ASDF.ENETCare.InterventionManagement.Business
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public District District { get; set; }

        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
