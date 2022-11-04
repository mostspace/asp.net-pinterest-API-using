﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nxPinterest.Services.Models.Request
{
    public class CreateUserAlbumRequest
    {
        [Required]
        public string AlbumName { get; set; }

        public List<UserAlbumMediaRequest> UserAlbumMedias { get; set; }
    }

    public class UserAlbumMediaRequest
    {
        public int UserMediaId { get; set; }

        public string MediaUrl { get; set; }
    }
}