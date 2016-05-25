using System;

namespace EVA.DTO
{
    public class AppointedSurvey
    {
        public Survey Survey { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInDays { get; set; }
        public Class Class { get; set; }
    }
}
