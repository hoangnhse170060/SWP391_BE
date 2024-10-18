


using KMG.Repository.Models.Pay;

namespace KMG.Repository.Services;

public interface IPaymentTypeService
{
    Task<PaymentTypeModel> GetAsync(int id);
    Task<IEnumerable<PaymentTypeModel>> GetAllAsync();
}
