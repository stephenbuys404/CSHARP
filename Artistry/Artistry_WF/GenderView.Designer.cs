namespace Artistry_WF
{
    partial class GenderView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dvgGenders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGenders)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgGenders
            // 
            this.dvgGenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGenders.Location = new System.Drawing.Point(17, 14);
            this.dvgGenders.Name = "dvgGenders";
            this.dvgGenders.Size = new System.Drawing.Size(658, 222);
            this.dvgGenders.TabIndex = 0;
            // 
            // GenderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 248);
            this.Controls.Add(this.dvgGenders);
            this.Name = "GenderView";
            this.Text = "GenderView";
            ((System.ComponentModel.ISupportInitialize)(this.dvgGenders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgGenders;
    }
}