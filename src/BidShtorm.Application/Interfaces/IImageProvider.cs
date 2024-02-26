namespace BidShtorm.Application.Interfaces
{
    public interface IImageProvider
    {
        public string UploadImage(FileStream stream);
    }
}
