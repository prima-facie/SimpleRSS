namespace SimpleRSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rssList = new System.Windows.Forms.ListView();
            this.TxtSummary = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rssList
            // 
            this.rssList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rssList.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rssList.HideSelection = false;
            this.rssList.Location = new System.Drawing.Point(17, 16);
            this.rssList.Name = "rssList";
            this.rssList.OwnerDraw = true;
            this.rssList.Size = new System.Drawing.Size(405, 226);
            this.rssList.TabIndex = 0;
            this.rssList.TileSize = new System.Drawing.Size(385, 30);
            this.rssList.UseCompatibleStateImageBehavior = false;
            this.rssList.View = System.Windows.Forms.View.Tile;
            this.rssList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.rssList_DrawItem);
            this.rssList.SelectedIndexChanged += new System.EventHandler(this.rssList_SelectedIndexChanged);
            // 
            // TxtSummary
            // 
            this.TxtSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSummary.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSummary.Location = new System.Drawing.Point(17, 289);
            this.TxtSummary.Multiline = true;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.ReadOnly = true;
            this.TxtSummary.Size = new System.Drawing.Size(405, 226);
            this.TxtSummary.TabIndex = 1;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(17, 248);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(405, 35);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Refresh RSS Feed";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(438, 531);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtSummary);
            this.Controls.Add(this.rssList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Feed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView rssList;
        private System.Windows.Forms.TextBox TxtSummary;
        private System.Windows.Forms.Button BtnUpdate;
    }
}

