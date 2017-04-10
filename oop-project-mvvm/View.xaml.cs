using OopProjectMvvm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using static System.Math;

namespace OopProjectMvvm {
	public partial class View : Window, INotifyPropertyChanged {
		private double _angleXzInRadians;
		private double _angleYzInRadians;

		public double AngleXz {
			get => _angleXzInRadians;
		    set {
				_angleXzInRadians = Math.PI / 180 * value;
				OnPropertyChanged("AngleXZ");
			}
		}
		public double AngleYz {
			get => _angleYzInRadians;
		    set {
				_angleYzInRadians = Math.PI / 180 * value;
				OnPropertyChanged("AngleYZ");
			}
		}

		public View() {
			InitializeComponent();
		}

		private void Draw() {
			ViewModel viewModel = (ViewModel)Window.DataContext;
			Canvas.Children.Clear();
			Matrix3 transformMatrix = CalculateTransformMatrix();
			SortedDictionary<double, List<int>> zBuffer = new SortedDictionary<double, List<int>>();
			foreach (var triangle in viewModel.Geometry) {
				var transformedTriangle = triangle.MatrixMultiply(transformMatrix);
			    var path = new Path {Data = transformedTriangle};
			    path.Data.Transform = new TranslateTransform(250, 152);
				path.Fill = new SolidColorBrush(triangle.Color.Color);
				Canvas.Children.Add(path);
				if (zBuffer.ContainsKey(transformedTriangle.ZIndex))
					zBuffer[transformedTriangle.ZIndex].Add(Canvas.Children.Count - 1);
				else
					zBuffer.Add(transformedTriangle.ZIndex, new List<int> { Canvas.Children.Count - 1 });
			}
			int i = int.MaxValue / 2;
			foreach (var entry in zBuffer)
				foreach (var path in entry.Value)
					Canvas.SetZIndex(Canvas.Children[path], i--);
		}

		private Matrix3 CalculateTransformMatrix() {
			Matrix3 transformMatrixXz = new Matrix3(new[] {Cos(AngleXz), 0, -Sin(AngleXz),
														   0,            1,  0,
														   Sin(AngleXz), 0,  Cos(AngleXz)});
			Matrix3 transformMatrixYz = new Matrix3(new[] {1,  0,            0,
													       0,  Cos(AngleYz), Sin(AngleYz),
														   0, -Sin(AngleYz), Cos(AngleYz)});
			return transformMatrixXz.Multiply(transformMatrixYz);
		}

		//ComboboxColorPick
		private void Draw(object sender, SelectionChangedEventArgs e) {
			Draw();
		}

		//ScrollBars
		private void Draw(object sender, RoutedPropertyChangedEventArgs<double> e) {
			Draw();
		}

		//Buttons
		private void Draw(object sender, RoutedEventArgs e) {
			Draw();
		}

		//DataGrid
		private void Draw(object sender, DataGridCellEditEndingEventArgs e) {
			Draw();
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
