namespace Can_Place_Flowers
{
    internal class Program
    {
        public class PlaceCanFlowers
        {
            public bool CanPlaceFlowers(int[] flowerbed, int n)
            {
                int placeCount = 0;
                for (int i = 0; i < flowerbed.Length; ++i)
                {
                    if (flowerbed[i] == 0)
                    {
                        bool emptyLeftPlace = i == 0 || flowerbed[i - 1] == 0;
                        bool emptyRightPlace = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;
                        if (emptyLeftPlace && emptyRightPlace)
                        {
                            flowerbed[i] = 1;
                            ++placeCount;
                            if (placeCount >= n)
                            {
                                return true;
                            }
                        }
                    }
                }
                return placeCount >= n;
            }
        }
        static void Main(string[] args)
        {
            PlaceCanFlowers placeCanFlowers = new();
            Console.WriteLine(placeCanFlowers.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1));
            Console.WriteLine(placeCanFlowers.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2));
        }
    }
}