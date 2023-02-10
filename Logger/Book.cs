using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Book(string Title, NameRecords Author) : AbstractEntity
    {
        public override string Name => Title + " - " + Author;
    }
}
