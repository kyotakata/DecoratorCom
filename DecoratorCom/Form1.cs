using DecoratorCom.Messages;
using System.Windows.Forms;

namespace DecoratorCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var measureId = Convert.ToInt32(textBox1.Text);
            IMessage message = new MeasureMessage(measureId);
            Send(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var measureId = Convert.ToInt32(textBox1.Text);
            IMessage message = new StopMessage(measureId);
            Send(message);
        }

        /// <summary>
        /// ‹¤’Ê‰»
        /// </summary>
        /// <param name="message"></param>
        private void Send(IMessage message)
        {
            if (XORCheckBox.Checked)
            {
                message = new MessageDecoratorXOR(message);
            }

            if (ZipCheckBox.Checked)
            {
                message = new MessageDecoratorZip(message);
            }


            listBox1.Items.Add(string.Join("-", message.GetBytes()));

        }
    }
}