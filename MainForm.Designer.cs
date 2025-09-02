namespace MicMute
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeyTextBox = new Shortcut.Forms.HotkeyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.muteTextBox = new Shortcut.Forms.HotkeyTextBox();
            this.muteReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.unmuteReset = new System.Windows.Forms.Button();
            this.unmuteTextBox = new Shortcut.Forms.HotkeyTextBox();
            this.cbMuteOnVolumeDownUp = new System.Windows.Forms.CheckBox();
            this.cbUnMuteOnVolumeUpDown = new System.Windows.Forms.CheckBox();
            this.lblVolumeChangeStep = new System.Windows.Forms.Label();
            this.tbVolumeChangeStep = new System.Windows.Forms.TextBox();
            this.iconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.iconContextMenu;
            this.icon.Text = "<Initializing>";
            this.icon.Visible = true;
            this.icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseClick);
            // 
            // iconContextMenu
            // 
            this.iconContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.iconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.hotkeyToolStripMenuItem,
            this.toolStripMenuItem1});
            this.iconContextMenu.Name = "iconContextMenu";
            this.iconContextMenu.Size = new System.Drawing.Size(147, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 24);
            this.toolStripMenuItem2.Text = "Select mic";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // hotkeyToolStripMenuItem
            // 
            this.hotkeyToolStripMenuItem.Name = "hotkeyToolStripMenuItem";
            this.hotkeyToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.hotkeyToolStripMenuItem.Text = "Hotkey";
            this.hotkeyToolStripMenuItem.Click += new System.EventHandler(this.HotkeyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 24);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotkeyTextBox.Hotkey = null;
            this.hotkeyTextBox.Location = new System.Drawing.Point(12, 41);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.Size = new System.Drawing.Size(249, 30);
            this.hotkeyTextBox.TabIndex = 1;
            this.hotkeyTextBox.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register toggle hotkey (auto saved on close)";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(265, 39);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(77, 26);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Register mute hotkey (auto saved on close)";
            // 
            // muteTextBox
            // 
            this.muteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.muteTextBox.Hotkey = null;
            this.muteTextBox.Location = new System.Drawing.Point(12, 105);
            this.muteTextBox.Name = "muteTextBox";
            this.muteTextBox.Size = new System.Drawing.Size(249, 30);
            this.muteTextBox.TabIndex = 5;
            this.muteTextBox.Text = "None";
            // 
            // muteReset
            // 
            this.muteReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.muteReset.Location = new System.Drawing.Point(265, 105);
            this.muteReset.Name = "muteReset";
            this.muteReset.Size = new System.Drawing.Size(77, 26);
            this.muteReset.TabIndex = 6;
            this.muteReset.Text = "reset";
            this.muteReset.UseVisualStyleBackColor = true;
            this.muteReset.Click += new System.EventHandler(this.muteReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Register unmute hotkey (auto saved on close)";
            // 
            // unmuteReset
            // 
            this.unmuteReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unmuteReset.Location = new System.Drawing.Point(265, 161);
            this.unmuteReset.Name = "unmuteReset";
            this.unmuteReset.Size = new System.Drawing.Size(77, 26);
            this.unmuteReset.TabIndex = 9;
            this.unmuteReset.Text = "reset";
            this.unmuteReset.UseVisualStyleBackColor = true;
            this.unmuteReset.Click += new System.EventHandler(this.unmuteReset_Click);
            // 
            // unmuteTextBox
            // 
            this.unmuteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unmuteTextBox.Hotkey = null;
            this.unmuteTextBox.Location = new System.Drawing.Point(12, 161);
            this.unmuteTextBox.Name = "unmuteTextBox";
            this.unmuteTextBox.Size = new System.Drawing.Size(249, 30);
            this.unmuteTextBox.TabIndex = 8;
            this.unmuteTextBox.Text = "None";
            // 
            // cbMuteOnVolumeDownUp
            // 
            this.cbMuteOnVolumeDownUp.AutoSize = true;
            this.cbMuteOnVolumeDownUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMuteOnVolumeDownUp.Location = new System.Drawing.Point(12, 194);
            this.cbMuteOnVolumeDownUp.Name = "cbMuteOnVolumeDownUp";
            this.cbMuteOnVolumeDownUp.Size = new System.Drawing.Size(259, 29);
            this.cbMuteOnVolumeDownUp.TabIndex = 10;
            this.cbMuteOnVolumeDownUp.Text = "Mute on volume down+up";
            this.cbMuteOnVolumeDownUp.UseVisualStyleBackColor = true;
            // 
            // cbUnMuteOnVolumeUpDown
            // 
            this.cbUnMuteOnVolumeUpDown.AutoSize = true;
            this.cbUnMuteOnVolumeUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnMuteOnVolumeUpDown.Location = new System.Drawing.Point(12, 224);
            this.cbUnMuteOnVolumeUpDown.Name = "cbUnMuteOnVolumeUpDown";
            this.cbUnMuteOnVolumeUpDown.Size = new System.Drawing.Size(283, 29);
            this.cbUnMuteOnVolumeUpDown.TabIndex = 11;
            this.cbUnMuteOnVolumeUpDown.Text = "Unmute on volume up+down";
            this.cbUnMuteOnVolumeUpDown.UseVisualStyleBackColor = true;
            // 
            // lblVolumeChangeStep
            // 
            this.lblVolumeChangeStep.AutoSize = true;
            this.lblVolumeChangeStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolumeChangeStep.Location = new System.Drawing.Point(12, 256);
            this.lblVolumeChangeStep.Name = "lblVolumeChangeStep";
            this.lblVolumeChangeStep.Size = new System.Drawing.Size(276, 25);
            this.lblVolumeChangeStep.TabIndex = 12;
            this.lblVolumeChangeStep.Text = "Volume change step for toggle";
            // 
            // tbVolumeChangeStep
            // 
            this.tbVolumeChangeStep.Location = new System.Drawing.Point(17, 285);
            this.tbVolumeChangeStep.Name = "tbVolumeChangeStep";
            this.tbVolumeChangeStep.Size = new System.Drawing.Size(254, 20);
            this.tbVolumeChangeStep.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 332);
            this.Controls.Add(this.tbVolumeChangeStep);
            this.Controls.Add(this.lblVolumeChangeStep);
            this.Controls.Add(this.cbUnMuteOnVolumeUpDown);
            this.Controls.Add(this.cbMuteOnVolumeDownUp);
            this.Controls.Add(this.unmuteReset);
            this.Controls.Add(this.unmuteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.muteReset);
            this.Controls.Add(this.muteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotkeyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MicMute";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.iconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.ContextMenuStrip iconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Shortcut.Forms.HotkeyTextBox hotkeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hotkeyToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label2;
        private Shortcut.Forms.HotkeyTextBox muteTextBox;
        private System.Windows.Forms.Button muteReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unmuteReset;
        private Shortcut.Forms.HotkeyTextBox unmuteTextBox;
        private System.Windows.Forms.CheckBox cbMuteOnVolumeDownUp;
        private System.Windows.Forms.CheckBox cbUnMuteOnVolumeUpDown;
        private System.Windows.Forms.Label lblVolumeChangeStep;
        private System.Windows.Forms.TextBox tbVolumeChangeStep;
    }
}

