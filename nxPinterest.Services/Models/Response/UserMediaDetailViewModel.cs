﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nxPinterest.Data.Models;

namespace nxPinterest.Services.Models.Response
{
    public class UserMediaDetailViewModel
    {
        public UserMedia UserMediaDetail { get; set; }
        public IList<UserMedia> UserMediaList { get; set; }
    }
}