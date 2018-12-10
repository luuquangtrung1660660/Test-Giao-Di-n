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
            this.monthCalendarAdv1 = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.SuspendLayout();
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.AutoSize = true;
            // 
            // 
            // 
            this.monthCalendarAdv1.BackgroundStyle.Class = "MonthCalendarAdv";
            this.monthCalendarAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.monthCalendarAdv1.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.ContainerControlProcessDialogKey = true;
            this.monthCalendarAdv1.DisplayMonth = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.monthCalendarAdv1.Location = new System.Drawing.Point(57, 43);
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            // 
            // 
            // 
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.monthCalendarAdv1.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.Size = new System.Drawing.Size(170, 131);
            this.monthCalendarAdv1.TabIndex = 0;
            this.monthCalendarAdv1.Text = "monthCalendarAdv1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.monthCalendarAdv1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv monthCalendarAdv1;
    }
}