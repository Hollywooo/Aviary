namespace Aviary
{
    partial class GUIFormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIFormMain));
            this.buttonLoadROs = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLoadAnalytical = new System.Windows.Forms.Button();
            this.buttonPerformComp = new System.Windows.Forms.Button();
            this.buttonExportToCSV = new System.Windows.Forms.Button();
            this.listBoxDisplayResults = new System.Windows.Forms.ListBox();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.buttonExceedOnly = new System.Windows.Forms.Button();
            this.buttonSoilOnly = new System.Windows.Forms.Button();
            this.buttonWaterOnly = new System.Windows.Forms.Button();
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelByExceedance = new System.Windows.Forms.Label();
            this.labelByMatrix = new System.Windows.Forms.Label();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadROs
            // 
            resources.ApplyResources(this.buttonLoadROs, "buttonLoadROs");
            this.buttonLoadROs.Name = "buttonLoadROs";
            this.buttonLoadROs.UseVisualStyleBackColor = true;
            this.buttonLoadROs.Click += new System.EventHandler(this.buttonLoadROs_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonLoadAnalytical
            // 
            resources.ApplyResources(this.buttonLoadAnalytical, "buttonLoadAnalytical");
            this.buttonLoadAnalytical.Name = "buttonLoadAnalytical";
            this.buttonLoadAnalytical.UseVisualStyleBackColor = true;
            this.buttonLoadAnalytical.Click += new System.EventHandler(this.buttonLoadAnalytical_Click);
            // 
            // buttonPerformComp
            // 
            resources.ApplyResources(this.buttonPerformComp, "buttonPerformComp");
            this.buttonPerformComp.Name = "buttonPerformComp";
            this.buttonPerformComp.UseVisualStyleBackColor = true;
            this.buttonPerformComp.Click += new System.EventHandler(this.buttonPerformComp_Click);
            // 
            // buttonExportToCSV
            // 
            resources.ApplyResources(this.buttonExportToCSV, "buttonExportToCSV");
            this.buttonExportToCSV.Name = "buttonExportToCSV";
            this.buttonExportToCSV.UseVisualStyleBackColor = true;
            this.buttonExportToCSV.Click += new System.EventHandler(this.buttonExportToCSV_Click);
            // 
            // listBoxDisplayResults
            // 
            this.listBoxDisplayResults.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxDisplayResults, "listBoxDisplayResults");
            this.listBoxDisplayResults.Name = "listBoxDisplayResults";
            this.listBoxDisplayResults.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplayResults_SelectedIndexChanged);
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.labelByMatrix);
            this.panelFilters.Controls.Add(this.labelByExceedance);
            this.panelFilters.Controls.Add(this.labelFilters);
            this.panelFilters.Controls.Add(this.buttonWaterOnly);
            this.panelFilters.Controls.Add(this.buttonSoilOnly);
            this.panelFilters.Controls.Add(this.buttonExceedOnly);
            resources.ApplyResources(this.panelFilters, "panelFilters");
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFilters_Paint);
            // 
            // buttonExceedOnly
            // 
            resources.ApplyResources(this.buttonExceedOnly, "buttonExceedOnly");
            this.buttonExceedOnly.Name = "buttonExceedOnly";
            this.buttonExceedOnly.UseVisualStyleBackColor = true;
            this.buttonExceedOnly.Click += new System.EventHandler(this.buttonExceedOnly_Click);
            // 
            // buttonSoilOnly
            // 
            resources.ApplyResources(this.buttonSoilOnly, "buttonSoilOnly");
            this.buttonSoilOnly.Name = "buttonSoilOnly";
            this.buttonSoilOnly.UseVisualStyleBackColor = true;
            this.buttonSoilOnly.Click += new System.EventHandler(this.buttonSoilOnly_Click);
            // 
            // buttonWaterOnly
            // 
            resources.ApplyResources(this.buttonWaterOnly, "buttonWaterOnly");
            this.buttonWaterOnly.Name = "buttonWaterOnly";
            this.buttonWaterOnly.UseVisualStyleBackColor = true;
            this.buttonWaterOnly.Click += new System.EventHandler(this.buttonWaterOnly_Click);
            // 
            // labelFilters
            // 
            resources.ApplyResources(this.labelFilters, "labelFilters");
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Click += new System.EventHandler(this.labelFilters_Click);
            // 
            // labelByExceedance
            // 
            resources.ApplyResources(this.labelByExceedance, "labelByExceedance");
            this.labelByExceedance.Name = "labelByExceedance";
            this.labelByExceedance.Click += new System.EventHandler(this.labelByExceedance_Click);
            // 
            // labelByMatrix
            // 
            resources.ApplyResources(this.labelByMatrix, "labelByMatrix");
            this.labelByMatrix.Name = "labelByMatrix";
            this.labelByMatrix.Click += new System.EventHandler(this.labelByMatrix_Click);
            // 
            // GUIFormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.listBoxDisplayResults);
            this.Controls.Add(this.buttonExportToCSV);
            this.Controls.Add(this.buttonPerformComp);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonLoadAnalytical);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLoadROs);
            this.Name = "GUIFormMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.GUIFormMain_Load);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadROs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonLoadAnalytical;
        private System.Windows.Forms.Button buttonPerformComp;
        private System.Windows.Forms.Button buttonExportToCSV;
        private System.Windows.Forms.ListBox listBoxDisplayResults;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button buttonWaterOnly;
        private System.Windows.Forms.Button buttonSoilOnly;
        private System.Windows.Forms.Button buttonExceedOnly;
        private System.Windows.Forms.Label labelByMatrix;
        private System.Windows.Forms.Label labelByExceedance;
        private System.Windows.Forms.Label labelFilters;
    }
}