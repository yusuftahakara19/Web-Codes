using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Business.Interfaces;
using Udemy.TodoAppNTier.DataAccess.Domains;
using Udemy.TodoAppNTier.DataAccess.UnitofWork;
using Udemy.TodoAppNTier.Dtos.WorkDtos;

namespace Udemy.TodoAppNTier.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUow _uow;

        public WorkService(IUow uow)
        {
            _uow = uow;
        }

        public async Task Create(WorkCreateDto dto)
        {
           await _uow.GetRepository<Work>().Create(new() { Definition = dto.Definition, IsCompleted = dto.IsCompleted });
            await _uow.SaveChanges();
        }

        public async Task<List<WorkListDto>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();
            var workList = new List<WorkListDto>(); ;

            if(list.Count > 0)
            {
                foreach(var item in list)
                {
                    workList.Add(new WorkListDto
                    {
                        Id = item.Id,
                        Definition = item.Definition,
                        IsCompleted = item.IsCompleted
                    });
                }
            }

            return workList;
        }

        public async Task<WorkListDto> GetById(int id)
        {
            var work = await _uow.GetRepository<Work>().GetByFilter(x => x.Id == id);
            return new() {
                Definition = work.Definition,
                IsCompleted = work.IsCompleted
            };
        }

        public async Task Remove(object id)
        {
            var deletedItem = await _uow.GetRepository<Work>().GetById(id);
            _uow.GetRepository<Work>().Remove(deletedItem);
            await _uow.SaveChanges();
        }

        public async Task Update(WorkUpdateDto dto)
        {
            _uow.GetRepository<Work>().Update(new()
            {
                Definition = dto.Definition,
                Id = dto.Id,
                IsCompleted = dto.IsCompleted
            });
            await _uow.SaveChanges();
        }
    
    } 
}
