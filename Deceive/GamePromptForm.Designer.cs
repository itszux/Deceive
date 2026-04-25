namespace Deceive
{
    internal partial class GamePromptForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePromptForm));
			this.buttonLaunchLoL = new System.Windows.Forms.Button();
			this.buttonLaunchValorant = new System.Windows.Forms.Button();
			this.buttonLaunchRiotClient = new System.Windows.Forms.Button();
			this.checkboxRemember = new System.Windows.Forms.CheckBox();
			this.comboStatus = new System.Windows.Forms.ComboBox();
			this.checkboxDefaultStatus = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonLaunchLoL
			// 
			this.buttonLaunchLoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonLaunchLoL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLaunchLoL.BackgroundImage")));
			this.buttonLaunchLoL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLaunchLoL.FlatAppearance.BorderSize = 0;
			this.buttonLaunchLoL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLaunchLoL.Location = new System.Drawing.Point(12, 12);
			this.buttonLaunchLoL.Name = "buttonLaunchLoL";
			this.buttonLaunchLoL.Size = new System.Drawing.Size(106, 46);
			this.buttonLaunchLoL.TabIndex = 1;
			this.buttonLaunchLoL.UseVisualStyleBackColor = false;
			this.buttonLaunchLoL.Click += new System.EventHandler(this.OnLoLLaunch);
			// 
			// buttonLaunchValorant
			// 
			this.buttonLaunchValorant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonLaunchValorant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLaunchValorant.BackgroundImage")));
			this.buttonLaunchValorant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLaunchValorant.FlatAppearance.BorderSize = 0;
			this.buttonLaunchValorant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLaunchValorant.Location = new System.Drawing.Point(124, 12);
			this.buttonLaunchValorant.Name = "buttonLaunchValorant";
			this.buttonLaunchValorant.Size = new System.Drawing.Size(104, 46);
			this.buttonLaunchValorant.TabIndex = 3;
			this.buttonLaunchValorant.UseVisualStyleBackColor = false;
			this.buttonLaunchValorant.Click += new System.EventHandler(this.OnValorantLaunch);
			// 
			// buttonLaunchRiotClient
			// 
			this.buttonLaunchRiotClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonLaunchRiotClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLaunchRiotClient.BackgroundImage")));
			this.buttonLaunchRiotClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLaunchRiotClient.FlatAppearance.BorderSize = 0;
			this.buttonLaunchRiotClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLaunchRiotClient.Location = new System.Drawing.Point(234, 12);
			this.buttonLaunchRiotClient.Name = "buttonLaunchRiotClient";
			this.buttonLaunchRiotClient.Size = new System.Drawing.Size(106, 46);
			this.buttonLaunchRiotClient.TabIndex = 4;
			this.buttonLaunchRiotClient.UseVisualStyleBackColor = false;
			this.buttonLaunchRiotClient.Click += new System.EventHandler(this.OnRiotClientLaunch);
			// 
			// checkboxRemember
			// 
			this.checkboxRemember.AutoSize = true;
			this.checkboxRemember.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.checkboxRemember.ForeColor = System.Drawing.Color.White;
			this.checkboxRemember.Location = new System.Drawing.Point(12, 64);
			this.checkboxRemember.Name = "checkboxRemember";
			this.checkboxRemember.Size = new System.Drawing.Size(91, 21);
			this.checkboxRemember.TabIndex = 5;
			this.checkboxRemember.Text = "Remember";
			this.checkboxRemember.UseVisualStyleBackColor = true;
			// 
			// comboStatus
			// 
			this.comboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboStatus.ForeColor = System.Drawing.Color.White;
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Location = new System.Drawing.Point(109, 64);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(114, 25);
			this.comboStatus.TabIndex = 6;
			// 
			// checkboxDefaultStatus
			// 
			this.checkboxDefaultStatus.AutoSize = true;
			this.checkboxDefaultStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.checkboxDefaultStatus.ForeColor = System.Drawing.Color.White;
			this.checkboxDefaultStatus.Location = new System.Drawing.Point(234, 64);
			this.checkboxDefaultStatus.Name = "checkboxDefaultStatus";
			this.checkboxDefaultStatus.Size = new System.Drawing.Size(108, 21);
			this.checkboxDefaultStatus.TabIndex = 7;
			this.checkboxDefaultStatus.Text = "Make Default";
			this.checkboxDefaultStatus.UseVisualStyleBackColor = true;
			// 
			// GamePromptForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(351, 98);
			this.Controls.Add(this.checkboxDefaultStatus);
			this.Controls.Add(this.comboStatus);
			this.Controls.Add(this.checkboxRemember);
			this.Controls.Add(this.buttonLaunchRiotClient);
			this.Controls.Add(this.buttonLaunchValorant);
			this.Controls.Add(this.buttonLaunchLoL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GamePromptForm";
			this.Text = "Deceive";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLaunchLoL;
        private System.Windows.Forms.Button buttonLaunchValorant;
        private System.Windows.Forms.Button buttonLaunchRiotClient;
        private System.Windows.Forms.CheckBox checkboxRemember;
		private System.Windows.Forms.ComboBox comboStatus;
		private System.Windows.Forms.CheckBox checkboxDefaultStatus;
    }
}