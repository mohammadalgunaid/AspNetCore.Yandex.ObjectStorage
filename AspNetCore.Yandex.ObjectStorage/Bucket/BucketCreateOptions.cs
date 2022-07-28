using AspNetCore.Yandex.ObjectStorage.Enums;

namespace AspNetCore.Yandex.ObjectStorage.Bucket
{
    public class BucketCreateOptions
    {
        public string BucketName { get; set; }

        public ACLType ACLType { get; set; }
    }
}