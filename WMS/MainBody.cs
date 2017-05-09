using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class MainBody : Form
    {
        public MainBody()
        {
            InitializeComponent();
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit aunittype = new AddUnit();
            aunittype.ShowDialog();
        }

        private void addWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWarehouse addwarehouse = new AddWarehouse();
            addwarehouse.ShowDialog();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoom addroom = new AddRoom();
            addroom.ShowDialog();
        }

        private void addCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCell addcell = new AddCell();
            addcell.ShowDialog();
        }
    }
}
