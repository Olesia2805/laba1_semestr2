using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    public class PIDBlock : BaseBlock
    {
        private double ki = 0.000001;
        private double prevX = 0;
        private double dt;
        private double intSum = 0;

        public double UpLimit { get; set; } = 100;
        public double DownLimit { get; set; } = 0;

        public bool ManualMode { get; set; } = false;
        public double Umanual { get; set; }
        public double U { get; set; }

        public double K { get; set; } = 1;
        public double Ti { 
            get { return 1 / ki; } 
            set { if (value == 0) ki = double.MaxValue;
                  else ki = 1 / value; 
            }  
        }
        public double Ki { get { return ki; } set { ki = value; }  }
        public double Td { get; set; } = 0;

        public PIDBlock(double dt) {
            this.dt = dt;
        }

        public override double Calc(double x) {
            if (ManualMode) {
                intSum = (Umanual - K * x - Td * (x - prevX) / dt) / ki;
            }
            else {
                intSum += (prevX + x) * dt / 2;
            }
            var u = K * x + ki * intSum + Td * (x - prevX) / dt;
            var limited = false;
            if (u > UpLimit) {
                u = UpLimit;
                limited = true;
            }
            if (u < DownLimit) {
                u = DownLimit;
                limited = true;
            }
            if (ki != 0 && limited) {
                intSum = (u - K * x - Td * (x - prevX) / dt) / ki;
            }
            prevX = x;
            U = u;
            return U;
        }
    }
}
