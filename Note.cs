using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject_iti
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Note1 { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public int Catgid { get; set; }

        public virtual Category Catg { get; set; }
    }
}
