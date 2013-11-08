namespace VQRemote
{
  partial class Form1
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.lblCoords = new System.Windows.Forms.Label();
      this.txtRemoteIP = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chkMouseAccel = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNASKey = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.chkNASControl = new System.Windows.Forms.CheckBox();
      this.chkNASAlt = new System.Windows.Forms.CheckBox();
      this.chkNASShift = new System.Windows.Forms.CheckBox();
      this.chkLocalShift = new System.Windows.Forms.CheckBox();
      this.chkLocalAlt = new System.Windows.Forms.CheckBox();
      this.chkLocalControl = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 191);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(425, 147);
      this.textBox1.TabIndex = 0;
      // 
      // lblCoords
      // 
      this.lblCoords.AutoSize = true;
      this.lblCoords.Location = new System.Drawing.Point(166, 9);
      this.lblCoords.Name = "lblCoords";
      this.lblCoords.Size = new System.Drawing.Size(33, 13);
      this.lblCoords.TabIndex = 2;
      this.lblCoords.Text = "X:  Y:";
      // 
      // txtRemoteIP
      // 
      this.txtRemoteIP.Location = new System.Drawing.Point(66, 6);
      this.txtRemoteIP.Name = "txtRemoteIP";
      this.txtRemoteIP.Size = new System.Drawing.Size(77, 20);
      this.txtRemoteIP.TabIndex = 3;
      this.txtRemoteIP.Text = "10.0.0.33";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "QNap IP";
      // 
      // chkMouseAccel
      // 
      this.chkMouseAccel.AutoSize = true;
      this.chkMouseAccel.Location = new System.Drawing.Point(15, 32);
      this.chkMouseAccel.Name = "chkMouseAccel";
      this.chkMouseAccel.Size = new System.Drawing.Size(99, 17);
      this.chkMouseAccel.TabIndex = 5;
      this.chkMouseAccel.Text = "2x Acceleration";
      this.chkMouseAccel.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Switch to NAS";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Switch to local";
      // 
      // txtNASKey
      // 
      this.txtNASKey.Location = new System.Drawing.Point(300, 61);
      this.txtNASKey.MaxLength = 1;
      this.txtNASKey.Name = "txtNASKey";
      this.txtNASKey.Size = new System.Drawing.Size(20, 20);
      this.txtNASKey.TabIndex = 8;
      this.txtNASKey.Text = "M";
      this.txtNASKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(300, 87);
      this.textBox3.MaxLength = 1;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(20, 20);
      this.textBox3.TabIndex = 9;
      this.textBox3.Text = "H";
      this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // chkNASControl
      // 
      this.chkNASControl.AutoSize = true;
      this.chkNASControl.Checked = true;
      this.chkNASControl.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkNASControl.Location = new System.Drawing.Point(96, 63);
      this.chkNASControl.Name = "chkNASControl";
      this.chkNASControl.Size = new System.Drawing.Size(59, 17);
      this.chkNASControl.TabIndex = 10;
      this.chkNASControl.Text = "Control";
      this.chkNASControl.UseVisualStyleBackColor = true;
      // 
      // chkNASAlt
      // 
      this.chkNASAlt.AutoSize = true;
      this.chkNASAlt.Checked = true;
      this.chkNASAlt.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkNASAlt.Location = new System.Drawing.Point(162, 63);
      this.chkNASAlt.Name = "chkNASAlt";
      this.chkNASAlt.Size = new System.Drawing.Size(38, 17);
      this.chkNASAlt.TabIndex = 11;
      this.chkNASAlt.Text = "Alt";
      this.chkNASAlt.UseVisualStyleBackColor = true;
      // 
      // chkNASShift
      // 
      this.chkNASShift.AutoSize = true;
      this.chkNASShift.Location = new System.Drawing.Point(207, 63);
      this.chkNASShift.Name = "chkNASShift";
      this.chkNASShift.Size = new System.Drawing.Size(47, 17);
      this.chkNASShift.TabIndex = 12;
      this.chkNASShift.Text = "Shift";
      this.chkNASShift.UseVisualStyleBackColor = true;
      // 
      // chkLocalShift
      // 
      this.chkLocalShift.AutoSize = true;
      this.chkLocalShift.Location = new System.Drawing.Point(207, 89);
      this.chkLocalShift.Name = "chkLocalShift";
      this.chkLocalShift.Size = new System.Drawing.Size(47, 17);
      this.chkLocalShift.TabIndex = 15;
      this.chkLocalShift.Text = "Shift";
      this.chkLocalShift.UseVisualStyleBackColor = true;
      // 
      // chkLocalAlt
      // 
      this.chkLocalAlt.AutoSize = true;
      this.chkLocalAlt.Checked = true;
      this.chkLocalAlt.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkLocalAlt.Location = new System.Drawing.Point(162, 89);
      this.chkLocalAlt.Name = "chkLocalAlt";
      this.chkLocalAlt.Size = new System.Drawing.Size(38, 17);
      this.chkLocalAlt.TabIndex = 14;
      this.chkLocalAlt.Text = "Alt";
      this.chkLocalAlt.UseVisualStyleBackColor = true;
      // 
      // chkLocalControl
      // 
      this.chkLocalControl.AutoSize = true;
      this.chkLocalControl.Checked = true;
      this.chkLocalControl.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkLocalControl.Location = new System.Drawing.Point(96, 89);
      this.chkLocalControl.Name = "chkLocalControl";
      this.chkLocalControl.Size = new System.Drawing.Size(59, 17);
      this.chkLocalControl.TabIndex = 13;
      this.chkLocalControl.Text = "Control";
      this.chkLocalControl.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(269, 64);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(25, 13);
      this.label4.TabIndex = 16;
      this.label4.Text = "Key";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(269, 90);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(25, 13);
      this.label5.TabIndex = 17;
      this.label5.Text = "Key";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(449, 350);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.chkLocalShift);
      this.Controls.Add(this.chkLocalAlt);
      this.Controls.Add(this.chkLocalControl);
      this.Controls.Add(this.chkNASShift);
      this.Controls.Add(this.chkNASAlt);
      this.Controls.Add(this.chkNASControl);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.txtNASKey);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.chkMouseAccel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtRemoteIP);
      this.Controls.Add(this.lblCoords);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "QRemote.NET";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label lblCoords;
    private System.Windows.Forms.TextBox txtRemoteIP;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox chkMouseAccel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtNASKey;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.CheckBox chkNASControl;
    private System.Windows.Forms.CheckBox chkNASAlt;
    private System.Windows.Forms.CheckBox chkNASShift;
    private System.Windows.Forms.CheckBox chkLocalShift;
    private System.Windows.Forms.CheckBox chkLocalAlt;
    private System.Windows.Forms.CheckBox chkLocalControl;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
  }
}

