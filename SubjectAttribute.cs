using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class SubjectAttribute : Attribute
    {
        public string _subject { get; private set; }
        public SubjectAttribute(string subject)
        {
            _subject = subject;
        }
    }
}
