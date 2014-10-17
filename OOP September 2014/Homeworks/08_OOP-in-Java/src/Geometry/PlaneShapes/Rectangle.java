package Geometry.PlaneShapes;

import Geometry.Vertex;

public class Rectangle extends PlaneShape {
	private double width;
	private double height;
	
	/**
	 * Enter Array of 1 vertex, width and height
	 * @param Array of 1 vertex
	 * @param width
	 * @param height
	 */
	public Rectangle(Vertex[] vertices, double width, double height) {
		super(vertices);
		this.setWidth(width);
		this.setHeight(height);
	}

	public double getWidth() {
		return width;
	}
	public void setWidth(double width) {
		if (width <= 0) {
			throw new IllegalArgumentException("Invalid width.");
		}
		this.width = width;
	}

	public double getHeight() {
		return height;
	}
	public void setHeight(double height) {
		if (height <= 0) {
			throw new IllegalArgumentException("Invalid height.");
		}
		this.height = height;
	}



	@Override
	public double getArea() {
		return this.getHeight() * this.getWidth();
	}

	@Override
	public double getPerimeter() {
		return this.getWidth() * 2 + this.getHeight() * 2;
	}

}
