using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreData.Model
{
    public class Menu
    {
        [Required]
        public Guid MenuId { get; set; }

        public string MenuName { get; set; }

        public string MenuCode { get; set; }

        public Guid? ParentId { get; set; }

        public Guid? RootId { get; set; }

    }
}
