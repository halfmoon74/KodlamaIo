using KodlamaIo.Business.Abstracts;
using KodlamaIo.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concrates
{
    public class InstructorManager : IInstructorService
    {
        public List<Instructor> GetInstructorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
