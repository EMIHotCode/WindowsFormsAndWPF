using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_JurnalBoilerRoom.Model
{
    public class LogVariables
    {
        public string Time { get; set; } // время ?? постоянное не включать в 
        public string Temperature { get; set; } // температура
        //public string PhoneNumber { get; set; }
        public LogVariables(string time, string temperature)
        {
            Time = time;
            Temperature = temperature;
        }
    }
}
