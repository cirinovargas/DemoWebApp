using DemoApp.Core.Interfaces;
using DemoApp.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApp.Core.Services
{
    public class AppEmailService : IAppEmailService
    {
        private readonly IRepository<AppEmail> _appEmailRepository;
        private readonly IAppLogger<AppEmailService> _logger;

        public AppEmailService(IRepository<AppEmail> appEmailRepository,
           IAppLogger<AppEmailService> logger)
        {
            _appEmailRepository = appEmailRepository;
            _logger = logger;
        }

        //public async Task<IEnumerable<AppEmail>> GetEmailList ()
        //{
        //    var listEmail = await _appEmailRepository.GetAll();

        //    return listEmail;
        //}

        public IEnumerable<AppEmail> GetEmailList()
        {
            var listEmail = _appEmailRepository.GetAll();

            return listEmail;
        }
    }
}