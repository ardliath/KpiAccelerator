namespace KpiAccelerator
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateKPIDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deploymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelValueKpiLeadTime = new System.Windows.Forms.Label();
            this.LabelValueKpiDeployments = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateKPIDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateKPIDataToolStripMenuItem
            // 
            this.updateKPIDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workToolStripMenuItem,
            this.deploymentsToolStripMenuItem,
            this.incidentsToolStripMenuItem});
            this.updateKPIDataToolStripMenuItem.Name = "updateKPIDataToolStripMenuItem";
            this.updateKPIDataToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.updateKPIDataToolStripMenuItem.Text = "Update KPI Data";
            // 
            // workToolStripMenuItem
            // 
            this.workToolStripMenuItem.Name = "workToolStripMenuItem";
            this.workToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.workToolStripMenuItem.Text = "Work";
            this.workToolStripMenuItem.Click += new System.EventHandler(this.workToolStripMenuItem_Click);
            // 
            // deploymentsToolStripMenuItem
            // 
            this.deploymentsToolStripMenuItem.Name = "deploymentsToolStripMenuItem";
            this.deploymentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deploymentsToolStripMenuItem.Text = "Deployments";
            this.deploymentsToolStripMenuItem.Click += new System.EventHandler(this.deploymentsToolStripMenuItem_Click);
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incidentsToolStripMenuItem.Text = "Incidents";
            this.incidentsToolStripMenuItem.Click += new System.EventHandler(this.incidentsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LabelValueKpiLeadTime
            // 
            this.LabelValueKpiLeadTime.AutoSize = true;
            this.LabelValueKpiLeadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueKpiLeadTime.Location = new System.Drawing.Point(40, 68);
            this.LabelValueKpiLeadTime.Name = "LabelValueKpiLeadTime";
            this.LabelValueKpiLeadTime.Size = new System.Drawing.Size(120, 20);
            this.LabelValueKpiLeadTime.TabIndex = 0;
            this.LabelValueKpiLeadTime.Text = "LeadTimeValue";
            // 
            // LabelValueKpiDeployments
            // 
            this.LabelValueKpiDeployments.AutoSize = true;
            this.LabelValueKpiDeployments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueKpiDeployments.Location = new System.Drawing.Point(537, 68);
            this.LabelValueKpiDeployments.Name = "LabelValueKpiDeployments";
            this.LabelValueKpiDeployments.Size = new System.Drawing.Size(216, 20);
            this.LabelValueKpiDeployments.TabIndex = 2;
            this.LabelValueKpiDeployments.Text = "NumberOfDeploymentsValue";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.LabelValueKpiDeployments);
            this.Controls.Add(this.LabelValueKpiLeadTime);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "KPI Accelerator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LabelValueKpiLeadTime;
        private System.Windows.Forms.ToolStripMenuItem updateKPIDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deploymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentsToolStripMenuItem;
        private System.Windows.Forms.Label LabelValueKpiDeployments;
    }
}

