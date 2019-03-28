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
        /// <summary>
        /// Family Node data that consists of husband, wife, children, ....
        /// </summary>
        private Family _node;

        /// <summary>
        /// Indicates if parents are visible.
        /// </summary>
        private bool _parentVisible;

        public Family Node
        {
            get => _node;
            set
            {
                _node = value;
                Represent();
            }
        }
        
        [Description("ParentVisible"), Category("Design")]
        public bool ParentVisible
        {
            get => _parentVisible;
            set
            {
                _parentVisible = value;
                Represent();
            }
        }

        public FamilyTreeNode()
        {
            InitializeComponent();
        }

        private void Represent()
        {
            pbFather.Visible = pbMother.Visible = ParentVisible;

            if (Node != null)
            {
                
            }
        }

        private void FamilyTreeNode_Validated(object sender, EventArgs e)
        {
            Represent();
        }
    }
}
