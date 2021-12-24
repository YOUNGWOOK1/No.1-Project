
namespace TestProgram
{
    partial class ConnectSetPage
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
            this.connectbutton = new System.Windows.Forms.Button();
            this.IpAdressInPut = new System.Windows.Forms.TextBox();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(112, 137);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(130, 23);
            this.connectbutton.TabIndex = 0;
            this.connectbutton.Tag = "ConnectionButton";
            this.connectbutton.Text = "ConnectionButton";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // IpAdressInPut
            // 
            this.IpAdressInPut.Location = new System.Drawing.Point(63, 37);
            this.IpAdressInPut.Name = "IpAdressInPut";
            this.IpAdressInPut.Size = new System.Drawing.Size(100, 21);
            this.IpAdressInPut.TabIndex = 1;
            this.IpAdressInPut.Tag = "IpAdressInPut";
            this.IpAdressInPut.KeyDown += IpAdressInPut_KeyDown;
            

            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(63, 74);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(100, 21);
            this.PortInput.TabIndex = 2;
            this.PortInput.Tag = "PortInPut";
            this.PortInput.KeyDown += PortInput_keyDown;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // ConnectSetPage
            // 
            this.ClientSize = new System.Drawing.Size(275, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.IpAdressInPut);
            this.Controls.Add(this.connectbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectSetPage";
            this.Load += new System.EventHandler(this.ConnectSetPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.TextBox IpAdressInPut;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}