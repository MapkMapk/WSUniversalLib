using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static string GetDataFromFile(string path)
        {   
            //string path = @"c:\temp\MyTest.txt";
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            return readText;
            //Console.WriteLine(readText);
        }

        /// <summary>
        /// подсчет кол-ва необходимого сырья
        /// </summary>
        /// <param name="productType">идентификатор типа продукции</param>
        /// <param name="materialType">идентификатор типа материала</param>
        /// <param name="count">количество необходимой продукции</param>
        /// <param name="width">ширина</param>
        /// <param name="length">длинна</param>
        /// <returns>возвращает количество необходимого сырья с учетом возможного брака сырья.</returns>
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            try
            {
                double index;
                switch (productType)
                {
                    case 1:
                        index = 1.1;
                        break;

                    case 2:
                        index = 2.5;
                        break;

                    case 3:
                        index = 8.43;
                        break;
                    default:
                        return -1;
                }
                double flaw;
                switch (materialType)
                {
                    case 1:
                        flaw = 1.003;
                        break;

                    case 2:
                        flaw = 1.0012;
                        break;
                    default:
                        return -1;
                }
                double result = count * width * length * index * flaw;
                return Convert.ToInt32(result);
            }
            catch
            {
                return -1;
            }
        }
    }
}
