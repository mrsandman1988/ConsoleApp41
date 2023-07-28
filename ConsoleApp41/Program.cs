namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Shop shop = new("","");
            foreach(var item in shop)
            {
                Console.WriteLine(item.Name);
            }
            Console.Write(shop.Name);


        }

        public static IEnumerable<int> GetAllItems(List<List<int>> values)
        {

            foreach(var item in values)
            {
                foreach(var subItem in item)
                {
                    yield return subItem;
                }
            }
        }
    }
}