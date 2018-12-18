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
            var rawclicks = Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>
                (handler => MouseClick += handler, handler => MouseClick -= handler).Select(x => x.EventArgs.Location);

            var filteredClicks = from positions in rawclicks
                                 where positions.X > 50 && positions.Y > 50
                                 select positions;

            // subscribe to the observable
            var clicksSubscription = filteredClicks.Subscribe(evt =>
            {
                lblX.Text = $"X is {evt.X}";
                lblY.Text = $"Y is {evt.Y}";
            });
        }
    }
}
