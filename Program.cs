namespace Program.Cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи числата с интервал");
            string input=Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] numbers=new int[parts.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }
            int sum = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];
            }
            int max = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                } 
               
            }
            int count = 0;
                for(int i=0; i<numbers.Length ; i++)
            {
                if (numbers[i] == 9)
                {
                    count++;
                }
            }
            Console.WriteLine("Сума на елементите:" + sum);
            Console.WriteLine("Най голям елемент:" + max);
            Console.WriteLine("Числото 9 се среща:" + count + " пъти");
        }
    }
}
