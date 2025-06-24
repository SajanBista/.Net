using System;
using System.Drawing;
using System.Windows.Forms;

public delegate void DelEventHandler();

namespace EventWithButton
{
    public class Program : Form
    {
        public event DelEventHandler add;

        public Program()
        {
            // Create a button
            Button btn = new Button();
            btn.Text = "Click Me!";
            btn.Location = new Point(100, 100);
            btn.Size = new Size(100, 50);

            // Subscribe a method to the button's Click event
            btn.Click += Btn_Click;

            // Add the button to the form
            Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // Raise the custom event when button is clicked
            add?.Invoke();
        }

        // Custom event handler method
        public void ShowMessage()
        {
            MessageBox.Show("Button was clicked and event was raised!");
        }

        [STAThread]
        static void Main()
        {
            Program form = new Program();

            // Subscribing the event handler
            form.add += form.ShowMessage;

            Application.Run(form);
        }
    }
}
