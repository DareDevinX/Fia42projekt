using System.Collections.Generic;

namespace EVA.DTO
{
    public class Teacher : User
    {
        IEnumerable<Class> Classes { get; set; }
    }
}
