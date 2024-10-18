
using KMG.Repository.Models.Pay;
using KMG.Repository.Repositories;

namespace DriverLicenseLearningSupport.Repositories.Impl
{
    public interface IPaymentTypeRepository
    {
        Task<PaymentTypeModel> GetAsync(int id);
        Task<IEnumerable<PaymentTypeModel>> GetAllAsync();
    }
}
