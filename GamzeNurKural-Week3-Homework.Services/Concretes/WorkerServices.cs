using GamzeNurKural_Week3_Homework.Data.Abstracts;
using GamzeNurKural_Week3_Homework.Domain.Entities;
using GamzeNurKural_Week3_Homework.Services.Abstracts;
using GamzeNurKural_Week3_Homework.Services.DTOs;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeNurKural_Week3_Homework.Services.Concretes
{
    public class WorkerServices : IWorkerService
    {
        private readonly IRepository<Worker> _workerRepository;

        public WorkerServices(IRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public void Add(WorkerDto workerDto)
        {
            var worker = new Worker
            {
                FirstName = workerDto.FirstName,
                LastName = workerDto.LastName,
                Gender = workerDto.Gender,
                BirthDate = workerDto.BirthDate,
                Department = workerDto.Department,
                Mail = workerDto.Mail,
                Phone = workerDto.Phone,
                CreatedBy = "Gamze",
                CreatedDate = DateTime.Now,
                Status = true
            };
            _workerRepository.Add(worker);
        }

        public IEnumerable<Worker> GetAll()
        {
            return _workerRepository.GetAll().ToList();
        }

        public Worker GetById(int id)
        {
            return _workerRepository.GetById(id);
        }

        public int Update(Worker worker)
        {
            return _workerRepository.Update(worker);
        }

        public int Delete(Worker worker)
        {
           return _workerRepository.Delete(worker);
        }

        public int HardDelete(Worker worker)
        {
            return _workerRepository.HardDelete(worker);
        }
    }
}
