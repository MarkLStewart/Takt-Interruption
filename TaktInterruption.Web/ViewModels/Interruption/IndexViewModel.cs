using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaktInterruption.Web.ViewModels.Interruption
{
    public class IndexViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public string AreaName { get; set; }
        public string CategoryName { get; set; }
    }
}
