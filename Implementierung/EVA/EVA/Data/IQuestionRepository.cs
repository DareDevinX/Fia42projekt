using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVA.DTO;

namespace EVA.Data
{
    public interface IQuestionRepository : IQuestionReader
    {
        void Create(Question question);

        void Delete(Question question);

        void Update(Question question);
    }
}
