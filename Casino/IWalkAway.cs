using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway // interface naming conventions start with uppercase "I" to indicate that it's an interface
    {
        void WalkAway(Player player); // interfaces are public by default
    }
}
