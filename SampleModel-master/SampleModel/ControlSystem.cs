using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleModel.Blocks;

namespace SampleModel
{
    public class ControlSystem
    {
        private double dt;
        private PIDBlock PID;
        private Tank Tank;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private LimitBlock levelLimit = new LimitBlock(0, 10);
        public double Time { get; set; } = 0;
        public bool ManualMode { get { return PID.ManualMode; } set { PID.ManualMode = value; } }
        //
        private double input1;
        private double input2;
        private double output1;
        private double output2;
        public double Input1 { get { return input1; } set { input1 = xLimit.Calc(value); } }
        public double Input2 { get { return input2; } set { input2 = xLimit.Calc(value); } }

        public double Output1 { get { return output1; } set { output1 = xLimit.Calc(value); } }

        public double Output2 { get { return output2; } set { output2 = xLimit.Calc(value); } }


        public double U { get { return PID.U; } set { PID.U = value; } }

        private double setPoint;
        public double SetPoint { get { return setPoint; } set { setPoint = levelLimit.Calc(value); } }

        public double K { get { return PID.K; } set { PID.K = value; } }
        public double Ti { get { return PID.Ti; } set { PID.Ti = value; } }
        public double Td { get { return PID.Td; } set { PID.Td = value; } }

        public double Output { get; set; }


        public ControlSystem(double dt) {
            this.dt = dt;
            PID = new PIDBlock(dt);
            Tank = new Tank(dt);
        }


        public void Calc()
        {
            Output = Tank.Calc(Input1, Input2, Output1, Output2);
            var e = SetPoint - Output;
            var u = PID.Calc(e);
            if (!ManualMode)
            {
                Input1 = u;
            }
            else
            {
                PID.Umanual = Input1;
            }
            Time += dt;
        }
    }
}
