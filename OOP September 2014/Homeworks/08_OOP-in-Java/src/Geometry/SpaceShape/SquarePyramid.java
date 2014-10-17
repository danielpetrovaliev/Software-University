package Geometry.SpaceShape;

import Geometry.Vertex;

public class SquarePyramid extends SpaceShape {
	private double baseWidth;
	private double pyramidHeight;
	
	/**
	 * Enter Array of 1 vertex, width and height
	 * @param Array of 1 Vertex
	 * @param baseWidth
	 * @param pyramidHeight
	 */
	public SquarePyramid(Vertex[] vertices, double baseWidth, double pyramidHeight) {
		super(vertices);
		this.setBaseWidth(baseWidth);
		this.setPyramidHeight(pyramidHeight);
	}
	
	

	public double getBaseWidth() {
		return baseWidth;
	}
	public void setBaseWidth(double baseWidth) {
		if (baseWidth <= 0) {
			throw new IllegalArgumentException("Invalid base width.");
		}
		this.baseWidth = baseWidth;
	}

	public double getPyramidHeight() {
		return pyramidHeight;
	}
	public void setPyramidHeight(double pyramidHeight) {
		if (pyramidHeight <= 0) {
			throw new IllegalArgumentException("Invalid pyramid height.");
		}
		this.pyramidHeight = pyramidHeight;
	}

	private double getBaseArea() {
		return this.baseWidth * this.baseWidth;
	}
	
	@Override
	public double getArea() {
		double faceArea = (1.0 / 2.0) * (4 * this.baseWidth) * this.getPyramidHeight();
		double baseArea = this.getBaseArea();
		
		return faceArea + baseArea;
	}

	@Override
	public double getVolume() {
		return (1.0 / 3.0) * this.getBaseArea() * this.getPyramidHeight();
	}

}
