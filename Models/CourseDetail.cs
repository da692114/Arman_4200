using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arman_4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        public string description { get; set; }
        public DateTime courseDate { get; set; }
        // the next two properties link the orderDetail to the Order
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
    }
}