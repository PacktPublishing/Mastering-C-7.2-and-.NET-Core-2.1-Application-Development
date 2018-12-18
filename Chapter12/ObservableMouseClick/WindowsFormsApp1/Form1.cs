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

            // subscribe to the observable
            var clicksSubscription = clicks.Subscribe(evt =>
            {
                lblX.Text =$"X is {evt.EventArgs.Location.X}";
                lblY.Text =$"Y is {evt.EventArgs.Location.Y}";
            });
        }
    }
}
