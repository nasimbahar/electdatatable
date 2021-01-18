using Elect.Web.DataTable.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatable.Models
{
    public class UserModel
    {
        [DataTable(IsVisible = false, DisplayName = "Id")]

        public int Id { get; set; }

        [DataTable(DisplayName = "Name")]
        public string FullName { get; set; }

        [DataTable(DisplayName = "Created At")]
        public DateTimeOffset CreatedTime { get; set; }

        [DataTable(DisplayName = "Actived")]
        public bool IsActive { get; set; }
    }
}
