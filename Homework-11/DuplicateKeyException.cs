using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class DuplicateKeyException : Exception
    {
        public DuplicateKeyException(string? ex) : base(ex)
        { 
        }
    }
}
