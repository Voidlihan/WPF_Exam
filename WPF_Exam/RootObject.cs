using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Exam
{
    public class RootObject
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }
}
