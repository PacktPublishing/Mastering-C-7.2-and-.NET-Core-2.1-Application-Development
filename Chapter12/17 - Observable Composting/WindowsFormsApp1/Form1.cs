using System;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // define the events to capture
            var clicks = Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>
                (handler => MouseClick += handler, handler => MouseClick -= handler);

            var moves = Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>
               (handler => MouseMove += handler, handler => MouseMove -= handler);

            // Subscribe to the clicks
            clicks.Subscribe(evt =>
            {
                lblX.Text = $"X is {evt.EventArgs.Location.X}";
                lblY.Text = $"Y is {evt.EventArgs.Location.Y}";
            });

            // Subscribe to the mouse moves
            moves.Subscribe(evt =>
            {
                lblXD.Text = $"X is {evt.EventArgs.Location.X}";
                lblYD.Text = $"Y is {evt.EventArgs.Location.Y}";
            });
        }

    }
}
