﻿/*
  RMLibUI: Visual support classes/components used by multiple R&M Software programs
  Copyright (C) 2008-2013  Rick Parrish, R&M Software

  This file is part of RMLibUI.

  RMLibUI is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  any later version.

  RMLibUI is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with RMLibUI.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Windows.Forms;

namespace RandM.RMLibUI
{
    public class frmRMInputBox : Form
    {
        #region Windows Contols and Constructor

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.TextBox txtInput;
        /// <summary>
        /// Required designer variable.
        ///</summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region Dispose

        /// <summary>
        /// Clean up any resources being used.
        ///</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        ///</summary>
        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(295, 76);
            this.lblPrompt.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(8, 95);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(379, 20);
            this.txtInput.TabIndex = 0;
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(312, 5);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 25);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(312, 36);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 25);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // frmRMInputBox
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(394, 122);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRMInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.Text = "R&M Input Box";
            this.Load += new System.EventHandler(this.frmRMInputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button cmdCancel;
        #endregion

        public frmRMInputBox(string prompt, string caption, string defaultText)
        {
            InitializeComponent();

            // Initialize dialog
            lblPrompt.Text = prompt;
            this.Text = caption;
            txtInput.Text = defaultText;

            // Set default return value
            _InputText = defaultText;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            // Save new return value
            _InputText = txtInput.Text;
        }

        private void frmRMInputBox_Load(object sender, System.EventArgs e)
        {
            // Focus text box with all text highlighted
            txtInput.SelectAll();
            txtInput.Focus();
        }

        public string InputText
        {
            get { return _InputText; }
        }
        private string _InputText = "";
    }
}
