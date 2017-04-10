namespace oop_project_mvvm.Models {
	public class Matrix3 {
		public double[] values;
		public Matrix3(double[] values) {
			this.values = values;
		}

		public Matrix3 multiply(Matrix3 other) {
			double[] result = new double[9];
			for (int row = 0; row < 3; row++) {
				for (int col = 0; col < 3; col++) {
					for (int i = 0; i < 3; i++) {
						result[row * 3 + col] += this.values[row * 3 + i] * other.values[i * 3 + col];
					}
				}
			}
			return new Matrix3(result);
		}

		public Vertex transform(Vertex v) {
			return new Vertex(v.X * values[0] + v.Y * values[3] + v.Z * values[6],
							  v.X * values[1] + v.Y * values[4] + v.Z * values[7],
							  v.X * values[2] + v.Y * values[5] + v.Z * values[8]);
		}
	}
}
