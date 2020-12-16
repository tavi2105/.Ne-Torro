using AutoMapper;
using FinancialStatement.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialStatement.Business
{
    public class FinancialStatementBusinessLogic : IFinancialStatementBusinessLogic
    {
        private readonly IFinancialStatementRepository _repository;
        private readonly IMapper _mapper;

        public FinancialStatementBusinessLogic(IFinancialStatementRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public Task Create(FinancialStatementDto financialStatement)
        {
            var entity = _mapper.Map<Persistence.FinancialStatement>(financialStatement);
            return _repository.Create(entity);
        }

        public Task Delete(int id)
        {
            
            return _repository.Delete(id);
        }

        public async Task<FinancialStatementDto> GetById(int id)
        {
           var entity = await _repository.GetById(id);
            
            if (entity != null)
            {
                return _mapper.Map<FinancialStatementDto>(entity);
            }

            return null;
        }

        public async Task<List<FinancialStatementDto>> GetByUserId(int id)
        {
            var entityList= await _repository.GetByUserId(id);

            if (entityList.Count > 0)
            {
                return _mapper.Map<List<FinancialStatementDto>>(entityList);
            }

            return null;
        }

        public Task Update(FinancialStatementDto financialStatement)
        {
          var entity =  _mapper.Map<Persistence.FinancialStatement>(financialStatement);
            return _repository.Update(entity);
        }
    }
}
