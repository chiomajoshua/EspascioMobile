using System;
using System.Collections.Generic;

namespace EspascioMobile.Models
{
    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Features> Features { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string ItemImage { get; set; }
        public string StatusImage { get; set; }
    }
}