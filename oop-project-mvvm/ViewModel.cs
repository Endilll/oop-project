using OopProjectMvvm.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using static OopProjectMvvm.MyColorList;

namespace OopProjectMvvm {
	public class ViewModel : INotifyPropertyChanged {
		private int _selectedTriangle;
		public  int  SelectedTriangle {
			get => _selectedTriangle;
		    set {
				_selectedTriangle = value;
				OnPropertyChanged("SelectedTriangle");
			}
		}
		public List<MyColor> myColors { get; } = new List<MyColor>(MyColors.Values);

	    private ObservableCollection<Triangle> _geometry;
		public  ObservableCollection<Triangle>  Geometry {
			get => _geometry;
		    set {
				_geometry = value;
				OnPropertyChanged("Geometry");
			}
		}

		public ICommand AddTriangleCommand    { get; set; }
		public ICommand DeleteTriangleCommand { get; set; }	

		public ViewModel() {
			AddTriangleCommand    = new RelayCommand(arg => AddTriangle());
			DeleteTriangleCommand = new RelayCommand(arg => DeleteTriangle());
			Geometry = new ObservableCollection<Triangle>{new Triangle(new Vertex( 100,  100,  100),
																	   new Vertex(-100, -100,  100),
																	   new Vertex(-100,  100, -100),
																	   MyColors["Yellow"]),
														  new Triangle(new Vertex( 100,  100,  100),
																	   new Vertex(-100, -100,  100),
																	   new Vertex( 100, -100, -100),
																	   MyColors["Red"]),
														  new Triangle(new Vertex(-100,  100, -100),
																	   new Vertex( 100, -100, -100),
																	   new Vertex( 100,  100,  100),
																	   MyColors["Green"]),
														  new Triangle(new Vertex(-100,  100, -100),
																	   new Vertex( 100, -100, -100),
																	   new Vertex(-100, -100,  100),
																	   MyColors["Blue"]) };
		}

		private void AddTriangle() {
			Triangle triangle = new Triangle();
			Geometry.Add(triangle);
		}

		private void DeleteTriangle() {
			Geometry.RemoveAt(SelectedTriangle);	
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}