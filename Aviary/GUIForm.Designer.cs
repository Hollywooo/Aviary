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
            // GUIFormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}