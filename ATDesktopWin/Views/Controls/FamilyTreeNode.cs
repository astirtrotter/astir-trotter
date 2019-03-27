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
        public enum HusbandOrWife { Husband, Wife }

        /// <summary>
        /// Family Node data that consists of husband, wife, children, ....
        /// </summary>
        private Family _node;

        /// <summary>
        /// Indicates which parents are visible.
        /// </summary>
        private HusbandOrWife _parentVisible;

        /// <summary>
        /// Point between husband and wife. Used to draw lines in main family tree container.
        /// </summary>
        private Point _nodePoint;

        public Family Node
        {
            get => _node;
            set
            {
                _node = value;
                Represent();
            }
        }
        
        public Point NodePoint
        {
            get
            {
                if (_nodePoint == null)
                {
                    _nodePoint = new Point(Width / 2, Height - pbHusband.Height / 2);
                }
                return _nodePoint;
            }
        }

        [Description("ParentVisible"), Category("Design")]
        public HusbandOrWife ParentVisible
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
            bool hParentVisible = ParentVisible == HusbandOrWife.Husband;
            pbHusbandFather.Visible = pbHusbandMother.Visible = hParentVisible;
            pbWifeFather.Visible = pbWifeMother.Visible = !hParentVisible;

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
