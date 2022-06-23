using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
	public class APBlock : BaseBlock
	{
		private double dt;
		private double T;
		private double prev;
		public APBlock(double dt, double T) {
			this.dt = dt;
			this.T = T;
		}
		public override double Calc(double x) {
			var y = (dt * x + T * prev) / (T + dt);
			prev = y;
			return y;
		}
	}
}
