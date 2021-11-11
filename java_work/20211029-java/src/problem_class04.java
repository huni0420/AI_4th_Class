class Rectangle{
	int x,y,width,height;
	public Rectangle(int x, int y, int width,int height) {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
	}
	public int square() {
		
		int sqr = width*height;
		return sqr;
	}
	public void show() {
		System.out.println("("+x+","+y+")���� ũ�Ⱑ "+width+" X "+height+"�� �簢��");
		
	}
	public boolean contains(Rectangle t) {
		if(t.x>this.x && t.y>this.y) {
			if ((t.width+t.x)<(this.width+this.x) && (t.height+t.y)<(this.height+this.y)) {
				return true;
			}
		}
		return false;
	}	
}
public class problem_class04 {
	public static void main(String[] args) {
		Rectangle r = new Rectangle(2, 2, 8, 7);
		Rectangle s = new Rectangle(5, 5, 6, 6);
		Rectangle t = new Rectangle(1, 1, 10, 10);
		
		
		r.show();
		System.out.println("s�� ������ "+s.square());
		if(t.contains(r))System.out.println("t�� r�� �����մϴ�.");
		if(t.contains(s))System.out.println("t�� s�� �����մϴ�.");
	}
}
