using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Utility
    {
        public DateTime ConvertToDate(string empDateOfJoining)
        {
            return  DateTime.Parse(empDateOfJoining);
        }
    }
}
