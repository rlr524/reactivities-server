using System;

namespace Domain
{
    public class Activity
    {
        // EntityFramework will recognize this as the pk due to being named Id
        public Guid Id { get; set; }

        public String Title { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public String Category { get; set; }

        public String City { get; set; }

        public String Venue { get; set; }
        
    }
}
