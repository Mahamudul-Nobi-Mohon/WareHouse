namespace WMS
{
    partial class MainBody
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBody));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSettingsToolStripMenuItem,
            this.warehouseSettingsToolStripMenuItem,
            this.consumptionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemSettingsToolStripMenuItem
            // 
            this.itemSettingsToolStripMenuItem.Name = "itemSettingsToolStripMenuItem";
            this.itemSettingsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.itemSettingsToolStripMenuItem.Text = "Item Settings";
            // 
            // warehouseSettingsToolStripMenuItem
            // 
            this.warehouseSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWarehouseToolStripMenuItem,
            this.addRoomToolStripMenuItem,
            this.addCellToolStripMenuItem});
            this.warehouseSettingsToolStripMenuItem.Name = "warehouseSettingsToolStripMenuItem";
            this.warehouseSettingsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.warehouseSettingsToolStripMenuItem.Text = "Warehouse Settings";
            // 
            // addWarehouseToolStripMenuItem
            // 
            this.addWarehouseToolStripMenuItem.Name = "addWarehouseToolStripMenuItem";
            this.addWarehouseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addWarehouseToolStripMenuItem.Text = "Add Warehouse";
            this.addWarehouseToolStripMenuItem.Click += new System.EventHandler(this.addWarehouseToolStripMenuItem_Click);
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addRoomToolStripMenuItem.Text = "Add Room";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // addCellToolStripMenuItem
            // 
            this.addCellToolStripMenuItem.Name = "addCellToolStripMenuItem";
            this.addCellToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addCellToolStripMenuItem.Text = "Add Cell";
            this.addCellToolStripMenuItem.Click += new System.EventHandler(this.addCellToolStripMenuItem_Click);
            // 
            // consumptionToolStripMenuItem
            // 
            this.consumptionToolStripMenuItem.Name = "consumptionToolStripMenuItem";
            this.consumptionToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.consumptionToolStripMenuItem.Text = "Consumption";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // addUnitToolStripMenuItem
            // 
            this.addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            this.addUnitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addUnitToolStripMenuItem.Text = "Add Unit";
            this.addUnitToolStripMenuItem.Click += new System.EventHandler(this.addUnitToolStripMenuItem_Click);
            // 
            // MainBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1191, 604);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainBody";
            this.Text = "Ware House Management System 1.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCellToolStripMenuItem;
    }
}

