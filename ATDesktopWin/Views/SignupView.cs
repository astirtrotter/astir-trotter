using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDesktopWin.Views
{
    public partial class SignupView : Form, IView
    {
        public string Title
        {
            get => Text;
            set => Text = value;
        }

        public Form Form => this;

    
        public SignupView()
        {
            InitializeComponent();
        }

    }
}
