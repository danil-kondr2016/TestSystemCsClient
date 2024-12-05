namespace TestSystemClient
{
    partial class SelectRoleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIAmOrganizator = new Button();
            btnIAmParticipant = new Button();
            SuspendLayout();
            // 
            // btnIAmOrganizator
            // 
            btnIAmOrganizator.Location = new Point(12, 12);
            btnIAmOrganizator.Name = "btnIAmOrganizator";
            btnIAmOrganizator.Size = new Size(244, 64);
            btnIAmOrganizator.TabIndex = 0;
            btnIAmOrganizator.Text = "Организатор";
            btnIAmOrganizator.UseVisualStyleBackColor = true;
            btnIAmOrganizator.Click += btnIAmOrganizator_Click;
            // 
            // btnIAmParticipant
            // 
            btnIAmParticipant.Location = new Point(12, 87);
            btnIAmParticipant.Name = "btnIAmParticipant";
            btnIAmParticipant.Size = new Size(244, 64);
            btnIAmParticipant.TabIndex = 1;
            btnIAmParticipant.Text = "Участник";
            btnIAmParticipant.UseVisualStyleBackColor = true;
            btnIAmParticipant.Click += btnIAmParticipant_Click;
            // 
            // SelectRoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 163);
            Controls.Add(btnIAmParticipant);
            Controls.Add(btnIAmOrganizator);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectRoleForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбрать роль";
            Load += SelectRoleForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnIAmOrganizator;
        private Button btnIAmParticipant;
    }
}
