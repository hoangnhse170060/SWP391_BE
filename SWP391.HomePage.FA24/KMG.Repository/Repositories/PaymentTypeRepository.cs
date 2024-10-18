
using AutoMapper;
using DriverLicenseLearningSupport.Repositories.Impl;
using KMG.Repository.Models;
using KMG.Repository.Models.Pay;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;

namespace DriverLicenseLearningSupport.Repositories
{
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        private readonly IMapper _mapper;
        private readonly SwpkoiFarmShopContext _context;

        public PaymentTypeRepository(SwpkoiFarmShopContext context,
            IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<IEnumerable<PaymentTypeModel>> GetAllAsync()
        {
            var Orders = await _context.Orders.ToListAsync();
            return _mapper.Map<IEnumerable<PaymentTypeModel>>(Orders);
        }

        public async Task<PaymentTypeModel> GetAsync(int id)
        {
            var Orders = await _context.Orders.Where(x => x.OrderId == id)
                                                    .FirstOrDefaultAsync();
            return _mapper.Map<PaymentTypeModel>(Orders);
        }

        Task<IEnumerable<PaymentTypeModel>> IPaymentTypeRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<PaymentTypeModel> IPaymentTypeRepository.GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
