﻿namespace Launchpad_LED_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.launchpadModels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.midi_testDevices = new System.Windows.Forms.Button();
            this.midi_OutputState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.midi_outputDevices = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.midi_InputState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.midi_inputDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ledGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_currentColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_red = new System.Windows.Forms.Panel();
            this.panel_yellow = new System.Windows.Forms.Panel();
            this.panel_orange = new System.Windows.Forms.Panel();
            this.panel_blue = new System.Windows.Forms.Panel();
            this.panel_lightBlue = new System.Windows.Forms.Panel();
            this.panel_lime = new System.Windows.Forms.Panel();
            this.panel_green = new System.Windows.Forms.Panel();
            this.panel_white = new System.Windows.Forms.Panel();
            this.panel_clear = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.launchpadModels);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.midi_testDevices);
            this.groupBox1.Controls.Add(this.midi_OutputState);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.midi_outputDevices);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.midi_InputState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.midi_inputDevices);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // launchpadModels
            // 
            this.launchpadModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.launchpadModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.launchpadModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchpadModels.ForeColor = System.Drawing.Color.Gold;
            this.launchpadModels.FormattingEnabled = true;
            this.launchpadModels.Items.AddRange(new object[] {
            "Launchpad",
            "Launchpad MK2",
            "Launchpad Mini",
            "Launchpad Pro",
            "Launchpad S"});
            this.launchpadModels.Location = new System.Drawing.Point(126, 152);
            this.launchpadModels.Name = "launchpadModels";
            this.launchpadModels.Size = new System.Drawing.Size(136, 24);
            this.launchpadModels.TabIndex = 11;
            this.launchpadModels.SelectedIndexChanged += new System.EventHandler(this.launchpadModels_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Launchpad Model:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(8, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 3);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // midi_testDevices
            // 
            this.midi_testDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_testDevices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.midi_testDevices.Location = new System.Drawing.Point(7, 114);
            this.midi_testDevices.Name = "midi_testDevices";
            this.midi_testDevices.Size = new System.Drawing.Size(79, 23);
            this.midi_testDevices.TabIndex = 8;
            this.midi_testDevices.Text = "Test";
            this.midi_testDevices.UseVisualStyleBackColor = true;
            this.midi_testDevices.Click += new System.EventHandler(this.midi_testDevices_Click);
            // 
            // midi_OutputState
            // 
            this.midi_OutputState.AutoSize = true;
            this.midi_OutputState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_OutputState.Location = new System.Drawing.Point(104, 90);
            this.midi_OutputState.Name = "midi_OutputState";
            this.midi_OutputState.Size = new System.Drawing.Size(81, 16);
            this.midi_OutputState.TabIndex = 7;
            this.midi_OutputState.Text = "<state here>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Status:";
            // 
            // midi_outputDevices
            // 
            this.midi_outputDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.midi_outputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midi_outputDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_outputDevices.ForeColor = System.Drawing.Color.Gold;
            this.midi_outputDevices.FormattingEnabled = true;
            this.midi_outputDevices.Location = new System.Drawing.Point(103, 64);
            this.midi_outputDevices.Name = "midi_outputDevices";
            this.midi_outputDevices.Size = new System.Drawing.Size(159, 24);
            this.midi_outputDevices.TabIndex = 5;
            this.midi_outputDevices.SelectedIndexChanged += new System.EventHandler(this.midi_outputDevices_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Output Device:";
            // 
            // midi_InputState
            // 
            this.midi_InputState.AutoSize = true;
            this.midi_InputState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_InputState.Location = new System.Drawing.Point(104, 43);
            this.midi_InputState.Name = "midi_InputState";
            this.midi_InputState.Size = new System.Drawing.Size(81, 16);
            this.midi_InputState.TabIndex = 3;
            this.midi_InputState.Text = "<state here>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Status:";
            // 
            // midi_inputDevices
            // 
            this.midi_inputDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.midi_inputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midi_inputDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midi_inputDevices.ForeColor = System.Drawing.Color.Gold;
            this.midi_inputDevices.FormattingEnabled = true;
            this.midi_inputDevices.Location = new System.Drawing.Point(103, 14);
            this.midi_inputDevices.Name = "midi_inputDevices";
            this.midi_inputDevices.Size = new System.Drawing.Size(158, 24);
            this.midi_inputDevices.TabIndex = 1;
            this.midi_inputDevices.SelectedIndexChanged += new System.EventHandler(this.midi_inputDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Device:";
            // 
            // ledGroup
            // 
            this.ledGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ledGroup.ForeColor = System.Drawing.Color.Gold;
            this.ledGroup.Location = new System.Drawing.Point(278, -2);
            this.ledGroup.Name = "ledGroup";
            this.ledGroup.Size = new System.Drawing.Size(425, 432);
            this.ledGroup.TabIndex = 1;
            this.ledGroup.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel_currentColor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(4, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // panel_currentColor
            // 
            this.panel_currentColor.BackColor = System.Drawing.Color.Gray;
            this.panel_currentColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_currentColor.Location = new System.Drawing.Point(98, 80);
            this.panel_currentColor.Name = "panel_currentColor";
            this.panel_currentColor.Size = new System.Drawing.Size(20, 20);
            this.panel_currentColor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Current Color:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel_red, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_yellow, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_orange, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_blue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_lightBlue, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_lime, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_green, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_white, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_clear, 9, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_red
            // 
            this.panel_red.BackColor = System.Drawing.Color.Red;
            this.panel_red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_red.Location = new System.Drawing.Point(3, 3);
            this.panel_red.Name = "panel_red";
            this.panel_red.Size = new System.Drawing.Size(19, 19);
            this.panel_red.TabIndex = 0;
            this.panel_red.Click += new System.EventHandler(this.panel_red_Click);
            // 
            // panel_yellow
            // 
            this.panel_yellow.BackColor = System.Drawing.Color.Yellow;
            this.panel_yellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_yellow.Location = new System.Drawing.Point(53, 3);
            this.panel_yellow.Name = "panel_yellow";
            this.panel_yellow.Size = new System.Drawing.Size(19, 19);
            this.panel_yellow.TabIndex = 2;
            this.panel_yellow.Click += new System.EventHandler(this.panel_yellow_Click);
            // 
            // panel_orange
            // 
            this.panel_orange.BackColor = System.Drawing.Color.Orange;
            this.panel_orange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_orange.Location = new System.Drawing.Point(78, 3);
            this.panel_orange.Name = "panel_orange";
            this.panel_orange.Size = new System.Drawing.Size(19, 19);
            this.panel_orange.TabIndex = 3;
            this.panel_orange.Click += new System.EventHandler(this.panel_orange_Click);
            // 
            // panel_blue
            // 
            this.panel_blue.BackColor = System.Drawing.Color.Blue;
            this.panel_blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_blue.Location = new System.Drawing.Point(103, 3);
            this.panel_blue.Name = "panel_blue";
            this.panel_blue.Size = new System.Drawing.Size(19, 19);
            this.panel_blue.TabIndex = 4;
            this.panel_blue.Click += new System.EventHandler(this.panel_blue_Click);
            // 
            // panel_lightBlue
            // 
            this.panel_lightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.panel_lightBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lightBlue.Location = new System.Drawing.Point(128, 3);
            this.panel_lightBlue.Name = "panel_lightBlue";
            this.panel_lightBlue.Size = new System.Drawing.Size(19, 19);
            this.panel_lightBlue.TabIndex = 5;
            this.panel_lightBlue.Click += new System.EventHandler(this.panel_lightBlue_Click);
            // 
            // panel_lime
            // 
            this.panel_lime.BackColor = System.Drawing.Color.Lime;
            this.panel_lime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lime.Location = new System.Drawing.Point(178, 3);
            this.panel_lime.Name = "panel_lime";
            this.panel_lime.Size = new System.Drawing.Size(19, 19);
            this.panel_lime.TabIndex = 7;
            this.panel_lime.Click += new System.EventHandler(this.panel_lime_Click);
            // 
            // panel_green
            // 
            this.panel_green.BackColor = System.Drawing.Color.Green;
            this.panel_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_green.Location = new System.Drawing.Point(28, 3);
            this.panel_green.Name = "panel_green";
            this.panel_green.Size = new System.Drawing.Size(19, 19);
            this.panel_green.TabIndex = 1;
            this.panel_green.Click += new System.EventHandler(this.panel_green_Click);
            // 
            // panel_white
            // 
            this.panel_white.BackColor = System.Drawing.Color.White;
            this.panel_white.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_white.Location = new System.Drawing.Point(153, 3);
            this.panel_white.Name = "panel_white";
            this.panel_white.Size = new System.Drawing.Size(19, 19);
            this.panel_white.TabIndex = 6;
            this.panel_white.Click += new System.EventHandler(this.panel_white_Click);
            // 
            // panel_clear
            // 
            this.panel_clear.BackColor = System.Drawing.Color.Gray;
            this.panel_clear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_clear.Location = new System.Drawing.Point(228, 28);
            this.panel_clear.Name = "panel_clear";
            this.panel_clear.Size = new System.Drawing.Size(22, 20);
            this.panel_clear.TabIndex = 8;
            this.panel_clear.Click += new System.EventHandler(this.panel_clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(709, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ledGroup);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVATION Launchpad LED Editor v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label midi_InputState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox midi_inputDevices;
        private System.Windows.Forms.Label midi_OutputState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox midi_outputDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button midi_testDevices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox launchpadModels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ledGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_red;
        private System.Windows.Forms.Panel panel_green;
        private System.Windows.Forms.Panel panel_yellow;
        private System.Windows.Forms.Panel panel_orange;
        private System.Windows.Forms.Panel panel_blue;
        private System.Windows.Forms.Panel panel_lightBlue;
        private System.Windows.Forms.Panel panel_white;
        private System.Windows.Forms.Panel panel_lime;
        private System.Windows.Forms.Panel panel_currentColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_clear;
    }
}
