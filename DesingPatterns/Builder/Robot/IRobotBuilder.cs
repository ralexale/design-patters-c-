using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder.Robot
{
    // Builder
    public interface IRobotBuilder
    {
        void BuildHead(string head);
        void BuildBody(string body);
        void BuildArms(string arms);
        void BuildLegs(string legs);
        Robot GetRobot();
    }
}
