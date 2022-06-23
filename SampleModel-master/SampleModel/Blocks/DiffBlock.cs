using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    public class DiffBlock : BaseBlock
    {
        private double dt;
        private double prev;
        public DiffBlock(double dt) {
           this.dt = dt;
        }
        public override double Calc(double x) {
            var y = (x - prev) / dt;
            prev = x;
            return y;
        }
    }
}
