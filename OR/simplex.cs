using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OR
{
    public partial class simplex : Form
    {
        private int number_of_variables, number_of_constraints;
        private double[,] matrix;
        private ArrayList string_c;
        private ArrayList string_r;
        private int x, y;
        public simplex()
        {
            InitializeComponent();
        }

        private void simplex_Load(object sender, EventArgs e)
        {

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                number_of_variables = int.Parse(textBoxNumberOfVariables.Text);
                number_of_constraints = int.Parse(textBoxNumberOfConstraints.Text);
                if (number_of_variables < 1 || number_of_constraints < 1 || number_of_variables > 10 || number_of_constraints > 10)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Incorrect value!");
                this.Close();
            }

            Controls.Clear();

            Controls.Add(pictureBox1);

            x = 30;
            y = 30;

            Label label_coef = new Label();
            label_coef.Text = "Objective function to maximize:";
            label_coef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_coef.ForeColor = System.Drawing.Color.Teal; 
            label_coef.AutoSize = true;
            label_coef.Location = new System.Drawing.Point(x, y);
            Controls.Add(label_coef);

            y += 60;
            x = 30;

            for (int i = 0; i < number_of_variables; i++)
            {
                TextBox txtbx = new TextBox();
                txtbx.Location = new System.Drawing.Point(x + 20, y);
                txtbx.Name = "txtbxFuncCoef" + i;
                txtbx.MaxLength = 3;
                txtbx.Size = new System.Drawing.Size(20, 20);
                Controls.Add(txtbx);

                x += 40;

                Label lab = new Label();
                lab.Location = new System.Drawing.Point(x, y + 3);
                lab.Size = new System.Drawing.Size(20, 20);
                lab.Text = "x" + (i + 1);
                Controls.Add(lab);

                x += 10;
            }

            Label lab1 = new Label();
            lab1.Location = new System.Drawing.Point(x + 10, y + 3);
            lab1.Size = new System.Drawing.Size(20, 20);
            lab1.Text = "=";
            Controls.Add(lab1);

            x += 10;

            TextBox txtbx2 = new TextBox();
            txtbx2.Location = new System.Drawing.Point(x + 20, y);
            txtbx2.Name = "txtbxFuncRhs";
            txtbx2.Text = "0";
            txtbx2.MaxLength = 3;
            txtbx2.Size = new System.Drawing.Size(20, 20);
            Controls.Add(txtbx2);

            y += 60;

            Label label_const = new Label();
            label_const.Text = "Constraints:";
            label_const.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_const.ForeColor = System.Drawing.Color.Teal;
            label_const.Location = new System.Drawing.Point(30, y);
            Controls.Add(label_const);

            y += 60;
            x = 30;

            for (int i = 0; i < number_of_constraints; i++)
            {
                for (int j = 0; j < number_of_variables; j++)
                {
                    TextBox txtbx = new TextBox();
                    txtbx.Location = new System.Drawing.Point(x + 20, y);
                    txtbx.Name = "txtbxConst" + (i * number_of_variables + j);
                    txtbx.MaxLength = 3;
                    txtbx.Size = new System.Drawing.Size(20, 20);
                    Controls.Add(txtbx);

                    x += 40;

                    Label lab = new Label();
                    lab.Location = new System.Drawing.Point(x, y + 3);
                    lab.Size = new System.Drawing.Size(20, 20);
                    lab.Text = "x" + (j + 1);
                    Controls.Add(lab);

                    x += 10;
                }

                Label lab2 = new Label();
                lab2.Location = new System.Drawing.Point(x + 10, y + 3);
                lab2.Size = new System.Drawing.Size(20, 20);
                lab2.Text = "<=";
                Controls.Add(lab2);

                TextBox txtbx3 = new TextBox();
                txtbx3.Location = new System.Drawing.Point(x + 30, y);
                txtbx3.Name = "txtbxConstRhs" + i;
                txtbx3.MaxLength = 3;
                txtbx3.Size = new System.Drawing.Size(20, 20);
                Controls.Add(txtbx3);

                y += 60;
                x = 30;
            }

            y += 10;
            Button butSolve = new Button();
            butSolve.Location = new System.Drawing.Point(x + 90, y);
            butSolve.Name = "butSolve";
            butSolve.Text = "Solve!";
            Controls.Add(butSolve);
            butSolve.Click += new System.EventHandler(this.butSolve_Click);
        }

        private void butSolve_Click(object sender, EventArgs e)
        {
            matrix = new double[number_of_constraints + 1, number_of_variables + number_of_constraints + 1];

            try
            {
                for (int i = 0; i < number_of_variables; i++)
                {
                    matrix[0, i] = -1 * double.Parse(Controls.Find("txtbxFuncCoef" + i, false)[0].Text);
                }
            }
            catch
            {
                MessageBox.Show("Incorrect value!");
                this.Close();
            }

            for (int i = number_of_variables; i < number_of_variables + number_of_constraints; i++)
            {
                matrix[0, i] = 0;
            }

            Control[] funcRhs = Controls.Find("txtbxFuncRhs", false);
            try
            {
                matrix[0, number_of_variables + number_of_constraints] = double.Parse(funcRhs[0].Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value!");
                this.Close();
            }

            try
            {
                for (int i = 1; i < number_of_constraints + 1; i++)
                {
                    for (int j = 0; j < number_of_variables; j++)
                    {
                        matrix[i, j] = double.Parse(Controls.Find("txtbxConst" + ((i - 1) * number_of_variables + j), false)[0].Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect value!");
                this.Close();
            }

            for (int i = 1; i < number_of_constraints + 1; i++)
            {
                for (int j = number_of_variables; j < number_of_variables + number_of_constraints; j++)
                {
                    if (j - number_of_variables + 1 == i) matrix[i, j] = 1;
                    else matrix[i, j] = 0;
                }
            }

            try
            {
                for (int i = 1; i < number_of_constraints + 1; i++)
                {
                    double n = double.Parse(Controls.Find("txtbxConstRhs" + (i - 1), false)[0].Text);
                    if (n < 0) throw new Exception();
                    matrix[i, number_of_variables + number_of_constraints] = n;
                }
            }
            catch
            {
                MessageBox.Show("Incorrect value!");
                this.Close();
            }

            string_c = new ArrayList();
            for (int i = 0; i < number_of_constraints; i++)
            {
                string str = "s" + (i + 1);
                string_c.Add(str);
            }

            string_r = new ArrayList();
            for (int i = 0; i < number_of_variables + number_of_constraints; i++)
            {
                if (i >= number_of_variables)
                {
                    string str = "s" + (i - number_of_variables + 1);
                    string_r.Add(str);
                }
                else
                {
                    string str = "x" + (i + 1);
                    string_r.Add(str);
                }
            }

            Controls.Clear();
            Controls.Add(pictureBox1);

            x = 0;
            y = 0;

        label1: PrintTable();

            if (IsOptimal())
            {
                y += 30;
                for (int i = 1; i < number_of_constraints + 1; i++)
                {
                    Label lab2 = new Label();
                    lab2.Location = new System.Drawing.Point(x, y);
                    lab2.AutoSize = true;
                    lab2.Text = (string)string_c[i - 1] + " = " + matrix[i, number_of_variables + number_of_constraints];
                    Controls.Add(lab2);

                    y += 30;
                }


                Label lab = new Label();
                lab.Location = new System.Drawing.Point(x, y);
                lab.AutoSize = true;
                lab.Text = "z(max) = " + matrix[0, number_of_variables + number_of_constraints];
                Controls.Add(lab);

                y += 30;
            }
            else
            {
                int guiding_column = FindGuidingColumn();
                int guiding_row = FindGuidingRow(guiding_column);

                Label lab = new Label();
                lab.Location = new System.Drawing.Point(x, y);
                lab.AutoSize = true;
                lab.Text = "Guiding element:" + matrix[guiding_row, guiding_column];
                Controls.Add(lab);

                y += 30;

                MakeNewGuidingRow(guiding_row, matrix[guiding_row, guiding_column]);
                RecalculationOfTable(guiding_row, guiding_column);
                goto label1;
            }
        }

        private void PrintTable()
        {
            x += 30;
            for (int j = 0; j < number_of_constraints + number_of_variables + 1; j++)
            {
                if (j == number_of_variables + number_of_constraints)
                {
                    Label lab2 = new Label();
                    lab2.Location = new System.Drawing.Point(x, y);
                    lab2.AutoSize = true;
                    lab2.Text = "RHS";
                    Controls.Add(lab2);

                    x = 0;
                }
                else
                {
                    Label lab2 = new Label();
                    lab2.Location = new System.Drawing.Point(x, y);
                    lab2.Size = new System.Drawing.Size(20, 20);
                    lab2.Text = (string)string_r[j];
                    Controls.Add(lab2);

                    x += 30;
                }
            }

            y += 30;

            for (int i = 0; i < number_of_constraints + 1; i++)
            {
                for (int j = 0; j < number_of_constraints + number_of_variables + 2; j++)
                {
                    if (j == 0)
                    {
                        if (i == 0)
                        {
                            Label lab2 = new Label();
                            lab2.Location = new System.Drawing.Point(x, y);
                            lab2.Size = new System.Drawing.Size(20, 20);
                            lab2.Text = "z";
                            Controls.Add(lab2);

                            x += 30;
                        }
                        else
                        {
                            Label lab2 = new Label();
                            lab2.Location = new System.Drawing.Point(x, y);
                            lab2.Size = new System.Drawing.Size(20, 20);
                            lab2.Text = (string)string_c[i - 1];
                            Controls.Add(lab2);

                            x += 30;
                        }
                    }
                    else
                    {
                        Label lab2 = new Label();
                        lab2.Location = new System.Drawing.Point(x, y);
                        lab2.AutoSize = true;
                        lab2.Size = new System.Drawing.Size(20, 20);
                        lab2.Text = matrix[i, j - 1].ToString();
                        Controls.Add(lab2);

                        x += 30;
                    }
                }
                y += 30;
                x = 0;
            }
        }

        bool IsOptimal()
        {
            for (int j = 0; j < number_of_constraints + number_of_variables + 1; j++)
            {
                if (matrix[0, j] < 0) return false;
            }
            return true;
        }

        int FindGuidingColumn()
        {
            double min = -0.000000000001;
            int num = 0;

            for (int j = 0; j < number_of_constraints + number_of_variables; j++)
            {
                if (matrix[0, j] < min)
                {
                    min = matrix[0, j];
                    num = j;
                }
            }
            return num;
        }

        int FindGuidingRow(int guidingColumn)
        {
            double min = int.MaxValue;
            int num = 0;

            for (int i = 1; i < number_of_constraints + 1; i++)
            {
                if (matrix[i, guidingColumn] > 0)
                {
                    if (matrix[i, number_of_constraints + number_of_variables] / matrix[i, guidingColumn] < min)
                    {
                        min = matrix[i, number_of_constraints + number_of_variables] / matrix[i, guidingColumn];
                        num = i;
                    }
                }
            }
            return num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void MakeNewGuidingRow(int guidingRow, double guidingElement)
        {
            for (int j = 0; j < number_of_constraints + number_of_variables + 1; j++)
            {
                matrix[guidingRow, j] /= guidingElement;
            }
        }

        void RecalculationOfTable(int guiding_row, int guiding_column)
        {
            string_c[guiding_row - 1] = string_r[guiding_column];

            for (int i = 0; i < number_of_constraints + 1; i++)
            {
                if (matrix[i, guiding_column] != 0)
                {
                    if (i == guiding_row)
                    {
                        continue;
                    }

                    double[] row = new double[number_of_variables + number_of_constraints + 1];
                    for (int j = 0; j < number_of_variables + number_of_constraints + 1; j++)
                    {
                        row[j] = matrix[guiding_row, j];
                    }

                    for (int j = 0; j < number_of_variables + number_of_constraints + 1; j++)
                    {
                        row[j] *= matrix[i, guiding_column];
                    }

                    for (int j = 0; j < number_of_variables + number_of_constraints + 1; j++)
                    {
                        matrix[i, j] -= row[j];
                    }
                }
            }
        }
    }
}
