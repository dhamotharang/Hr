﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.Models.Time_management
{
    public class Exit_Permission_Reason:BaseModel
    {

        public virtual List<Exit_permission_request> Exit_permission_request { get; set; }
    }
}