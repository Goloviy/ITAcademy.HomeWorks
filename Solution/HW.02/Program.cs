using System;
using System.IO;
namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Чтение файла из E:\image.txt
             *2. Запись полученных данных в массив.
             *3. Создание массив байтов.
             *4. Перевод полученных данных из файла в байты и запись их в массив.
             *5. Конвертация байтов в пиксели и сохранение их в файле.
             */
            StreamReader textReader = new StreamReader(@"E:\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();


            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"E:\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}
