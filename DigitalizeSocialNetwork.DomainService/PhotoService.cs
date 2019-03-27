using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalizeSocialNetwork.DomainModel.Entities;
using DigitalizeSocialNetwork.DomainModel.Interfaces.Repositories;

namespace DigitalizeSocialNetwork.DomainService
{
    public class PhotoService
    {
        private IPhotoRepository _photoRepository;

        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public string UploadPhoto(Photo photo)
        {
            return _photoRepository.Create(photo);
        }

        public async Task<string> UploadPhotoAsync(Photo photo)
        {
            return await _photoRepository.CreateAsync(photo);
        }
    }
}
