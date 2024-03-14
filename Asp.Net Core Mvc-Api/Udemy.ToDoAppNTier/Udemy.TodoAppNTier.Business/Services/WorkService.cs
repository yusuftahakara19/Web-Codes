using AutoMapper;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Business.Interfaces;
using Udemy.TodoAppNTier.Business.ValidationRules;
using Udemy.TodoAppNTier.DataAccess.Domains;
using Udemy.TodoAppNTier.DataAccess.UnitofWork;
using Udemy.TodoAppNTier.Dtos.Interfaces;
using Udemy.TodoAppNTier.Dtos.WorkDtos;

namespace Udemy.TodoAppNTier.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IValidator<WorkCreateDto> _createDtoValidator;
        private readonly IValidator<WorkUpdateDto> _updateDtoValidator;
        public WorkService(IUow uow, IMapper mapper, IValidator<WorkCreateDto> createDtoValidator, IValidator<WorkUpdateDto> updateDtoValidator)
        {
            _uow = uow;
            _mapper = mapper;
            _updateDtoValidator = updateDtoValidator;
            _createDtoValidator = createDtoValidator;
        }

        public async Task Create(WorkCreateDto dto)
        {
            var validationResult = _createDtoValidator.Validate(dto);
            if(validationResult.IsValid)
            {
                await _uow.GetRepository<Work>().Create(_mapper.Map<Work>(dto));
                await _uow.SaveChanges();
            }
        }

        public async Task<List<WorkListDto>> GetAll()
        {
            return _mapper.Map<List<WorkListDto>>(await _uow.GetRepository<Work>().GetAll());
         }

        public async Task<IDto> GetById<IDto>(int id)
        {
            return _mapper.Map<IDto>(await _uow.GetRepository<Work>().GetByFilter(x => x.Id == id));
        }

        public async Task Remove(int id)
        {   var removedEntity = await _uow.GetRepository<Work>().GetByFilter(x=>x.Id == id);
            if(removedEntity != null)
            {
                _uow.GetRepository<Work>().Remove(removedEntity);
                 await _uow.SaveChanges();
            }
        }

        public async Task Update(WorkUpdateDto dto)
        {   var validationResult = _updateDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var updatedEntity = await _uow.GetRepository<Work>().Find(dto.Id);
                if(updatedEntity != null)
                {
                    _uow.GetRepository<Work>().Update(_mapper.Map<Work>(dto),updatedEntity);
                     await _uow.SaveChanges();
                }
            }
        } 
    } 
}
