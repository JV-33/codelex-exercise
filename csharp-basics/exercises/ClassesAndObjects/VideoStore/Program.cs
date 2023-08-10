using System;

namespace VideoStore
{

    class Program
    {
        private static VideoStore _store;

        public static void Main(string[] args)
        {
            _store = new VideoStore();
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        GiveRating();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            _store.ListInventory();
        }

        private static void FillVideoStore()
        {
            Console.WriteLine("Enter the video title to add: ");
            var title = Console.ReadLine();
            _store.AddVideo(title);
            Console.WriteLine($"Video {title} has been added.");
        }

        private static void RentVideo()
        {
            Console.WriteLine("Enter the video title to rent: ");
            var title = Console.ReadLine();
            _store.CheckOut(title);
            Console.WriteLine($"You have rented {title}.");
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("Enter the video title to return: ");
            var title = Console.ReadLine();
            _store.ReturnVideo(title); 
            Console.WriteLine($"You have returned {title}.");
        }

        private static void GiveRating()
        {
            Console.WriteLine("Enter the video title to rate: ");
            var title = Console.ReadLine();
            Console.WriteLine($"Enter your rating for {title} (for example, 4.5): ");
            var rating = Convert.ToDouble(Console.ReadLine());
            _store.ReceiveRating(title, rating);
            Console.WriteLine($"Thanks for rating {title}.");
        }
    }
}
