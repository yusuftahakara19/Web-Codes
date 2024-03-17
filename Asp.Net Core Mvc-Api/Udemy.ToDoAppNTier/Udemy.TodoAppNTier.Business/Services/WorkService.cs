using AutoMapper;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Business.Interfaces;
using Udemy.TodoAppNTier.Business.ValidationRules;
using Udemy.TodoAppNTier.Common.ResponseObjects;
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

        public async Task<IResponse<WorkCreateDto>> Create(WorkCreateDto dto)
        {
            var validationResult = _createDtoValidator.Validate(dto);
            if(validationResult.IsValid)
            {
                await _uow.GetRepository<Work>().Create(_mapper.Map<Work>(dto));
                await _uow.SaveChanges();
                return new Response<WorkCreateDto>(ResponseType.Success, dto);
            }
            else
            {
                List<CustomValidationError> errors = new();
                foreach(var error in validationResult.Errors)
                {
                    errors.Add(new() { ErrorMessage = error.ErrorMessage, PropertyName = error.PropertyName });
                }
                return new Response<WorkCreateDto>(ResponseType.ValidationError, dto, errors);
            }
        }

        public async Task<IResponse<List<WorkListDto>>> GetAll()
        {
            var data = _mapper.Map<List<WorkListDto>>(await _uow.GetRepository<Work>().GetAll());
            return new Response<List<WorkListDto>>(ResponseType.Success, data);
         }

        public async Task<IResponse<IDto>> GetById<IDto>(int id)
        {   
            var data = _mapper.Map<IDto>(await _uow.GetRepository<Work>().GetByFilter(x => x.Id == id));
            if(data == null)
            {
                return new Response<IDto>(ResponseType.NotFound, $"No data for : {id}");
            }
            return new Response<IDto>(ResponseType.Success, data);
        }

        public async Task<IResponse> Remove(int id)
        {   var removedEntity = await _uow.GetRepository<Work>().GetByFilter(x=>x.Id == id);
            if(removedEntity != null)
            {
                _uow.GetRepository<Work>().Remove(removedEntity);
                 await _uow.SaveChanges();
                return new Response(ResponseType.Success);
            }
            return new Response(ResponseType.NotFound, $"No data for : {id}");
        }

        public async Task<IResponse<WorkUpdateDto>> Update(WorkUpdateDto dto)
        {   var validationResult = _updateDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var updatedEntity = await _uow.GetRepository<Work>().Find(dto.Id);
                if(updatedEntity != null)
                {
                    _uow.GetRepository<Work>().Update(_mapper.Map<Work>(dto),updatedEntity);
                     await _uow.SaveChanges();
                    return new Response<WorkUpdateDto>(ResponseType.Success,dto);
                }
                return new Response<WorkUpdateDto>(ResponseType.NotFound, $"There is no data for : {dto.Id}");
            }
            else
            {
                List<CustomValidationError> errors = new();
                foreach (var error in validationResult.Errors)
                {
                    errors.Add(new() { ErrorMessage = error.ErrorMessage, PropertyName = error.PropertyName });
                }
                return new Response<WorkUpdateDto>(ResponseType.ValidationError, dto, errors);
            }
        } 
    } 
}
