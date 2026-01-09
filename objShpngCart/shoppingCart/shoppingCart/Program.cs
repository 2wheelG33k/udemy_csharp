namespace shoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user name for cart: ");
            string inputName =  Console.ReadLine();
            Console.WriteLine("Enter maximum number of items for cart: ");
            int inputMaxItems = int.Parse(Console.ReadLine());
            
            Cart userCart = new Cart(inputName, inputMaxItems);
            
            for (int i=0; i < userCart.MaxItems; i++)
            {
                Console.WriteLine("Enter new item for list: ");
                string newItemAdd = Console.ReadLine();
                userCart.AddItem(newItemAdd);
            }

            userCart.DisplayItems();
        }
    }
}
