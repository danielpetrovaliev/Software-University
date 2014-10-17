package Geometry.SpaceShape;

import Geometry.Vertex;

public class Cuboid extends SpaceShape {
	private double width;
	private double height;
	private double depth;
	
	/**
	 * Enter Array of 1 Vertex, width, height and depth
	 * @param Array of 1 Vertex
	 * @param width
	 * @param height
	 * @param depth
	 */
	public Cuboid(Vertex[] vertices, double width, double height, double depth) {
		super(vertices);
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
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

	public double getDepth() {
		return depth;
	}
	public void setDepth(double depth) {
		if (depth <= 0) {
			throw new IllegalArgumentException("Invalid depth.");
		}
		this.depth = depth;
	}

	@Override
	public double getArea() {
		double area = ( 2 * this.getWidth() * this.getDepth() ) +
				( 2 * this.getDepth() * this.getHeight() ) + 
				( 2 * this.getHeight() * this.getWidth() );
		return area;
	}

	@Override
	public double getVolume() {
		double volume = this.getDepth() * this.getWidth() * this.getHeight();
		return volume;
	}

}
