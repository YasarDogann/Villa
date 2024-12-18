using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Villa_Entity.Entities
{
    public class Counter : BaseEntity
    {
        public string Title { get; set; }
        public string Count { get; set; }

    }
}
