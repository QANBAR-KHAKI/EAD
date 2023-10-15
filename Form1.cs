using System.Windows.Forms;

namespace form_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String chck = checkBox1.CheckState.ToString();
            String fname = textBox1.Text;
            String lname = textBox2.Text;
            String r = "";
            List<String> subject_list = comboBox1.Items.Cast<String>().ToList();

            if (string.IsNullOrWhiteSpace(fname))
            {
                MessageBox.Show("Please enter a non-empty fitst name.", "Input Error");
                return;
            }
            else if (string.IsNullOrWhiteSpace(lname))
            {
                MessageBox.Show("Please enter a non-empty Last name.", "Input Error");
                return;
            }
            else if (subject_list.Count < 2)
            {
                MessageBox.Show("You must have to to select at least 2 subjects\n");
                return;
            }
            else if (!checkBox1.Checked)
            {
                MessageBox.Show("You must should accept the Privacy and Policies\n");
                return;
            }
            else
            {
                r = String.Join(", ", subject_list);


            }

            label5.Text = $"First Name : {fname} \n Second Name : {lname}\n Selected Subjects :{r}\n";

        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var selected in listBox1.SelectedItems)
            {
                comboBox1.Items.Add(selected.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}