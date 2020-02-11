namespace CanYouCatchMe_
{
    partial class evil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evil));
            this.evilevil = new FlatUI.FormSkin();
            this.evilbox = new FlatUI.FlatTextBox();
            this.flatClose1 = new FlatUI.FlatClose();
            this.evilevil.SuspendLayout();
            this.SuspendLayout();
            // 
            // evilevil
            // 
            this.evilevil.BackColor = System.Drawing.Color.White;
            this.evilevil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.evilevil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.evilevil.Controls.Add(this.flatClose1);
            this.evilevil.Controls.Add(this.evilbox);
            this.evilevil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evilevil.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.evilevil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.evilevil.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.evilevil.HeaderMaximize = false;
            this.evilevil.Location = new System.Drawing.Point(0, 0);
            this.evilevil.Name = "evilevil";
            this.evilevil.Size = new System.Drawing.Size(725, 226);
            this.evilevil.TabIndex = 0;
            this.evilevil.Text = "s u c c e s s";
            // 
            // evilbox
            // 
            this.evilbox.BackColor = System.Drawing.Color.Transparent;
            this.evilbox.FocusOnHover = false;
            this.evilbox.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evilbox.Location = new System.Drawing.Point(40, 79);
            this.evilbox.MaxLength = 32767;
            this.evilbox.Multiline = true;
            this.evilbox.Name = "evilbox";
            this.evilbox.ReadOnly = false;
            this.evilbox.Size = new System.Drawing.Size(644, 113);
            this.evilbox.TabIndex = 1;
            this.evilbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.evilbox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.evilbox.UseSystemPasswordChar = false;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(695, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 2;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // evil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 226);
            this.ControlBox = false;
            this.Controls.Add(this.evilevil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "evil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evil";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.evilevil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin evilevil;
        private FlatUI.FlatTextBox evilbox;
        private FlatUI.FlatClose flatClose1;
    }
}