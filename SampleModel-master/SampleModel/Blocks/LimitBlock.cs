using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    public class LimitBlock : BaseBlock
    {
        private double min;
        private double max;
        public LimitBlock(double min, double max) {
            this.min = min;
            this.max = max;
        }
        public override double Calc(double x) {
            x = (x > max) ? max : x;
            x = (x < min) ? min : x;
            return x;
        }
    }
}
