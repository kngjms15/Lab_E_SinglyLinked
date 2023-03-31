namespace SinglyLinked
{
    public class Tests
    {
        private LinkedList sll;
        [SetUp]
        public void Setup()
        { sll = new LinkedList(); }

        /*
       1. Adding nodes to the beginning of the list
       2. Adding nodes to the end of the list
       3. Removing the first node in the list
       4. Removing the last node in the list
       5. Retrieving the value of a node at a given index
       6. Determining the size of the list
        */

        [Test]
        public void TestPrepending()
        {
            string name = "Joe Blow";
            sll.AddFirst(name);

            string name1 = "Joe Schmoe";
            sll.AddFirst(name1);

            
            Assert.IsNotNull(sll.Head); //Assert that it was added or the SLL is bigger
            Assert.AreEqual(2, sll.Count);
            Assert.AreNotEqual(0, sll.Count) ; //Assert that the first node value is "Joe Blow"

            Node first = sll.Head;
            string value = first.Value;
            Assert.AreEqual(name1, value);
            //Assert.IsNull(first.Next);//Assert there's no next of first node

            Node second = sll.Head.Next;
            string value2 = second.Value;
            Assert.AreEqual(name, value2);
            Assert.IsNull(second.Next);//Assert there's no next of first node

            Assert.AreEqual(2,sll.Count);

        }

        [Test]
        public void TestPrependingToNonEmpty()
        {
            sll.AddFirst("Joe Blow");
            sll.AddFirst("Joe Schmoe");
            sll.AddFirst("Joe Smith");
            sll.AddFirst("Jane Doe");
            sll.AddFirst("Bob Bobberson");
            sll.AddFirst("Sam Sammerson");
            sll.AddFirst("Dave Daverson");
        }


        [Test]
        public void TestAddFirst()
        {
            string name = "Joe Blow";
            sll.AddFirst(name);

            Assert.IsNotNull(sll.Head); //Assert that it was added or the SLL is bigger
            Assert.AreEqual(1, sll.Count);

            Node front = sll.Head;
            string frontvalue = front.Value;
            Assert.AreEqual(name, frontvalue);

            Assert.IsNull(front.Next);//Assert there's no next of first node

            //string name1 = "Joe Schmoe";
            //sll.AddFirst(name1);

            //sll.RemoveFirst();


            //Node first = sll.Head;

            //string value = first.Value;
            //Assert.AreEqual(name, value);

            //Assert.IsNull(first.Next);

            //Node second = sll.Head;
            //string value2 = second.Value;

            //Assert.AreEqual(name1, value2);

            //Assert.AreEqual(2, sll.Count);
            //Node next = sll.Head;
        }

        [Test]
        public void TestAddLast()
        {
            string name1 = "Joe Schmoe";
            sll.AddLast(name1);

            Assert.IsNotNull(sll.Head); //Assert that it was added or the SLL is bigger
            Assert.AreEqual(1, sll.Count);
            Assert.AreNotEqual("", sll.Head.Value);
            Assert.AreNotEqual(0,sll.Head.Next);
            

            Node last = sll.Head;
            string lastvalue = last.Value;
            Assert.AreEqual(name1, lastvalue);
            Assert.IsNull(last.Next);

        }

        [Test]
        public void TestRemoveFirst()
        {
            string name = "Joe Blow";
            sll.AddFirst("Joe Blow");
            string name1 = "Joe Schmoe";

            sll.AddLast(name1);
            sll.RemoveFirst();

            Assert.AreEqual(1,sll.Count);
            Assert.AreEqual("Joe Schmoe",sll.Head.Value);
            Assert.IsNull(sll.Head.Next);

            sll.AddLast(name1);
            sll.AddLast(name);
            sll.RemoveFirst();

            Assert.AreEqual(2,sll.Count);
            
            Node first = sll.Head;
            string firstvalue = first.Value;
            Assert.AreEqual(name1, firstvalue);

        }

        [Test]
        public void TestRemoveLast()
        {
            sll.AddFirst("Joe Blow");
            sll.AddLast("Joe Schmoe");
            sll.RemoveLast();

            Assert.AreEqual(1,sll.Count);
            Assert.AreEqual("Joe Blow", sll.Head.Value);
            Assert.IsNull(sll.Head.Next);
        }

        [Test]
        public void TestGetValue()// ***** Still has some errorrs!!! but I'm out of time.. sorry...
        {
            string name = "Joe Blow";
            string name1 = "Joe Schmoe";
            string name2 = "Joe Smith";
            string name3 = "Jane Doe";
            string name4 = "Bob Bobberson";
            string name5 = "Sam Sammerson";
            string name6 = "Dave Daverson";


            sll.AddFirst(name);
            sll.AddLast(name1);
            sll.AddLast(name2);
            sll.AddLast(name3);
            sll.AddLast(name4);
            sll.AddLast(name5);
            sll.AddLast(name6);

            Assert.AreEqual(name, sll.GetValue(0));
            Assert.AreEqual(name1, sll.GetValue(1));
            Assert.AreEqual(name2, sll.GetValue(2));
            Assert.AreEqual(name3, sll.GetValue(3));
            Assert.AreEqual(name4, sll.GetValue(4));
            Assert.AreEqual(name5, sll.GetValue(5));
            Assert.AreEqual(name6, sll.GetValue(6));

        }


        [TearDown]
        public void Teardown()
        {
            sll.Head = null;
            sll.Count = 0;
            sll.Clear();
        }
    }
}