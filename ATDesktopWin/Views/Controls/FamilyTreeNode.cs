using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATCommon.Models;

namespace ATDesktopWin.Views.Controls
{
    public partial class FamilyTreeNode : UserControl
    {
        private Family _node;
        private bool isHusbandParentVisible = true;

        internal Family Node
        {
            get => _node;
            set
            {
                _node = value;
                Refresh();
            }
        }

        internal bool HusbandParentVisible
        {
            get => isHusbandParentVisible;
            set
            {
                isHusbandParentVisible = value;
                Refresh();
            }
        }

        public FamilyTreeNode()
        {
            InitializeComponent();
        }


    }
}
