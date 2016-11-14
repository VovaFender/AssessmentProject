using System;
using System.Collections.Generic;
using System.Linq;
using APro.Domain.Data.Interfaces;
using APro.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data.Repositories
{
    public class ExaminationRepository : IExaminationRepository
    {
        private readonly AssessmentDataContext _dbContext;

        public ExaminationRepository(AssessmentDataContext dbContext)
        {
            _dbContext = dbContext;`
        }

        public Examination GetExamination(int examinationID)
        {
            return _dbContext.Examinations
                .FirstOrDefault(e => e.ID == examinationID);
        }

        public IEnumerable<Examination> GetExaminationList()
        {
            return _dbContext.Examinations;
        }
    }
}