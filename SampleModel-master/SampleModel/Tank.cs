using SampleModel.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel
{
    public class Tank
    {
        private ComplexBlock Block;
        private GainBlock kxin1;
        private GainBlock kxin2;
        private GainBlock kxout1;
        //private GainBlock kxout2;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private double dt = 0.1;
        public Tank(double dt)
        {
            this.dt = dt;
            kxin1 = new GainBlock(1);
            kxin2 = new GainBlock(1);
            kxout1 = new GainBlock(-1);
            //kxout2 = new GainBlock(-1);

            Block = new ComplexBlock();
            Block.Add(new LimitedIntBlock(dt, 0, 10));
        }

        public double Calc(double xin1, double xin2, double xout1, double xout2)
        {
            xin1 = xLimit.Calc(xin1);
            xin2 = xLimit.Calc(xin2);
            xout1 = xLimit.Calc(xout1);


            var x = kxin1.Calc(xin1) + kxin2.Calc(xin2) + kxout1.Calc(xout1) - 1;

            return Block.Calc(x);
        }
    }
}
