using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibeBot.Subsystems.Reporting.PowerDistribution
{
    public class PowerChannel
    {
        private int Port;
        private string Name;

        public PowerChannel(int port, string name)
        {
            Port = port;
            Name = name;
        }

        public string Name
        {
            get { return Name; }
        }
    }
}
