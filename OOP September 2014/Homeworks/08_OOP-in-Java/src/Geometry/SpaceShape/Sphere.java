package Geometry.SpaceShape;

import Geometry.Vertex;

public class Sphere extends SpaceShape {
	private double radius;
	
	/**
	 * Enter Array of 1 Vertex and radius
	 * @param Array of 1 Vertex
	 * @param radius
	 */
	public Sphere(Vertex[] vertices, double radius) {
		super(vertices);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}
	public void setRadius(double radius) {
		if (radius <= 0) {
			throw new IllegalArgumentException("Radius is invalid");
		}
		this.radius = radius;
	}

	@Override
	public double getArea() {
		double area = 4 * Math.PI * Math.pow( this.getRadius() , 2);
		return area;
	}

	@Override
	public double getVolume() {
		double volume = ( 4 / 3 ) * Math.PI * Math.pow( this.getRadius() , 3);
		return volume;
	}

}
