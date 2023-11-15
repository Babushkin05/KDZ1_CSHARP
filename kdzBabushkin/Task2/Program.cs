namespace Task2
{
    class Program
    {
        /// <summary>
        /// Выполняет программу.
        /// </summary>
        /// <param name="args"></param>
        public static void Main()
        {
            //Повторяет программу пока этого хочет пользователь.
            bool isContinue = true;
            do
            {
                double[][] B = Terminal.GetArray();

                Terminal.ReadChangedArray(ref B, ref isContinue);
                
            } while (isContinue);
        }
    }
}