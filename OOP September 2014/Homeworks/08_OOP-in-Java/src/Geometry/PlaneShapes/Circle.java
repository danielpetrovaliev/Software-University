package Geometry.PlaneShapes;

import Geometry.Vertex;

public class Circle extends PlaneShape{
	private double radius;
	
	/**
	 * Enter Array of 1 Vertex and radius
	 * @param Array of 1 Vertex
	 * @param radius
	 */
	public Circle(Vertex[] vertices, double radius) {
		super(vertices);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}
	public void setRadius(double radius) {
		if (radius <= 0) {
			throw new IllegalArgumentException("Invalid radius");
		}
		this.radius = radius;
	}


	@Override
	public double getArea() {
		double area = Math.PI * Math.pow(this.getRadius(), 2);
		return area;
	}

	@Override
	public double getPerimeter() {
		double perimeter = 2 * Math.PI * this.getRadius();
		return perimeter;
	}

}
