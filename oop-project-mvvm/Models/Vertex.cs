using System.Windows;

namespace OopProjectMvvm.Models {
	public class Vertex {
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }
		public double ZIndex => Z;

	    public Vertex() {
			X = 0;
			Y = 0;
			Z = 0;
		}

		public Vertex(double x, double y, double z) {
			X = x;
			Y = y;
			Z = z;
		}

		public static implicit operator Point(Vertex v) {
			return new Point(v.X, v.Y);
		}
	}
}