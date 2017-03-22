namespace ProxyManager
{
    partial class PMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMForm));
            this.btnSetProxy = new System.Windows.Forms.Button();
            this.lblProxy = new System.Windows.Forms.Label();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtExceptions = new System.Windows.Forms.TextBox();
            this.lblExceptions = new System.Windows.Forms.Label();
            this.btnSelectProxy = new System.Windows.Forms.Button();
            this.ddlProxy = new System.Windows.Forms.ComboBox();
            this.btnEnableProxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetProxy
            // 
            this.btnSetProxy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetProxy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSetProxy.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetProxy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetProxy.Location = new System.Drawing.Point(303, 186);
            this.btnSetProxy.Name = "btnSetProxy";
            this.btnSetProxy.Size = new System.Drawing.Size(83, 33);
            this.btnSetProxy.TabIndex = 0;
            this.btnSetProxy.Text = "SET PROXY";
            this.btnSetProxy.UseVisualStyleBackColor = false;
            this.btnSetProxy.Click += new System.EventHandler(this.btnSetProxy_Click);
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxy.ForeColor = System.Drawing.Color.Snow;
            this.lblProxy.Location = new System.Drawing.Point(13, 9);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(39, 15);
            this.lblProxy.TabIndex = 1;
            this.lblProxy.Text = "Proxy:";
            // 
            // txtProxy
            // 
            this.txtProxy.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxy.Location = new System.Drawing.Point(56, 6);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(330, 23);
            this.txtProxy.TabIndex = 2;
            this.txtProxy.WordWrap = false;
            this.txtProxy.TextChanged += new System.EventHandler(this.txtProxy_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(56, 32);
            this.txtPort.MaxLength = 4;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(47, 23);
            this.txtPort.TabIndex = 4;
            this.txtPort.WordWrap = false;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.Snow;
            this.lblPort.Location = new System.Drawing.Point(20, 35);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 15);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port:";
            // 
            // txtExceptions
            // 
            this.txtExceptions.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtExceptions.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExceptions.ForeColor = System.Drawing.SystemColors.Window;
            this.txtExceptions.Location = new System.Drawing.Point(16, 79);
            this.txtExceptions.Multiline = true;
            this.txtExceptions.Name = "txtExceptions";
            this.txtExceptions.Size = new System.Drawing.Size(370, 102);
            this.txtExceptions.TabIndex = 8;
            this.txtExceptions.TextChanged += new System.EventHandler(this.txtExceptions_TextChanged);
            // 
            // lblExceptions
            // 
            this.lblExceptions.AutoSize = true;
            this.lblExceptions.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExceptions.ForeColor = System.Drawing.Color.Snow;
            this.lblExceptions.Location = new System.Drawing.Point(16, 60);
            this.lblExceptions.Name = "lblExceptions";
            this.lblExceptions.Size = new System.Drawing.Size(66, 15);
            this.lblExceptions.TabIndex = 9;
            this.lblExceptions.Text = "Exceptions:";
            // 
            // btnSelectProxy
            // 
            this.btnSelectProxy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectProxy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectProxy.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectProxy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectProxy.Location = new System.Drawing.Point(303, 36);
            this.btnSelectProxy.Name = "btnSelectProxy";
            this.btnSelectProxy.Size = new System.Drawing.Size(83, 33);
            this.btnSelectProxy.TabIndex = 10;
            this.btnSelectProxy.Text = "SELECT";
            this.btnSelectProxy.UseVisualStyleBackColor = false;
            this.btnSelectProxy.Visible = false;
            this.btnSelectProxy.Click += new System.EventHandler(this.btnSelectProxy_Click);
            // 
            // ddlProxy
            // 
            this.ddlProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProxy.FormattingEnabled = true;
            this.ddlProxy.Location = new System.Drawing.Point(197, 43);
            this.ddlProxy.Name = "ddlProxy";
            this.ddlProxy.Size = new System.Drawing.Size(100, 21);
            this.ddlProxy.TabIndex = 11;
            this.ddlProxy.Visible = false;
            // 
            // btnEnableProxy
            // 
            this.btnEnableProxy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEnableProxy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnableProxy.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableProxy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnableProxy.Location = new System.Drawing.Point(70, 186);
            this.btnEnableProxy.Name = "btnEnableProxy";
            this.btnEnableProxy.Size = new System.Drawing.Size(164, 33);
            this.btnEnableProxy.TabIndex = 12;
            this.btnEnableProxy.Text = "ENABLE PROXY";
            this.btnEnableProxy.UseVisualStyleBackColor = false;
            this.btnEnableProxy.Click += new System.EventHandler(this.btnEnableProxy_Click);
            // 
            // PMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(398, 221);
            this.Controls.Add(this.btnEnableProxy);
            this.Controls.Add(this.ddlProxy);
            this.Controls.Add(this.btnSelectProxy);
            this.Controls.Add(this.lblExceptions);
            this.Controls.Add(this.txtExceptions);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtProxy);
            this.Controls.Add(this.lblProxy);
            this.Controls.Add(this.btnSetProxy);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PMForm";
            this.Text = "ProxyManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetProxy;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtExceptions;
        private System.Windows.Forms.Label lblExceptions;
        private System.Windows.Forms.Button btnSelectProxy;
        private System.Windows.Forms.ComboBox ddlProxy;
        private System.Windows.Forms.Button btnEnableProxy;
    }
}

