using System.Collections.Generic;

namespace WebApplication.Services.Abstractions
{
    public interface IBlobService
    {
        void Upload();
        IEnumerable<string> Get();
        void Download();
        string DownloadAsStream();
        void Delete();
    }
}