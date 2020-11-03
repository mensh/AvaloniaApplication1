using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public class Person
        {
            public int DepartmentNumber { get; set; }

            public string DeskLocation { get; set; }

            public int EmployeeNumber { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }
        }
    }
}
