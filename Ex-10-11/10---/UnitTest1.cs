using Ex_10__wf_;
using NUnit.Framework.Legacy;
namespace _10___
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Form1 form = new Form1();
            form._subject.AddObserver(form._observer1);
            form._subject.AddObserver(form._observer2);
            form._subject.AddObserver(form._observer3);

            ClassicAssert.AreEqual("Ob1", form._observer1.Name);
            ClassicAssert.AreEqual("Ob2", form._observer2.Name);
            ClassicAssert.AreEqual("Ob3", form._observer3.Name);

        }
        [Test]
        public void Test2()
        {
            Form1 form = new Form1();
            form._subject.AddObserver(form._observer1);
            form._subject.AddObserver(form._observer2);
            form._subject.AddObserver(form._observer3);

            ClassicAssert.AreEqual(form._subject._observers.Count, 3);
        }
        [Test]
        public void Test3()
        {
            Form1 form = new Form1();
            form._subject.AddObserver(form._observer1);
            form._subject.AddObserver(form._observer2);
            form._subject.AddObserver(form._observer3);
            form._subject._observers.RemoveAt(2);
            ClassicAssert.AreEqual(form._subject._observers.Count, 2);
        }
        [Test]
        public void Test4()
        {
            Form1 form = new Form1();
            form._subject.AddObserver(form._observer1);
            form._subject.AddObserver(form._observer2);
            form._subject.AddObserver(form._observer3);

            form._subject._observers.RemoveAt(2);

            form._subject._observers.Remove(form._observer1);
            form._subject._observers.Remove(form._observer2);
            ClassicAssert.AreEqual(form._subject._observers.Count, 0);
        }
        [Test]
        public void Test5()
        {
            Form1 form = new Form1();
            form._subject.AddObserver(form._observer1);
            form._subject.AddObserver(form._observer2);
            form._subject.AddObserver(form._observer3);
            form._subject._observers.RemoveAt(2);

            form._subject._observers.Remove(form._observer1);
            form._subject._observers.Remove(form._observer2);

            form._subject.AddObserver(form._observer2);
            ClassicAssert.AreEqual("disactivate", form._subject._state);
        }
        [Test]
        public void Test6()
        {
            Form1 form = new Form1();
            form._subject.AddObserver(form._observer1);
            form._subject.AddObserver(form._observer2);
            form._subject.AddObserver(form._observer3);
            form._subject._observers.RemoveAt(2);

            form._subject._observers.Remove(form._observer1);
            form._subject._observers.Remove(form._observer2);

            form._subject.AddObserver(form._observer2);
            ClassicAssert.Contains(form._observer2, form._subject._observers);
        }
    }
}