using System.Threading;

public class Foo {
    
    AutoResetEvent e2, e3;
    public Foo() {
        e2 = new AutoResetEvent(false);
        e3 = new AutoResetEvent(false);
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        e2.Set();
    }

    public void Second(Action printSecond) {
        e2.WaitOne();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        e3.Set();
    }

    public void Third(Action printThird) {
        e3.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}