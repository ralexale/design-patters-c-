using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder.Robot
{
    //Director
    public class RobotDirector
    {
        private IRobotBuilder _robotBuilder;

        public RobotDirector(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        public void ConstructRobot()
        {
            _robotBuilder.BuildHead("Round");
            _robotBuilder.BuildBody("Metal");
            _robotBuilder.BuildArms("Claws");
            _robotBuilder.BuildLegs("Wheels");
        }

    }
}
