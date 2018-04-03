using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Student
    {
        #region Properties
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        #endregion

        #region Navigation Objects
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        #endregion
    }
}