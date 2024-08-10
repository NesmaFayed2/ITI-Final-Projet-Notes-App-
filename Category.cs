using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject_iti
{
    public partial class Category
    {
        public Category()
        {
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public string Category1 { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
