using GOOS_Sample.Models.ViewModels;

namespace GOOS_Sample.Services
{
    public interface IBudgetService
    {
        void Create(BudgetAddViewModel budget);
    }
}