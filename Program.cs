using System;

namespace homework5
{
    class Program
    {
        struct Arrayinfo
        {
            public string Inputfile;
            public string Convolution_Kernel;
            public string Finalfile;
        }

        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath,
                                 double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }


        static void Main(string[] args)
        {
             Arrayinfo Image1;
            Image1.Inputfile = @"C:\Users\Boom167\source\repos\homework5\homework5\test_input_image.txt";
            Image1.Convolution_Kernel = @"C:\Users\Boom167\source\repos\homework5\homework5\test_convolution.txt";
            Image1.Finalfile = @"C:\Users\Boom167\source\repos\homework5\homework5\test_output_image.txt";
            
        }
        
    }
}
//พี่!! ผมทำไม่ไหวจริงๆต้องขอโทษด้วยครับ;-;