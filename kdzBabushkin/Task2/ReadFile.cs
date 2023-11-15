using System;
namespace Task2
{
	public class ReadFile
	{
        /// <summary>
        /// Читает с файла данные и переводит в массив. Возвращает возможность операции.
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <param name="A">получивщийся массив</param>
        /// <returns></returns>
        public static bool ParseArray(string fileName, out double[][] A)
        {
            //Читаю данные.
            string dataFromFile = File.ReadAllText(fileName);

            //Узнаю количество строк.
            int arrayLen = 0;
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                if (dataFromFile[i] == '\n')
                {
                    arrayLen++;
                }
            }

            //Инициализирую массив.
            A = new double[arrayLen][];
            // Читаю каждую строку и перевожу ее в массив, а после добавляю в инициализированный массив.
            int pref = 0;
            for (int i = 0; i < arrayLen; i++)
            {
                int arrayILen = 0;
                int stringILen = 0;
                for (int j = pref; dataFromFile[j] != '\n'; j++)
                {
                    if (dataFromFile[j] == '?')
                    {
                        arrayILen++;
                    }
                    stringILen++;
                }
                double[] arrayI = new double[(arrayILen+1)/2];

                string toConvert = "";
                int lastInd = 0;

                for(int j =pref; j < pref + stringILen + 1; j++)
                {
                    if(dataFromFile[j] == '?')
                    {
                        if (dataFromFile[j - 1] == '?')
                        {
                            double arrayIJ;
                            if (!double.TryParse(toConvert, out arrayIJ))
                            {
                                return false;
                            }
                            arrayI[lastInd] = arrayIJ;
                            lastInd++;
                            toConvert = "";
                        }
                    }
                    else
                    {
                        toConvert += dataFromFile[j];
                    }
                }

                arrayI[lastInd] = double.Parse(toConvert);

                A[i] = arrayI;

                pref += stringILen + 2;
            }

            return true;
        }
    }
}

