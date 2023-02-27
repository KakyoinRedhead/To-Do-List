namespace ToDOList
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VytvorToDoList();
        }

        private void VytvorToDoList()
        {
            Listukolu ukolList = new Listukolu(textBox1.Text);
            flowLayoutPanel1.Controls.Add(ukolList);
        }
    }
}