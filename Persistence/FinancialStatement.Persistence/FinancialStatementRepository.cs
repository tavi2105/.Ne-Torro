using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialStatement.Persistence
{
    public class FinancialStatementRepository : IFinancialStatementRepository
    {
        private readonly FinancialStatementContext _context;
        public FinancialStatementRepository(FinancialStatementContext context)
        {
            _context = context;
        }
        public Task Create(FinancialStatement financialStatement)
        {
            _context.FinancialStatements.Add(financialStatement);
            return _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            var financialStatement = _context.FinancialStatements.FirstOrDefault(f => f.Id == id);
        
            _context.FinancialStatements.Remove(financialStatement);
            return _context.SaveChangesAsync();
        }

        public Task<FinancialStatement> GetById(int id)
        {
            var financialStatement = _context.FinancialStatements.FirstOrDefaultAsync(f => f.Id == id);
            return financialStatement;
        }

        public Task<List<FinancialStatement>> GetByUserId(int id)
        {
            return _context.FinancialStatements.Where(f => f.UserId == id).ToListAsync();
        }

        public Task Update(FinancialStatement financialStatement)
        {
            var entity = _context.FinancialStatements.FirstOrDefault(f => f.Id == financialStatement.Id);
            entity.Date = financialStatement.Date;
            entity.Expense = financialStatement.Expense;
            entity.Income = financialStatement.Income;
            return _context.SaveChangesAsync();

        }
    }
}
