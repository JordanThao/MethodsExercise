namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();

            int added = Add(4, 3);
            Console.WriteLine(added);

            int subtracted = Subtract(10, 5);
            Console.WriteLine(subtracted);

            int multiplied = Multiply(11, 3);
            Console.WriteLine(multiplied);

            int divided = Divide(70, 5);
            Console.WriteLine(divided);

            int Result = Sum((added), (subtracted), (multiplied), (divided), 11);
            Console.WriteLine(Result);
        }
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite Season?");
            string favoriteSeason = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite flower or plant? Please use plura noun.");
            string favoritePlant = Console.ReadLine();
            Console.WriteLine("What is your favorite animal? Please use plura noun.");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"{userName} wandered through the seemingly empty forest feeling the cold damp moss of the forest floor beneath them. Looking up {userName} saw the gigantic {favoriteSeason} trees that seemed to stretch up towards the heavens as the sun's rays struggled to shine through the thick canopy. Around {userName} seemed to be a field of {favoritePlant} nestled under the trees. As {userName} examined their surroundings, something a few meters away cuaght {userName}'s attention. It glowed with a {favoriteColor} hue in the dim surroundings. {userName} cautiously stummbled towards it. Directly in front of them seemed to be a shrine wrapped in vines and covered with moss. Pushing away the vines and wiping away the moss, they notice symbols written in a slightly odd language that glowed {favoriteColor}. 'but what language?' they might have pondered. {userName} continued to examine the strange symbols as it moved and warped almost as if the text had a mind of its own. As the morning rays began breaking through the forest canopy, {userName} realized they were within an anciant city long forgetten and swallowed by the forest. {favoritePlant} seemed to engulf the city as far as they could see, not only that but every few meters apart were old buildings between them decrypted streets. As {userName} strolled around the city they came across a group of {favoriteAnimal}, which pranced down the streets, unaware of {userName}'s presence. As {userName} went deeper into the forest that glowing {favoriteColor} glow semmed to become stronger. The animals around them were different, now winged. One of them being a group of winged {favoriteAnimal}. {userName} made their way out of the rubbled city and through the thick vines to see a small community of winged people. {userName} saw some were gathering {favoritePlant} while others were farming or reading ancient looking books. As {userName} stumbled in, one of them stepped forward, a young man with tousled brown hair, piercing scarlet eyes, and the biggest wings amongst the others. The {favoriteSeason} wind danced with a {favoriteColor} aura around him as he spoke, 'You don't belong here, Outlander!' He said as his eyes pierced your very soul. Story End.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
