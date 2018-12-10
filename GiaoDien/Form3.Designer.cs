namespace GiaoDien
{
    partial class Form3
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
            this.MCLDLich = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.SuspendLayout();
            // 
            // MCLDLich
            // 
            this.MCLDLich.AutoSize = true;
            // 
            // 
            // 
            this.MCLDLich.BackgroundStyle.Class = "MonthCalendarAdv";
            this.MCLDLich.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.MCLDLich.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MCLDLich.ContainerControlProcessDialogKey = true;
            this.MCLDLich.DisplayMonth = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.MCLDLich.Location = new System.Drawing.Point(57, 43);
            this.MCLDLich.Name = "MCLDLich";
            // 
            // 
            // 
            this.MCLDLich.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.MCLDLich.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.MCLDLich.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.MCLDLich.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MCLDLich.Size = new System.Drawing.Size(170, 131);
            this.MCLDLich.TabIndex = 0;
            this.MCLDLich.Text = "monthCalendarAdv1";
            this.MCLDLich.ItemClick += new System.EventHandler(this.monthCalendarAdv1_ItemClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MCLDLich);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv MCLDLich;
    }
}