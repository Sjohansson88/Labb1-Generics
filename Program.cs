namespace Labb1_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();

            boxList.Add(new Box(10,10,10));
            boxList.Add(new Box(20, 20, 20));
            boxList.Add(new Box(15, 15, 15));
            boxList.Add(new Box(5, 5, 5));
            boxList.Add(new Box(12, 12, 10));



            Display(boxList);
            Console.WriteLine("----------------------------------------------------------");

            boxList.Add(new Box(10, 10, 10));
            Console.WriteLine("----------------------------------------------------------");
          
           

            boxList.Remove(new Box(5, 5, 5));
            Display(boxList);
            Console.WriteLine("----------------------------------------------------------");

            Box boxToCheck = new Box(10, 10, 10);
            Console.WriteLine("Contains ID: {0}, Grade: {1}, Total: {2}",
                boxToCheck.Width.ToString(), boxToCheck.Height.ToString(), boxToCheck.Length.ToString(),
                boxList.Contains(boxToCheck));


            Console.ReadKey();
            Display(boxList);
            Console.WriteLine("----------------------------------------------------------");
        }




        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("\nWidth \tHeight \tLength");

            foreach (Box box in boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                box.Width.ToString(), box.Height.ToString(), box.Length.ToString());
            }
        }
    }
}
