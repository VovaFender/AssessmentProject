using System.Collections.Generic;
using APro.Domain.Data.Models;

namespace APro.Domain.Data.Interfaces
{
    public interface IExaminationRepository
    {
        IList<Examination> GetExaminationList();
        Examination GetExamination(int examinationID);
        
    }
}