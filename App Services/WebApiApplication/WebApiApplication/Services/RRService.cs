using WebApiApplication.Repositories;
using WebApiApplication.Repositories.Abstractions;

namespace WebApiApplication.Services
{
    public class RRService
    {
        private readonly ISqlRepository _rrRepository;

        public RRService(ISqlRepository rrRepository)
        {
            _rrRepository = rrRepository;
        }

        public string GetAll()
        {
            return _rrRepository.GetAll();
        }
    }
}