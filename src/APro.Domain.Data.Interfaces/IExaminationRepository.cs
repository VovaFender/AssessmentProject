using System.Collections.Generic;
using APro.Domain.Models;

namespace APro.Domain.Data.Interfaces
{
    public interface IExaminationRepository
    {
        IEnumerable<Examination> GetExaminationList();
        Examination GetExamination(int examinationID);        
    }
}