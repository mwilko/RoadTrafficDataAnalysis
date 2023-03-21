using System;
using System.IO;
using System.Linq;

namespace RoadTrafficDataAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //create objects of Road Traffic Data Analysis class and runs the respective methods 
            RTDA256 rtda256 = new RTDA256();
            RTDA2048 rtda2048 = new RTDA2048(); 
            rtda256.DataAnalysis();
            rtda2048.DataAnalysis();
        }
    }
}