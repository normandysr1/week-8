using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form, View
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }
        public void Notify(Model m)
        {
            int showScore = ((TwoZeroFourEightModel)m).getScore();
            lblScore.Text = showScore.ToString();
        }
    }
}
