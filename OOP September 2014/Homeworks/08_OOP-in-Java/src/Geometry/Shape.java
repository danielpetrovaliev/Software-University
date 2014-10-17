package Geometry;

public abstract class Shape {
	private Vertex[] vertices;

	protected Shape(Vertex[] vertices) {
		this.setVertices(vertices);
	}

	protected Vertex[] getVertices() {
		return vertices;
	}

	protected void setVertices(Vertex[] vertices) {
		if (vertices.length < 1) {
			throw new NullPointerException("Shape must have some vertices.");
		}
		this.vertices = vertices;
	}	
}