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
            this.LabelValueKpiSuccessful = new System.Windows.Forms.Label();
            this.LabelValueKpiRecovery = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.workToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.workToolStripMenuItem.Text = "Work";
            this.workToolStripMenuItem.Click += new System.EventHandler(this.workToolStripMenuItem_Click);
            // 
            // deploymentsToolStripMenuItem
            // 
            this.deploymentsToolStripMenuItem.Name = "deploymentsToolStripMenuItem";
            this.deploymentsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deploymentsToolStripMenuItem.Text = "Deployments";
            this.deploymentsToolStripMenuItem.Click += new System.EventHandler(this.deploymentsToolStripMenuItem_Click);
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
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
            this.LabelValueKpiLeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelValueKpiLeadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueKpiLeadTime.Location = new System.Drawing.Point(3, 16);
            this.LabelValueKpiLeadTime.Name = "LabelValueKpiLeadTime";
            this.LabelValueKpiLeadTime.Size = new System.Drawing.Size(404, 181);
            this.LabelValueKpiLeadTime.TabIndex = 0;
            this.LabelValueKpiLeadTime.Text = "LeadTimeValue";
            this.LabelValueKpiLeadTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelValueKpiDeployments
            // 
            this.LabelValueKpiDeployments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelValueKpiDeployments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueKpiDeployments.Location = new System.Drawing.Point(3, 16);
            this.LabelValueKpiDeployments.Name = "LabelValueKpiDeployments";
            this.LabelValueKpiDeployments.Size = new System.Drawing.Size(404, 181);
            this.LabelValueKpiDeployments.TabIndex = 2;
            this.LabelValueKpiDeployments.Text = "NumberOfDeploymentsValue";
            this.LabelValueKpiDeployments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelValueKpiSuccessful
            // 
            this.LabelValueKpiSuccessful.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelValueKpiSuccessful.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueKpiSuccessful.Location = new System.Drawing.Point(3, 16);
            this.LabelValueKpiSuccessful.Name = "LabelValueKpiSuccessful";
            this.LabelValueKpiSuccessful.Size = new System.Drawing.Size(404, 181);
            this.LabelValueKpiSuccessful.TabIndex = 3;
            this.LabelValueKpiSuccessful.Text = "SuccessfulChangesValue";
            this.LabelValueKpiSuccessful.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelValueKpiRecovery
            // 
            this.LabelValueKpiRecovery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelValueKpiRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueKpiRecovery.Location = new System.Drawing.Point(3, 16);
            this.LabelValueKpiRecovery.Name = "LabelValueKpiRecovery";
            this.LabelValueKpiRecovery.Size = new System.Drawing.Size(404, 181);
            this.LabelValueKpiRecovery.TabIndex = 4;
            this.LabelValueKpiRecovery.Text = "AverageRecoveryValue";
            this.LabelValueKpiRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LabelValueKpiLeadTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lead Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LabelValueKpiDeployments);
            this.groupBox2.Location = new System.Drawing.Point(462, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of Deployments";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LabelValueKpiSuccessful);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 200);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Successful Changes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.LabelValueKpiRecovery);
            this.groupBox4.Location = new System.Drawing.Point(462, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 200);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time to Recover";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lead time is a measure of how long it takes to deliver work to the customer. The " +
    "shorter the lead time the faster the team can deliver value to their clients.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many deployments has the team completed? The more deployments the smaller the" +
    " work is broken down and the smaller the deltas and risk or failure.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "What percentage of the deployments the team has made have been successful?";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "When failure does occour how long does it take to recover service?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "KPI Accelerator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Label LabelValueKpiSuccessful;
        private System.Windows.Forms.Label LabelValueKpiRecovery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

