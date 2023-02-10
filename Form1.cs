using System;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace Gaus
{
    
    public partial class Gaus : Form
    {
        private TextBox[,] tb;
        private Label[,] lb;
        private string filename;
        private string printer = "";
        bool activated = true;
        bool stop = true;
        public string calc;
        public string bigMatrix = "bigMatrix.txt";


        public static class Matrix
        {
            public static int count;
            public static double[,] matrix;
            public static double[] y;
            public static double[] result;

            public static void MatrixDex()
            {
                count = 0;
            }

        }
        public Gaus()
        {
            InitializeComponent();
        }

        private void Gaus_Load(object sender, EventArgs e)
        {
            delete.Enabled = false;
           // File.WriteAllText(calc, string.Empty);
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp;
            Matrix.matrix = new double[(int)numericUpDown1.Value, (int)numericUpDown1.Value];
            Matrix.y = new double[(int)numericUpDown1.Value];
            Matrix.result = new double[(int)numericUpDown1.Value];

            if (Matrix.count == 0)
            {
                MessageBox.Show("Ошибка, размер матрциы = 0");
                return;
            }

            if (tb == null)
            {
                MessageBox.Show("Ошибка, введите количество уравнения");
                return;
            }

            // ПУСТЫЕ ТЕКСТБОКСЫ
            for (int i = 0; i < Matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.matrix.GetLength(1); j++)
                {
                    if (tb.GetLength(0) < (int)numericUpDown1.Value)
                    {
                        MessageBox.Show("Ошибка, количество уравнений не совпадает");
                        return;
                    }

                    if (tb[i, j].Text == "")
                    {
                        MessageBox.Show("Ошибка, введите коэффициенты!");
                        return;
                    }
                }
            }

            for (int i = 0; i < Matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.matrix.GetLength(1); j++)
                {
                    tmp = tb[i, j].Text;
                   /* for (int c = 0; c < tb[i, j].Text.Length; c++)
                    {
                        if (tmp[c] < '0' || tmp[c] > '9' || tmp[c] == ',')
                        {
                            MessageBox.Show("Ошибка, введите число!");
                            return;
                        }
                    }*/
                    try
                    {
                        Matrix.matrix[i, j] = Convert.ToDouble(tmp);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка, введите число!");
                    }
                }
            }
            for (int i = 0; i < tb.GetLength(0); i++)
            {
                try
                {
                    Matrix.y[i] = Convert.ToDouble(tb[i, tb.GetLength(0)].Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка, введите число!");
                }
            }

            Matrix.result = gaus();

        }
        string notSolution = "";
        string multSolution = "";
        string file = "";

        //метод Гаусса
        private double[] gaus()
        {
            
            double maximum;
            int colums_index;
            int k;
            const double q = 0.00001;
            /*try
            {
                File.WriteAllText(calc, file);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }*/
            for (k = 0; k < Matrix.matrix.GetLength(0); k++)
            {

                maximum = Math.Abs(Matrix.matrix[k, k]);
                file += maximum.ToString() + Environment.NewLine;
                colums_index = k;
                for (int i = k + 1; i < Matrix.matrix.GetLength(0); i++)
                {
                    if (Math.Abs(Matrix.matrix[i, k]) > maximum)
                    {
                        maximum = Math.Abs(Matrix.matrix[i, k]);
                        colums_index = i;
                    }
                }

                if (maximum < q)
                {
                    notSolution += "Нет решений";
                    return Matrix.result;
                }

                file += "меняем строку с максимальным коэффициентом с первой строкой" + Environment.NewLine; 
                for (int j = 0; j < Matrix.matrix.GetLength(0); j++)       // меняем строку с максимальным коэффициентом с первой строкой
                {
                    double temporary = Matrix.matrix[k, j];
                    Matrix.matrix[k, j] = Matrix.matrix[colums_index, j];
                    Matrix.matrix[colums_index, j] = temporary;
                    file += Matrix.matrix[colums_index, j].ToString() + Environment.NewLine;
                }
                double temp = Matrix.y[k];
                Matrix.y[k] = Matrix.y[colums_index];
                Matrix.y[colums_index] = temp;
                file += Matrix.y[colums_index].ToString() + Environment.NewLine;

                file += "нормируем относительно первого коэффициента" + Environment.NewLine;
                for (int i = k; i < Matrix.matrix.GetLength(0); i++)
                {
                    double temp1 = Matrix.matrix[i, k];

                    for (int j = k; j < Matrix.matrix.GetLength(0); j++)     // нормируем относительно первого коэффициента
                    {
                        Matrix.matrix[i, j] = Matrix.matrix[i, j] / temp1;
                        file += Matrix.y[colums_index].ToString() + Environment.NewLine;
                    }

                    Matrix.y[i] = Matrix.y[i] / temp1;
                    file += Matrix.y[i].ToString() + Environment.NewLine;

                    if (i == k) continue;      // не вычитать уравнение из самого себя

                    file += "вычитаем уравнения" + Environment.NewLine;
                    for (int j = 0; j < Matrix.matrix.GetLength(0); j++)     // вычитаем уравнения 
                    {
                        Matrix.matrix[i, j] = Matrix.matrix[i, j] - Matrix.matrix[k, j];
                        file += Matrix.matrix[i, j].ToString() + Environment.NewLine;
                    }

                    Matrix.y[i] = Matrix.y[i] - Matrix.y[k];
                    file += Matrix.y[i].ToString() + Environment.NewLine;
                }
                file += Environment.NewLine;
            }

            /*int size = 0;
            for (int c = 0; c < Matrix.y.GetLength(0); c++)     // проверка на совместимость
            {

                if (Matrix.matrix[k - 1, c] < q || Double.IsNaN(Matrix.matrix[Matrix.matrix.GetLength(0) - 1, c]))
                {
                    size++;
                }
                if(Matrix.y[c] == double.PositiveInfinity || Matrix.y[c] == double.NegativeInfinity)
                {
                    Matrix.y[c] = 0;
                }
                if (size == Matrix.count && Matrix.y[c] < q)
                {
                    multSolution += "Нет решений в числах" + Environment.NewLine;
                    //return Matrix.result;
                }
            }*/

            /*if (multSolution != "")
            {

                return Matrix.result;
            }*/
            file += "обратная подстановка" + Environment.NewLine;
            for (k = Matrix.matrix.GetLength(0) - 1; k >= 0; k--)      // обратная подстановка
            {
                Matrix.result[k] = Math.Round(Matrix.y[k], 2);
                file += Matrix.result[k].ToString() + Environment.NewLine;

                for (int i = 0; i < k; i++)
                {
                    Matrix.y[i] -= Matrix.matrix[i, k] * Matrix.result[k];
                    file += Matrix.y[i].ToString() + Environment.NewLine;
                }
            }

            return Matrix.result;
        }


        private async Task OutputTextboxAsync()
        {
            stop = true;
            try
            {
                for (int i = 0; i < tb.GetLength(0); i++)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        progressBar1.Value = i + 1;
                    });
                    for (int j = 0; j < tb.GetLength(1); j++)
                    {

                        Invoke((MethodInvoker)delegate
                        {
                            if (!stop)
                            {
                                return;
                            }
                            Controls.Add(tb[i, j] = new TextBox() { Location = new Point(90 + (j * 75), 115 + i * 50), Size = new Size(40, 20), Text = null });
                            Controls.Add(lb[i, j] = new Label() { Location = new Point(131 + (j * 75), 117 + i * 50), Size = new Size(35, 20) });
                            if (j == tb.GetLength(1) - 2)
                            {
                                lb[i, j].Text = $"x{j + 1}=";
                                j++;
                                Controls.Add(tb[i, j] = new TextBox() { Location = new Point(110 + ((j) * 75), 115 + i * 50), Size = new Size(40, 20), Text = null });
                                Controls.Add(lb[i, j] = new Label() { Location = new Point(151 + (j * 75), 117 + i * 50), Size = new Size(45, 20) });
                                //continue;
                            }
                            else
                            {
                                lb[i, j].Text = $"x{j + 1}+";
                                Controls.Add(lb[i, j]);
                            }
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private async Task WriteBigMatrixAsync()
        {
            stop = true;
            File.WriteAllText(bigMatrix, "\n");
            Matrix.matrix = new double[(int)numericUpDown1.Value, (int)numericUpDown1.Value];
            Matrix.y = new double[(int)numericUpDown1.Value];
            Matrix.result = new double[(int)numericUpDown1.Value];
            Random rand = new Random();
            
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = i + 1;
                });
                for (int j = 0; j < (int)numericUpDown1.Value; j++)
                {
                    if (!stop)
                    {
                        return;
                    }

                    Matrix.matrix[i, j] = rand.Next(-100, 100);
                    File.AppendAllText(bigMatrix, Matrix.matrix[i, j].ToString() + " ");
                }
                Matrix.y[i] = rand.Next(-100, 100);
                File.AppendAllText(bigMatrix, Matrix.y[i].ToString());
                File.AppendAllText(bigMatrix, Environment.NewLine);
            }
            Matrix.result = gaus();
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                File.AppendAllText(bigMatrix, Matrix.result[i].ToString() + Environment.NewLine);
            }
        }

        private async void SLAU_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                activated = false;
                if (!activated)
                {
                    SLAU.Enabled = false;
                    delete.Enabled = true;
                }
                Matrix.count = (int)numericUpDown1.Value;
                tb = new TextBox[Matrix.count, Matrix.count + 1];
                lb = new Label[Matrix.count, Matrix.count + 1];
                progressBar1.Maximum = tb.GetLength(0);
                await Task.Run(() => OutputTextboxAsync());
            }
            else
            {
                progressBar1.Maximum = (int)numericUpDown1.Value;
                await Task.Run(() => WriteBigMatrixAsync());
            }
        }

        private async Task deleteAsync()
        {
            stop = true;
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    progressBar1.Maximum = tb.GetLength(0);
                });
                    for (int i = 0; i < tb.GetLength(0); i++)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value = i + 1;
                        });
                        for (int j = 0; j < tb.GetLength(1); j++)
                        {
                            if (!stop)
                            {
                                return;
                            }
                        Invoke((MethodInvoker)delegate
                            {
                                this.Controls.Remove(tb[i, j]);
                                this.Controls.Remove(lb[i, j]);
                            });
                        }
                    }
                    Matrix.count = 0;
                    multSolution = "";
                    notSolution = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            //await deleteAsync();
            
            activated = false;
            
            if (!activated)
            {
                SLAU.Enabled = true;
                delete.Enabled = false;
            }
            await Task.Run(() => deleteAsync());
        }

        private void methodGaus_Click_1(object sender, EventArgs e)
        {
            //Matrix.result = method();
            string str = "";
            if(notSolution != "")
            {
                MessageBox.Show(notSolution);
                return;
            }

            if (tb == null)
            {
                MessageBox.Show("Ошибка, необходимо добавить СЛАУ");
                return;
            }

            if (multSolution != "")
            {
                for (int i = 0; i < Matrix.result.GetLength(0); i++)
                {
                    multSolution += $"x{i + 1} = ";
                    multSolution += Matrix.result[i].ToString() + " ";
                    multSolution += Environment.NewLine;
                }
                MessageBox.Show(multSolution);
                return;
            }

            if(Matrix.matrix == null)
            {
                MessageBox.Show("Ошибка, сначала необходимо применить метод");
                return;
            }

            for(int i = 0; i < Matrix.matrix.GetLength(0); i++)
            {
                for(int j = 0; j < Matrix.matrix.GetLength(1); j++)
                {
                    if (Matrix.matrix[i, j].ToString() == "")
                    {
                        MessageBox.Show("Ошибка, сначала необходимо применить метод");
                        return;
                    }
                }
            }

            for (int i = 0; i < Matrix.result.GetLength(0); i++)
            {
                str += $"x{i + 1} = ";
                str += Matrix.result[i].ToString() + " ";
                str += Environment.NewLine;
            }

            if (delete.Enabled == false)
            {
                str = "Вы удалили матрицу";
                MessageBox.Show(str);
                return;
            }
            MessageBox.Show(str);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                try
                {
                    string[] s = File.ReadAllLines(filename);
                    if (tb == null)
                    {
                        MessageBox.Show("Создайте нужное количество уравнений");
                        return;
                    }
                    for (int i = 0; i < tb.GetLength(0); i++)
                    {
                        string[] str = s[i].Trim().Split(' ');
                        for (int j = 0; j < tb.GetLength(1); j++)
                        {
                            tb[i, j].Text = (str[j].Trim());
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Файл " + filename + " недопустимый формат");
                    return;
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (tb == null)
                    {
                        MessageBox.Show("Добавьте СЛАУ и решите их");
                        return;
                    }
                    string str = "";    
                    str += Environment.NewLine;
                    str += "Ответ: ";
                    str += Environment.NewLine;
                    if (notSolution != "")
                    {
                        File.AppendAllText(filename, notSolution);
                        return;
                    }
                    for (int i = 0; i < Matrix.result.GetLength(0); i++)
                    {
                        str += $"x{i + 1} = ";
                        str += Matrix.result[i].ToString() + " ";
                        str += Environment.NewLine;
                    }
                    File.AppendAllText(filename, str);
                }
                catch
                {
                    MessageBox.Show("недопустимый формат" + Environment.NewLine + "Сначала считайте матрицу из файла");
                }
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            if(tb == null)
            {
                MessageBox.Show("Ошибка, необходимо добавить СЛАУ");
                return;
            }

            progressBar1.Maximum = tb.GetLength(0);
            Random rand = new Random();
            try
            {
                for (int i = 0; i < tb.GetLength(0); i++)
                {
                    progressBar1.Value = i + 1;
                    for (int j = 0; j < tb.GetLength(1); j++)
                    {
                        if (tb[i, j] == null)
                        {
                            MessageBox.Show("Дождитесь создания матрицы");
                            return;
                        }
                        tb[i, j].Text = rand.Next(-100, 100).ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process process = new())
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = @"help.txt";
                    process.Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printer += "                                   Решение СЛАУ методом Гаусса";
            printer += Environment.NewLine;
            printer += Environment.NewLine;
            for (int i = 0; i < tb.GetLength(0); i++)
            {
                for (int j = 0; j < tb.GetLength(1); j++)
                {
                    printer += tb[i, j].Text + lb[i, j].Text + " ";
                }
                printer += Environment.NewLine;
                printer += Environment.NewLine; 
            }

            printer += Environment.NewLine;
            printer += "Ответ: ";
            printer += Environment.NewLine;
            printer += Environment.NewLine;
            for (int i = 0; i < Matrix.result.GetLength(0); i++)
            {
                printer += $"x{i + 1} = ";
                printer += Matrix.result[i].ToString() + " ";
                printer += Environment.NewLine;
            }
            
            //MessageBox.Show(printer);

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics.MeasureString(printer, new Font("Times New Roman", 14)).Width > 800)
            {
                printer += Environment.NewLine;
            }
            e.Graphics.DrawString(printer, new Font("Times New Roman", 14), Brushes.Black, 50, 40);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop = false;
        }

        private void calculationLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                calc = openFileDialog1.FileName;
                try
                {
                    
                }
                catch
                {
                    MessageBox.Show("Файл " + calc + " недопустимый формат");
                    return;
                }
            }*/
            if (calc == null)
            {
                MessageBox.Show("Сначала необходимо записать в файл");
                return;
            }
            try
            {
                using (Process process = new())
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = calc;
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void writeCalculatiobLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                calc = saveFileDialog1.FileName;
                try
                {
                    File.WriteAllText(calc, file);
                }
                catch
                {
                    MessageBox.Show("Файл " + calc + " недопустимый формат");
                    return;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bigMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process process = new())
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = bigMatrix;
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}