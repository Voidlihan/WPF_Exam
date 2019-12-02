using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WPF_Exam
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();            
        }
    }
}
