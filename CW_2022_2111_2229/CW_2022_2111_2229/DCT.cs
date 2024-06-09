using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2022_2111_2229
{
    class DCT
    {
        // координаты коэффициетов , которые меняем
        public int v1 { get; set; }
        public int v2 { get; set; }
        public int v3 { get; set; }
        public int u1 { get; set; }
        public int u2 { get; set; }
        public int u3 { get; set; }

        //порог изменения коэффициентов
        public double P { get; set; }
        public double PL { get; set; }
        public double PH { get; set; }

        static byte[,] submatrix(byte[,] one, int a, int b, int c, int d)
        {

            byte[,] temp = new byte[b - a + 1, d - c + 1];
            for (int i = a, k = 0; i <= b; i++, k++)
                for (int j = c, l = 0; j <= d; j++, l++)
                    temp[k, l] = one[i, j];

            return temp;
        }

        static double[,] dct(byte[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] new_matrix = new double[n, n];

            double U, V,
                   temp = 0;

            for (int v = 0; v < n; v++)
                for (int u = 0; u < n; u++)
                {
                    if (v == 0) V = 1.0 / Math.Sqrt(2);
                    else V = 1;

                    if (u == 0) U = 1.0 / Math.Sqrt(2);
                    else U = 1;

                    temp = 0;

                    for (int x = 0; x < n; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            temp += matrix[x, y] * Math.Cos(Math.PI * v * (2 * x + 1) / (2 * n)) *
                                Math.Cos(Math.PI * u * (2 * y + 1) / (2 * n));
                        }
                    }

                    new_matrix[v, u] = U * V * temp / (Math.Sqrt(2 * n));
                }
 
            return new_matrix;
        }

        static double[,] i_dct(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] new_matrix = new double[n, n];

            double U, V,
                   temp = 0;

            for (int x = 0; x < n; x++)
                for (int y = 0; y < n; y++)
                {
                    temp = 0;

                    for (int v = 0; v < n; v++)
                        for (int u = 0; u < n; u++)
                        {
                            if (v == 0) V = 1.0 / Math.Sqrt(2);
                            else V = 1;

                            if (u == 0) U = 1.0 / Math.Sqrt(2);
                            else U = 1;

                            temp += U * V * matrix[v, u] * Math.Cos(Math.PI * v * (2 * x + 1) / (2 * n)) *
                                Math.Cos(Math.PI * u * (2 * y + 1) / (2 * n));
                        }

                    new_matrix[x, y] = temp / (Math.Sqrt(2 * n));
                }
 
            return new_matrix;
        }

        static double[,] norm(double[,] matrix)
        {
            double min = Double.MaxValue, max = Double.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                    if (matrix[i, j] < min) min = matrix[i, j];
                }

            double[,] new_matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    new_matrix[i, j] = 255 * (matrix[i, j] + Math.Abs(min)) / (max + Math.Abs(min));

            return new_matrix;
        }

        static double[,] unionmatrix(double[,] one, double[,] two, int a, int b, int c, int d)
        {
            for (int i = a, k = 0; i <= b; i++, k++)
                for (int j = c, l = 0; j <= d; j++, l++)
                    one[i, j] = two[k, l];

            return one;
        }

        static double[,] teta(double[,] one)
        {
            double[,] two = new double[one.GetLength(0), one.GetLength(1)];
            for (int i = 0; i < one.GetLength(0); i++)
                for (int j = 0; j < one.GetLength(1); j++)
                    two[i, j] = one[i, j];
            return two;
        }

        double[,] dct_coeffs_change(double[,] one, int i, int u1, int v1, int u2, int v2, double P)
        {
            var temp = teta(one);
            double Abs1, Abs2;
            double z1 = 0, z2 = 0;
            Abs1 = Math.Abs(temp[u1, v1]);
            Abs2 = Math.Abs(temp[u2, v2]);

            if (temp[u1, v1] >= 0) z1 = 1;
            else z1 = -1;

            if (temp[u2, v2] >= 0) z2 = 1;
            else z2 = -1;

            if (i == 0 && Abs1 - Abs2 <= P)
                Abs1 = Abs2 + P + 1;

            if (i == 1 && Abs1 - Abs2 >= -P)
                Abs2 = Abs1 + P + 1;

            temp[u1, v1] = z1 * Abs1;
            temp[u2, v2] = z2 * Abs2;
            return temp;
        }

        double[,] dct_coeffs_change_BMYY(double[,] one, int i,
                                         int u1, int v1,
                                         int u2, int v2,
                                         int u3, int v3,
                                         double P)
        {
            var temp = teta(one);

            double Abs1 = Math.Abs(temp[u1, v1]),
                   Abs2 = Math.Abs(temp[u2, v2]),
                   Abs3 = Math.Abs(temp[u3, v3]);

            double z1 = temp[u1, v1] > 0 ? 1 : -1,
                   z2 = temp[u2, v2] > 0 ? 1 : -1,
                   z3 = temp[u3, v3] > 0 ? 1 : -1;

            double Abs_min = Abs1 < Abs2 ? Abs1 : Abs2;
            double Abs_max = Abs1 > Abs2 ? Abs1 : Abs2;

            if (i == 0 && Abs3 - Abs_min >= -P)
                Abs1 = Abs2 = Abs3 + P + 1;

            if (i == 1 && Abs3 - Abs_max <= P)
                Abs3 = Abs_max + P + 1;

            temp[u1, v1] = z1 * Abs1;
            temp[u2, v2] = z2 * Abs2;
            temp[u3, v3] = z3 * Abs3;

            return temp;
        }

        public Bitmap Hide(string text, Bitmap bmp)
        {
            byte[] allbytes = Encoding.GetEncoding(1251).GetBytes(text);//1251 - кодировка. 

            int y = bmp.Height, x = bmp.Width;

            y -= y % 8;
            x -= x % 8;

            Byte[,] B = new Byte[x, y];
            Byte[,] R = new Byte[x, y];
            Byte[,] G = new Byte[x, y];

            //выбираем из картинки синюю компоненту RGB-модели
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    B[i, j] = bmp.GetPixel(i, j).B; // массив значений синей компоненты исходного изображения
                    R[i, j] = bmp.GetPixel(i, j).R;
                    G[i, j] = bmp.GetPixel(i, j).G;
                }

            List<byte[,]> C = new List<byte[,]>(); //разбиваем массив В на матрицы 8 на 8
            int N = 8; //размерность сегментов
            int Nc = (x / N) * (y / N); //общей число сегментов
            //if (Nc < 8 * allbytes.Length) throw new ArgumentException("Текст слишком велик");
            //разбиваем массив B на сегменты С
            int C1 = 0, C2 = N - 1;
            int r1, r2;
            for (int b = 0; b < Nc; b++)
            {
                r1 = N * b % x;
                r2 = r1 + N - 1;
                C.Add(submatrix(B, r1, r2, C1, C2));
                if (r2 == x - 1)
                {
                    C1 += N;
                    C2 += N;
                }
            }
            List<double[,]> dkp_matrix = new List<double[,]>(); //список матриц 8на8 коэффициентов дкп
            for (int i = 0; i < Nc; i++)
                dkp_matrix.Add(dct(C[i]));

            int a = 0;

            //Меняем коэффициенты ДКП в матрицах 8на8 и записываем в список матриц
            for (int m = 0; m < allbytes.Length; m++)
            {
                Bits bits = new Bits(allbytes[m]);
                for (int i = 0; i < bits.Length; i++)
                {
                    dkp_matrix[a] = dct_coeffs_change(dkp_matrix[a], bits[i], u1, v1, u2, v2, P);
                    a++;
                }
            }

            //обратное дкп, возвращает измененный лист сегментов 8на8
            List<double[,]> C_new = new List<double[,]>();
            for (int i = 0; i < dkp_matrix.Count; i++)
                C_new.Add(i_dct(dkp_matrix[i]));

            //собираем сегменты в массив
            double[,] B1 = new double[x, y];
            r1 = -N; r2 = -1; C1 = 0; C2 = N - 1;
            for (int b = 0; b < Nc; b++)
            {
                r1 += N;
                r2 += N;
                B1 = unionmatrix(B1, C_new[b], r1, r2, C1, C2);
                if (r2 == x - 1)
                {
                    r1 = -N;
                    r2 = -1;
                    C1 += N;
                    C2 += N;
                }
            }
            B1 = norm(B1);
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    bmp.SetPixel(i, j, Color.FromArgb(R[i, j], G[i, j], (byte)Math.Round(B1[i, j])));

            return bmp;
        }

        public string Extract(Bitmap bmp)
        {

            int y = bmp.Height, x = bmp.Width;

            y -= y % 8;
            x -= x % 8;

            Byte[,] B = new Byte[x, y];
            Byte[,] R = new Byte[x, y];
            Byte[,] G = new Byte[x, y];
            //выбираем из картинки синюю компоненту RGB-модели
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    B[i, j] = bmp.GetPixel(i, j).B; // массив значений синей компоненты исходного изображения
                    R[i, j] = bmp.GetPixel(i, j).R;
                    G[i, j] = bmp.GetPixel(i, j).G;
                }

            List<byte[,]> C = new List<byte[,]>(); //разбиваем массив В на матрицы 8 на 8
            int N = 8; //размерность сегментов
            int Nc = x * y / (N * N); //общей число сегментов             
            //разбиваем массив B на сегменты С
            int C1 = 0, C2 = N - 1;
            int r1, r2;
            for (int b = 0; b < Nc; b++)
            {
                r1 = N * b % x;
                r2 = r1 + N - 1;
                C.Add(submatrix(B, r1, r2, C1, C2));
                if (r2 == x - 1)
                {
                    C1 += N;
                    C2 += N;
                }
            }

            List<double[,]> dkp_matrix = new List<double[,]>(); //список матриц 8на8 коэффициентов дкп
            for (int i = 0; i < Nc; i++)
                dkp_matrix.Add(dct(C[i]));

            double[,] dkp_8x8; //матрица 8на8 для коэффициентов ДКП

            double Abs1, Abs2;
            string bits = "";
            List<byte> bytetext = new List<byte>();
            bool t = true;

            for (int k = 0; k < Nc && t; k++)
            {
                dkp_8x8 = teta(dkp_matrix[k]);
                Abs1 = Math.Abs(dkp_8x8[u1, v1]);
                Abs2 = Math.Abs(dkp_8x8[u2, v2]);

                if (Abs1 - Abs2 > P - 1)
                    bits += "0";
                else if (Abs1 - Abs2 < -P + 1)
                    bits += "1";
                else
                    t = false;

                if (bits.Length == 8)
                {
                    bytetext.Add(Convert.ToByte(new Bits(bits).Number));
                    bits = "";
                }
            }

            return Encoding.GetEncoding(1251).GetString(bytetext.ToArray());
        }

        public Bitmap Hide_BMYY(string text, Bitmap bmp)
        {
            byte[] allbytes = Encoding.GetEncoding(1251).GetBytes(text);//1251 - кодировка. 

            int y = bmp.Height, x = bmp.Width;

            y -= y % 8;
            x -= x % 8;

            Byte[,] B = new Byte[x, y];
            Byte[,] R = new Byte[x, y];
            Byte[,] G = new Byte[x, y];

            //выбираем из картинки синюю компоненту RGB-модели
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    B[i, j] = bmp.GetPixel(i, j).B; // массив значений синей компоненты исходного изображения
                    R[i, j] = bmp.GetPixel(i, j).R;
                    G[i, j] = bmp.GetPixel(i, j).G;
                }

            List<byte[,]> C = new List<byte[,]>(); //разбиваем массив В на матрицы 8 на 8
            int N = 8; //размерность сегментов
            int Nc = (x / N) * (y / N); //общей число сегментов
            if (Nc < 8 * allbytes.Length) throw new ArgumentException("Текст слишком велик");
            //разбиваем массив B на сегменты С
            int C1 = 0, C2 = N - 1;
            int r1, r2;
            for (int b = 0; b < Nc; b++)
            {
                r1 = N * b % x;
                r2 = r1 + N - 1;
                C.Add(submatrix(B, r1, r2, C1, C2));
                if (r2 == x - 1)
                {
                    C1 += N;
                    C2 += N;
                }
            }
            List<double[,]> dkp_matrix = new List<double[,]>(); //список матриц 8на8 коэффициентов дкп
            for (int i = 0; i < Nc; i++)
                dkp_matrix.Add(dct(C[i]));

            int a = 0;

            //Меняем коэффициенты ДКП в матрицах 8на8 и записываем в список матриц
            for (int m = 0; m < allbytes.Length; m++)
            {
                Bits bits = new Bits(allbytes[m]);
                for (int i = 0; i < bits.Length && a < Nc; i++)
                {
                    double S_LF = 0, S_HF = 0;

                    do
                    {
                        S_LF = 0;
                        for (int u = 0; u < N - 1; u++)
                            for (int v = 0; v < N - u - 1; v++)
                            {
                                if (u + v > 0)
                                    S_LF += Math.Abs(dkp_matrix[a][u, v]);
                            }

                        S_HF = 0;
                        for (int u = N - 1; u > 1; u--)
                            for(int v = N - 1; v > N - u; v--)
                                S_HF += Math.Abs(dkp_matrix[a][u, v]);

                        if (!(S_LF < PL && S_HF > PH))
                            a++;

                    } while (!(S_LF < PL && S_HF > PH) && a < Nc);

                    if (a < Nc)
                        dkp_matrix[a] = dct_coeffs_change_BMYY(dkp_matrix[a], bits[i], u1, v1, u2, v2, u3, v3, P);
                    a++;
                }     
            }

            //обратное дкп, возвращает измененный лист сегментов 8на8
            List<double[,]> C_new = new List<double[,]>();
            for (int i = 0; i < dkp_matrix.Count; i++)
                C_new.Add(i_dct(dkp_matrix[i]));

            //собираем сегменты в массив
            double[,] B1 = new double[x, y];
            r1 = -N; r2 = -1; C1 = 0; C2 = N - 1;
            for (int b = 0; b < Nc; b++)
            {
                r1 += N;
                r2 += N;
                B1 = unionmatrix(B1, C_new[b], r1, r2, C1, C2);
                if (r2 == x - 1)
                {
                    r1 = -N;
                    r2 = -1;
                    C1 += N;
                    C2 += N;
                }
            }
            B1 = norm(B1);
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    bmp.SetPixel(i, j, Color.FromArgb(R[i, j], G[i, j], (byte)Math.Round(B1[i, j])));

            return bmp;
        }

        public string Extract_BMYY(Bitmap bmp)
        {

            int y = bmp.Height, x = bmp.Width;

            y -= y % 8;
            x -= x % 8;

            Byte[,] B = new Byte[x, y];
            Byte[,] R = new Byte[x, y];
            Byte[,] G = new Byte[x, y];
            //выбираем из картинки синюю компоненту RGB-модели
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    B[i, j] = bmp.GetPixel(i, j).B; // массив значений синей компоненты исходного изображения
                    R[i, j] = bmp.GetPixel(i, j).R;
                    G[i, j] = bmp.GetPixel(i, j).G;
                }

            List<byte[,]> C = new List<byte[,]>(); //разбиваем массив В на матрицы 8 на 8
            int N = 8; //размерность сегментов
            int Nc = x * y / (N * N); //общей число сегментов             
            //разбиваем массив B на сегменты С
            int C1 = 0, C2 = N - 1;
            int r1, r2;
            for (int b = 0; b < Nc; b++)
            {
                r1 = N * b % x;
                r2 = r1 + N - 1;
                C.Add(submatrix(B, r1, r2, C1, C2));
                if (r2 == x - 1)
                {
                    C1 += N;
                    C2 += N;
                }
            }

            List<double[,]> dkp_matrix = new List<double[,]>(); //список матриц 8на8 коэффициентов дкп
            for (int i = 0; i < Nc; i++)
                dkp_matrix.Add(dct(C[i]));

            double[,] dkp_8x8; //матрица 8на8 для коэффициентов ДКП

            double Abs1, Abs2, Abs3;
            string bits = "";
            List<byte> bytetext = new List<byte>();
            bool t = true;

            for (int k = 0; k < Nc && t; k++)
            {
                double S_LF = 0, S_HF = 0;

                do
                {
                    S_LF = 0;
                    for (int u = 0; u < N - 1; u++)
                        for (int v = 0; v < N - u - 1; v++)
                        {
                            if (u + v > 0)
                                S_LF += Math.Abs(dkp_matrix[k][u, v]);
                        }

                    S_HF = 0;
                    for (int u = N - 1; u > 1; u--)
                        for (int v = N - 1; v > N - u; v--)
                            S_HF += Math.Abs(dkp_matrix[k][u, v]);

                    if (!(S_LF < PL && S_HF > PH)) k++;

                } while (!(S_LF < PL && S_HF > PH) && k < Nc);

                if (k < Nc)
                {
                    dkp_8x8 = teta(dkp_matrix[k]);
                    Abs1 = Math.Abs(dkp_8x8[u1, v1]);
                    Abs2 = Math.Abs(dkp_8x8[u2, v2]);
                    Abs3 = Math.Abs(dkp_8x8[u3, v3]);

                    double Abs_min = Abs1 < Abs2 ? Abs1 : Abs2;
                    double Abs_max = Abs1 > Abs2 ? Abs1 : Abs2;

                    if (Abs3 < Abs_min)
                        bits += "0";
                    else if (Abs3 > Abs_max)
                        bits += "1";
                    else t = false;

                    if (bits.Length == 8)
                    {
                        bytetext.Add(Convert.ToByte(new Bits(bits).Number));
                        bits = "";
                    }
                }
            }

            return Encoding.GetEncoding(1251).GetString(bytetext.ToArray());
        }

        public int CountOfCorrectBlocks(Bitmap bmp)
        {
            int count = 0;

            int y = bmp.Height, x = bmp.Width;

            y -= y % 8;
            x -= x % 8;

            Byte[,] B = new Byte[x, y];
            Byte[,] R = new Byte[x, y];
            Byte[,] G = new Byte[x, y];
            //выбираем из картинки синюю компоненту RGB-модели
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    B[i, j] = bmp.GetPixel(i, j).B; // массив значений синей компоненты исходного изображения
                    R[i, j] = bmp.GetPixel(i, j).R;
                    G[i, j] = bmp.GetPixel(i, j).G;
                }

            List<byte[,]> C = new List<byte[,]>(); //разбиваем массив В на матрицы 8 на 8
            int N = 8; //размерность сегментов
            int Nc = x * y / (N * N); //общей число сегментов             
            //разбиваем массив B на сегменты С
            int C1 = 0, C2 = N - 1;
            int r1, r2;
            for (int b = 0; b < Nc; b++)
            {
                r1 = N * b % x;
                r2 = r1 + N - 1;
                C.Add(submatrix(B, r1, r2, C1, C2));
                if (r2 == x - 1)
                {
                    C1 += N;
                    C2 += N;
                }
            }

            List<double[,]> dkp_matrix = new List<double[,]>(); //список матриц 8на8 коэффициентов дкп
            for (int i = 0; i < Nc; i++)
                dkp_matrix.Add(dct(C[i]));

            for (int k = 0; k < Nc; k++)
            {
                double S_LF = 0, S_HF = 0;

                do
                {
                    S_LF = 0;
                    for (int u = 0; u < N - 1; u++)
                        for (int v = 0; v < N - u - 1; v++)
                        {
                            if (u + v > 0)
                                S_LF += Math.Abs(dkp_matrix[k][u, v]);
                        }

                    S_HF = 0;
                    for (int u = N - 1; u > 1; u--)
                        for (int v = N - 1; v > N - u; v--)
                            S_HF += Math.Abs(dkp_matrix[k][u, v]);

                    if (!(S_LF < PL && S_HF > PH)) k++;

                } while (!(S_LF < PL && S_HF > PH) && k < Nc);
                if (k < Nc) count++;
            }

            return count / 8;
        }
    }
}
