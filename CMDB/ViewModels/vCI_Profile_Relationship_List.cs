﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMDB.ViewModels
{
    public class vCI_Profile_Relationship_List
    {
        [Key]
        public int ID { get; set; }

        public int ReviewCount { get; set; }

        public int Authority { get; set; }

        public IEnumerable<vCI_Profile_Relationship> ProfileRelationshipData { get; set; }
    }
}