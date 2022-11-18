﻿using System.Collections.Generic;
using nxPinterest.Data.Models;
using System.Threading.Tasks;
using nxPinterest.Data.ViewModels;
using System;

namespace nxPinterest.Data.Repositories.Interfaces
{
    public interface IUserAlbumRepository : IBaseRepository<UserAlbum>
    {
        (int albumId, string albumName) IsUserAlbumAlreadyExists(string albumName);

        bool CheckExpiryDayAlbum(int albumId, DateTime? albumExpireDate);

        Task<IEnumerable<UserAlbumViewModel>> GetAlbumUserByContainer(string userId);

        Task<int> GetAlbumIdByPathUrl(string pathUrl);

        Task<int> GetAlbumIdByName(string albumName);

        Task<DateTime?> GetCreateDateAlbumName(int albumId);

        Task<bool> IsAlbumNameExist(string albumName);
    }
}
