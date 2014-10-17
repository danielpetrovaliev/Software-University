package Geometry.PlaneShapes;
import Geometry.Shape;
import Geometry.Vertex;
import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.PerimeterMeasurable;

public abstract class PlaneShape extends Shape implements AreaMeasurable, PerimeterMeasurable{

	protected PlaneShape(Vertex[] vertices) {
		super(vertices);
	}
	
}
