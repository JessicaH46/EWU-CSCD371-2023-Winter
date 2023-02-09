using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Student(NameRecords fullName, string Major) : Person(fullName)
    {
        public string Major { get; } = Major ?? throw new ArgumentNullException(nameof(Major));
    }
}
