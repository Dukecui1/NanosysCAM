namespace Nanosys1000Software
{
    partial class ProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_saveNC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(9, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(367, 488);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Image = global::Nanosys1000Software.Properties.Resources.EXIT16;
            this.button1.Location = new System.Drawing.Point(247, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "关闭";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_saveNC
            // 
            this.button_saveNC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_saveNC.ForeColor = System.Drawing.Color.DarkRed;
            this.button_saveNC.Image = global::Nanosys1000Software.Properties.Resources.Save;
            this.button_saveNC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_saveNC.Location = new System.Drawing.Point(69, 503);
            this.button_saveNC.Name = "button_saveNC";
            this.button_saveNC.Size = new System.Drawing.Size(81, 30);
            this.button_saveNC.TabIndex = 15;
            this.button_saveNC.Text = "另存为..";
            this.button_saveNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_saveNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_saveNC.UseVisualStyleBackColor = true;
            this.button_saveNC.Click += new System.EventHandler(this.button_saveNC_Click);
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(388, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_saveNC);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NC程序列表";
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_saveNC;
        private System.Windows.Forms.Button button1;
    }
}