
namespace DevFreela.Infrastructure.CloudServices.Inferfaces
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}
