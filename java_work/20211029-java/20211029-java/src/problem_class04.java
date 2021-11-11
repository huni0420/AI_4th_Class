class Rectangle{
	private int x,y,width,height;
	private String name;
	public Rectangle(int x, int y, int width,int height,String name) {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
		this.name = name;
	}
	public void show() {
		System.out.println("("+x+","+y+")���� ũ�Ⱑ "+width+" X "+height+"�� �簢��");
		System.out.println(name+"�� ���̴� "+width*height);
	}
	public boolean contains(Rectangle t) {
		if(t.x>this.x && t.y>this.y) {
			if(t.height+t.y<this.height+this.y && t.width+t.x<this.width+this.x)
				return true;
		}
			return false;
	}	
}
public class problem_class04 {
	
	public static void main(String[] args) {
		Rectangle r = new Rectangle(2, 2, 8, 7,"�簢�� r");
		Rectangle s = new Rectangle(5, 5, 6, 6,"�簢�� s");
		Rectangle t = new Rectangle(1, 1, 10, 10,"�簢�� t");
		
		r.show();
		s.show();
		if(t.contains(r))System.out.println("t�� r�� �����մϴ�.");
		if(t.contains(s))System.out.println("t�� s�� �����մϴ�.");
	}
}
