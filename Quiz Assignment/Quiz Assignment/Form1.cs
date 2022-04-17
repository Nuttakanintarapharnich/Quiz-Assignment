using System.Text;

namespace Quiz_Assignment
{
    public partial class Form1 : Form
    {
        calculasum calcucola = new calculasum();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text);



            string number = this.textBox2.Text;
            double numberd = Convert.ToDouble(number);
            string strbool = "รายรับ";
            string st1 = (string)comboBox1.SelectedItem;


            if (st1 == strbool)
            {
                calcucola.setn(numberd);//ดึงค่ากลับมา

                double nxxx = calcucola.getn();//คำตอบอยู nxxx

                this.textBox3.Text = nxxx.ToString();
            }
            else

            {
                calcucola.setng(numberd);//ดึงค่ากลับมา

                double ngxxx = calcucola.getng();//คำตอบอยู nxxx

                this.textBox4.Text = ngxxx.ToString();
            }





            //char ch1,answer = 'I';
            //ch1 = (char)comboBox1.SelectedIndex;

            // if (ch1 == answer)

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {// สร้างออบเจก จาก ไฟล์ไดอาลอก คลาส
                string strdata = string.Empty;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV(*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] readALLline = File.ReadAllLines(openFileDialog.FileName);

                    for (int i = 0; i < readALLline.Length; i++)
                    {
                        string studenraw = readALLline[i];
                        string[] studenSplied = studenraw.Split(',');
                        dataGridView1.Rows.Add(studenSplied);


                    }


                }



            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (dataGridView1.Rows.Count > 0)
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";

                        }
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";

                            }

                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }


        }

    }
}