namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isContinue;
            do
            {
                //Принимаем число N.
                int N;
                Terminal.Input(out N);

                //Инициализируем массив.
                double[][] A;
                Array.Init(N, out A);

                //Создаем файл с введеным названием и принимаем решение о продолжении.
                Terminal.Output(ref A, out isContinue);

            } while (isContinue);
        }
    }
}
