using GamzeNurKural_Week3_Homework.Domain.Entities;
using GamzeNurKural_Week3_Homework.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeNurKural_Week3_Homework.Services.Abstracts
{
    public interface IWorkerService
    {
        public IEnumerable<Worker> GetAll();
        public Worker GetById(int id);
        public void Add(WorkerDto workerDto);
        public int Update(Worker worker);
        public int Delete(Worker worker);
        public int HardDelete(Worker worker);
    }
}
