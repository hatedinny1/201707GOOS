using System;
using System.Data.Entity;
using GOOS_Sample.Models.DataModels;
using GOOS_Sample.Models.ViewModels;

namespace GOOS_Sample.Services
{
    public class budgetService : IBudgetService
    {
        public void Create(BudgetAddViewModel model)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var budget = new Budget() { Amount = model.Amount, YearMonth = model.Month };
                dbContext.Budgets.Add(budget);
                dbContext.SaveChanges();
            }
        }
    }
}