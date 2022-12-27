namespace Standart
{
    public static class ReadNumber
    {
        private static void Main(string[] args)
        {

        }

        public static int VvodInt(string str)
        {
            Console.WriteLine(str);
            string strTest = Console.ReadLine()!;// ! чтобы не выводил жёлтый ворнинг
            int number;
            while (!int.TryParse(strTest, out number))
            {
                Console.WriteLine("АЛЁРТ!, введите еще раз " + str);
                strTest = Console.ReadLine()!;// ! чтобы не выводил жёлтый ворнинг
            }
            return number;
        }
    }

}