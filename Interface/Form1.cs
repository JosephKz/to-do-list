using toDoList;
namespace Interface
{
    public partial class Form1 : Form
    {
        private readonly taskManager _taskManager;
        public Form1() : this(new taskManager()) { }

        public Form1(taskManager manager)
        {
            _taskManager = manager;
            InitializeComponent();
            listBox1.Visible = false;
            button3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text?.Trim();
            if (!string.IsNullOrWhiteSpace(text))
            {
                _taskManager.AddTask(text);
                listBox1.Items.Add(text);
                textBox1.Clear();


            }
        }

        private bool clickOn = false;
        private void button2_Click(object sender, EventArgs e)
        {
            
            clickOn = !clickOn;
            if (clickOn)
            {
                button2.Text = "Hide Task";
                listBox1.Visible = true;
            }
            else
            {
                button2.Text = "View Tasks";
                listBox1.Visible = false;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
           
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
            {
                var item = listBox1.SelectedItem.ToString();
                _taskManager.RemoveTask(item);
                listBox1.Items.Remove(item);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
