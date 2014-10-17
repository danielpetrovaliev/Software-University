package Geometry.PlaneShapes;

import Geometry.Vertex;

public class Triangle extends PlaneShape {
	private Vertex a;
	private Vertex b;
	private Vertex c;
	private double sideA;
	private double sideB;
	private double sideC;
	
	/**
	 * Enter vertices in this format [a, b, c]
	 * @param vertices
	 */
	public Triangle(Vertex[] vertices) {
		super(vertices);
		
		
		
		int aX = vertices[0].getX();
		int aY = vertices[0].getY();
		int bX = vertices[1].getX();
		int bY = vertices[1].getY();
		int cX = vertices[2].getX();
		int cY = vertices[2].getY();
		
		this.setA(new Vertex(aX, aY));
		this.setB(new Vertex(bX, bY));
		this.setC(new Vertex(cX, cY));
		
		this.sideA = Math.sqrt( Math.pow( cX - bX, 2 ) + Math.pow( cY - bY, 2 ) );
		this.sideB = Math.sqrt( Math.pow( cX - aX, 2 ) + Math.pow( cY - aY, 2 ) );
		this.sideC = Math.sqrt( Math.pow(aX - bX, 2 ) + Math.pow( aY - bY, 2 ) );
		
		if (Double.isNaN(getArea())) {
			throw new IllegalArgumentException("This triangle is invalid.");
		}
		
	}

	public Vertex getA() {
		return a;
	}
	public void setA(Vertex a) {
		this.a = a;
	}
	
	public Vertex getB() {
		return b;
	}
	public void setB(Vertex b) {
		this.b = b;
	}

	public Vertex getC() {
		return c;
	}
	public void setC(Vertex c) {
		this.c = c;
	}
	
	@Override
	public double getArea() {
		double p = 0.5 * (this.sideA + this.sideB + this.sideC);
		double area = p * (p - this.sideA) * (p - this.sideB) * (p - this.sideC) ;
		area = Math.sqrt( area );
		return area;
	}

	@Override
	public double getPerimeter() {
		double perimeter = this.sideA + this.sideB + this.sideC;
		return perimeter;
	}
}
