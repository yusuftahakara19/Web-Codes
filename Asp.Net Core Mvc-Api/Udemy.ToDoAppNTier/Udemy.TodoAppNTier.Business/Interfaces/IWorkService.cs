using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Common.ResponseObjects;
using Udemy.TodoAppNTier.Dtos.Interfaces;
using Udemy.TodoAppNTier.Dtos.WorkDtos;

namespace Udemy.TodoAppNTier.Business.Interfaces
{
    public interface IWorkService
    {
        Task<IResponse<List<WorkListDto>>> GetAll();
        Task<IResponse<WorkCreateDto>> Create(WorkCreateDto dto);
        Task<IResponse<IDto>> GetById<IDto>(int id);
        Task<IResponse> Remove(int id);
        Task<IResponse<WorkUpdateDto>> Update(WorkUpdateDto dto);
    }
}
