/// Basic analog clock to display the current time.
/// Created by: 
/// March 2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        // graphic objects for drawing clock
        Graphics g;
        Pen pen; 

        // clock radius
        readonly int RADIUS;

        // length of hands, second hand length is hypotenuse
        readonly int SEC_LEN, MIN_LEN, HOUR_LEN;

        // centre point of clock
        readonly Point CENTRE;

        // end points for clock hands
        Point secEndPoint, minEndPoint, hourEndPoint;

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();
            pen = new Pen(Color.Black);

            // set values for clock size and hand lengths

            // set centre of clock to centre of form

        }
        
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            // get the current time
            int currentSec = DateTime.Now.Second;
         
            // determine the theta measure for each hand
           
            // determine the end point for each hand

            // clear the screen and draw the clock

        }
    }
}
