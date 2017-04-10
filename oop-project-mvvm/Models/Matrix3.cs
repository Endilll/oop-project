namespace OopProjectMvvm.Models {
	public class Matrix3 {
		public double[] Values;
		public Matrix3(double[] values) {
			this.Values = values;
		}

		public Matrix3 Multiply(Matrix3 other) {
			var result = new double[9];
			for (var row = 0; row < 3; row++)
				for (var col = 0; col < 3; col++)
					for (var i = 0; i < 3; i++)
						result[row * 3 + col] += Values[row * 3 + i] * other.Values[i * 3 + col];
			return new Matrix3(result);
		}

		public Vertex Transform(Vertex v) {
			return new Vertex(v.X * Values[0] + v.Y * Values[3] + v.Z * Values[6],
							  v.X * Values[1] + v.Y * Values[4] + v.Z * Values[7],
							  v.X * Values[2] + v.Y * Values[5] + v.Z * Values[8] );
		}
	}
}
