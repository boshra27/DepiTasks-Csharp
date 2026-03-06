using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    internal class Book
    {
        #region Q1:
        // Because EF Core follows a naming convention to identify a unique identity of a row. If a property is named exactly Id or
        // ClassId it is automatically designated as a primary key
        #endregion
        #region Q2:
        // Because Country had ? added to it telling the compiler and EF that it nullable while Price did not
        #endregion
        public int Id { get; set; }
        public string Title { get; set; }

        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
