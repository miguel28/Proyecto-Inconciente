using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemGameCore;

namespace LevelEditor
{
    public partial class diaLevelProperties : Form
    {
        public Level edLevel;
        public diaLevelProperties(Level level)
        {
            InitializeComponent();
            edLevel = level;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            edLevel.MapSize = new Size((int)numMapWidth.Value, (int)numMapHeight.Value);
            edLevel.GridSize = new Size((int)numGridWidth.Value, (int)numGridHeight.Value);
            edLevel.ResizeMap();
        }

    }
}
