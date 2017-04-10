using System.Windows.Media;

namespace OopProjectMvvm.Models {
	public class MyColor {
		public Color  Color { get; set; }
		public string Name  { get; set; }

		public MyColor(Color color, string name) {
			Color = color;
			Name  = name;
		}

		public override string ToString() {
			return Name;
		}
	}
}
