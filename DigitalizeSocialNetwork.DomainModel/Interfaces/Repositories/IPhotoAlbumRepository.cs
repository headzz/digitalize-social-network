﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalizeSocialNetwork.DomainModel.Entities;

namespace DigitalizeSocialNetwork.DomainModel.Interfaces.Repositories
{
    public interface IPhotoAlbumRepository
    {
        void Create(PhotoAlbum photoAlbum);
        PhotoAlbum Read(Guid photoAlbumId);
        IEnumerable<PhotoAlbum> ReadAll();
        void Update(PhotoAlbum photoAlbum);
        void Delete(Guid photoAlbumId);
    }
}