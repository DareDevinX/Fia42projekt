using System.Collections.Generic;

namespace EVA.DTO
{
    public class Survey
    {
        public int Id { get; set; }
        public IEnumerable<Question> Questions { get; set; } 
    }
}
