using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace WSUniversalTest
{
    [TestClass]
    public class UnitTest1
    {
        static string inputFilesNames = "InputData_01.txt InputData_Easy_02.txt InputData_Easy_03.txt InputData_Easy_04.txt InputData_Easy_05.txt InputData_Easy_06.txt InputData_Easy_07.txt InputData_Easy_08.txt InputData_Easy_09.txt InputData_Easy_10.txt InputData_Easy_11.txt InputData_Easy_12.txt InputData_Easy_13.txt InputData_Easy_14.txt InputData_Easy_15.txt InputData_Easy_16.txt InputData_Easy_17.txt InputData_Easy_18.txt InputData_Easy_19.txt InputData_Easy_20.txt InputData_Hard_01.txt InputData_Hard_02.txt InputData_Hard_03.txt InputData_Hard_04.txt InputData_Hard_05.txt InputData_Hard_06.txt InputData_Hard_07.txt InputData_Hard_08.txt InputData_Hard_09.txt InputData_Hard_10.txt";
        string[] input = inputFilesNames.Split(' ');
        static string OutputFilesNames = "OutputData_Easy_01.txt OutputData_Easy_02.txt OutputData_Easy_03.txt OutputData_Easy_04.txt OutputData_Easy_05.txt OutputData_Easy_06.txt OutputData_Easy_07.txt OutputData_Easy_08.txt OutputData_Easy_09.txt OutputData_Easy_10.txt OutputData_Easy_11.txt OutputData_Easy_12.txt OutputData_Easy_13.txt OutputData_Easy_14.txt OutputData_Easy_15.txt OutputData_Easy_16.txt OutputData_Easy_17.txt OutputData_Easy_18.txt OutputData_Easy_19.txt OutputData_Easy_20.txt OutputData_Hard_01.txt OutputData_Hard_02.txt OutputData_Hard_03.txt OutputData_Hard_04.txt OutputData_Hard_05.txt OutputData_Hard_06.txt OutputData_Hard_07.txt OutputData_Hard_08.txt OutputData_Hard_09.txt OutputData_Hard_10.txt";
        string[] output = OutputFilesNames.Split(' ');

        [TestMethod]
        public void TestMethodWork_InputData_01_OutputData_Easy_01()
        {
        }
    }
}
