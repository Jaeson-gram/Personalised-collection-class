using System.Collections;

namespace DataStructuresAndAlgos
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyCollection namesOfLodgeMates = new MyCollection();

            //Add values to the collection for testing
            namesOfLodgeMates.Put("Joshua");
            namesOfLodgeMates.Put("Ofu");
            namesOfLodgeMates.Put("Akin");
            namesOfLodgeMates.Put("Winner");
            namesOfLodgeMates.Put("Yemisi");

            //The below line causes an error when the code tries to implement the sort method (arrange method).
            //But accepts any datatype. So we get an invalidoperationexception while it tries to sort the collection,
            //because it compares the elements in the collection to see which should come first, before it sorts it

            // --->       namesOfLodgeMates.Put(100_000d);       <---


            //Sort the collection
            namesOfLodgeMates.Arrange();

            //iterate through and print every item in the list
            foreach (var name in namesOfLodgeMates)
            {
                Console.WriteLine(name);
                // --> Akin
                // --> Joshua
                // --> Ofu
                // --> Winner
                // --> Yemisi
            }
        }
    }

    public class MyCollection : CollectionBase
    {

        public void Put(Object item)
        {
            InnerList.Add(item);
        }

        public void Commot(Object item)
        {
            InnerList.Remove(item);
        }

        public void Wipe()
        {
            InnerList.Clear();
        }

        public void Arrange()
        {
            InnerList.Sort();
        }

        public int HowMany()
        {
            return InnerList.Count;
        }
        
    }
}