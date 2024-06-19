public class SuperClass {
    public int i;
}

public class B : SuperClass {
    public new int i;

    public B(int a , int b) {
        base.i = a;
        i = b;
    }

    public void show() {
        Console.WriteLine($"i in superclass: {base.i}");
        Console.WriteLine($"i in subclass: {i}");
    }
}