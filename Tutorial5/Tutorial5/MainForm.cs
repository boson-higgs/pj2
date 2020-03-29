using MyAdt;
using System;
using System.Windows.Forms;

namespace Tutorial5
{
    public partial class MainForm : Form
    {
        private IStack stack;
        private IQueue queue;

        public MainForm()
        {
            InitializeComponent();

            this.stack = new MyStack(15);
            this.queue = new MyQueue(15);

            this.UpdateStackListBox();
            this.UpdateQueueListBox();
        }


        private void stackAddBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.stackNumberInput.Text, out int val))
            {
                this.stackNumberInput.Text = "";

                try
                {
                    this.stack.Push(val);
                }
                catch(Exception err)
                {
                    MessageBox.Show("Došlo k chybě: " + err.Message);
                }
                this.UpdateStackListBox();
            }
        }

        private void stackRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.stack.Pop();
            }
            catch (Exception err)
            {
                MessageBox.Show("Došlo k chybě: " + err.Message);
            }
            
            this.UpdateStackListBox();
        }


        private void UpdateStackListBox()
        {
            this.stackListBox.Items.Clear();
            foreach(int? element in this.stack.Elements)
            {
                this.stackListBox.Items.Add(element?.ToString() ?? "X");
            }
        }


        private void queueAddBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.queueNumberInput.Text, out int val))
            {
                this.queueNumberInput.Text = "";

                try
                {
                    this.queue.Add(val);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Došlo k chybě: " + err.Message);
                }
                
                this.UpdateQueueListBox();
            }
        }

        private void queueRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.queue.Get();
            }
            catch (Exception err)
            {
                MessageBox.Show("Došlo k chybě: " + err.Message);
            }
            this.UpdateQueueListBox();
        }

        private void UpdateQueueListBox()
        {
            this.queueListBox.Items.Clear();
            foreach (int? element in this.queue.Elements)
            {
                this.queueListBox.Items.Add(element?.ToString() ?? "X");
            }
        }


    }
}
