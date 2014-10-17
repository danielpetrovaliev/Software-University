package Geometry.SpaceShape;

import Geometry.Shape;
import Geometry.Vertex;
import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.VolumeMeasurable;

public abstract class SpaceShape extends  Shape implements AreaMeasurable, VolumeMeasurable{
	
	protected SpaceShape(Vertex[] vertices) {
		super(vertices);
		
	}

}
