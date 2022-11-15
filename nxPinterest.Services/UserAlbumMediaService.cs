﻿using System.Collections.Generic;
using System.Threading.Tasks;
using nxPinterest.Data.Repositories.Interfaces;
using nxPinterest.Data.ViewModels;
using nxPinterest.Services.Interfaces;

namespace nxPinterest.Services;

public class UserAlbumMediaService : IUserAlbumMediaService
{
    private readonly IUserAlbumMediaRepository _userAlbumMediaRepository;

    public UserAlbumMediaService(IUserAlbumMediaRepository userAlbumMediaRepository)
    {
        _userAlbumMediaRepository = userAlbumMediaRepository;

    }

    public async Task<IEnumerable<SharedLinkAlbumMediaViewModel>> GetListAlbumById(int albumId, int pageIndex)
    {
        return await _userAlbumMediaRepository.GetListAlbumByIdAsync(albumId ,pageIndex, dev_Settings.displayMaxItems_search);
    }
}