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
            var moves = Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>
                (handler => MouseMove += handler, handler => MouseMove -= handler)
                .Select(x => x.EventArgs.Location)
                .Throttle(TimeSpan.FromSeconds(1));

            // subscribe to the observable
            var movesSubscription = moves.Subscribe(evt =>
            {
                lblX.Invoke((MethodInvoker)(() => lblX.Text = $"X is {evt.X}"));
                lblY.Invoke((MethodInvoker)(() => lblY.Text = $"Y is {evt.Y}"));
            });
        }
    }
}
