﻿using System.Threading.Tasks;
using AspNetCore.Yandex.ObjectStorage.Bucket;
using AspNetCore.Yandex.ObjectStorage.Models;
using AspNetCore.Yandex.ObjectStorage.Object;
using AspNetCore.Yandex.ObjectStorage.Object.Models;

namespace AspNetCore.Yandex.ObjectStorage
{
    public interface IYandexStorageService
    {
        IObjectService ObjectService { get; }

        // Not Implemented
        IBucketService BucketService { get; }

        // Not Implemented
        //IMultipartUploadService MultipartUploadService { get; }

        /// <summary>
        /// Test connection to storage
        /// </summary>
        /// <returns>Retruns true if all credentials correct</returns>
        Task<S3ObjectGetResponse> TryConnectAsync();
        /// <summary>
        /// Test connection to storage
        /// </summary>
        /// <returns>Retruns true if all credentials correct</returns>
        Task<S3ObjectGetResponse> TryGetAsync(string filename);
    }
}