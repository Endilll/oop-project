using System.ComponentModel;
using System.Windows.Media;
using static OopProjectMvvm.MyColorList;

namespace OopProjectMvvm.Models {
	public class Triangle : INotifyPropertyChanged {
		public Vertex[] Vertexes { get; set; }

		public double ZIndex => Vertexes[0].ZIndex +
		                        Vertexes[1].ZIndex +
		                        Vertexes[2].ZIndex;

	    private MyColor _color;
		public  MyColor  Color {
			get => _color;
		    set {
				_color = value;
				OnPropertyChanged("Color");
			}
		}

		public Triangle() {
			Vertexes = new Vertex[3];
            for (int i = 0; i < Vertexes.Length; i++)
                Vertexes[i] = new Vertex();
			Color = MyColors["White"];
		}

		public Triangle(Vertex vertex1, Vertex vertex2, Vertex vertex3, MyColor color) {
			Vertexes = new Vertex[3] { vertex1, vertex2, vertex3 };
			this.Color = color;
		}

		public static implicit operator PathGeometry(Triangle t) {
			PathFigure figure = new PathFigure();
			figure.StartPoint = t.Vertexes[0];
			figure.Segments.Add(new LineSegment(t.Vertexes[1], false));
			figure.Segments.Add(new LineSegment(t.Vertexes[2], false));
			return new PathGeometry(new[] { figure });
		}

		public Triangle MatrixMultiply(Matrix3 matrix) {
			Vertex vertex1 = matrix.Transform(Vertexes[0]);
			Vertex vertex2 = matrix.Transform(Vertexes[1]);
			Vertex vertex3 = matrix.Transform(Vertexes[2]);
			return new Triangle(vertex1, vertex2, vertex3, Color);
		}

		public override string ToString() {
			return this;
		}

		public static implicit operator string(Triangle triangle) {
			return triangle.Color.Name;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
