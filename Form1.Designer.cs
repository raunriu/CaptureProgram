namespace ScreenShot
{
    partial class Form1
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.saveProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.captureListBox = new System.Windows.Forms.CheckedListBox();
            this.pathTLP = new System.Windows.Forms.TableLayoutPanel();
            this.pathChangeButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.buttonTLP = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.allSaveButton = new System.Windows.Forms.Button();
            this.formPanel.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.pathTLP.SuspendLayout();
            this.buttonTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.progressPanel);
            this.formPanel.Controls.Add(this.mainPanel);
            this.formPanel.Controls.Add(this.pathTLP);
            this.formPanel.Controls.Add(this.buttonTLP);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(384, 561);
            this.formPanel.TabIndex = 0;
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.saveProgressBar);
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressPanel.Location = new System.Drawing.Point(0, 461);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Padding = new System.Windows.Forms.Padding(3);
            this.progressPanel.Size = new System.Drawing.Size(384, 30);
            this.progressPanel.TabIndex = 3;
            // 
            // saveProgressBar
            // 
            this.saveProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveProgressBar.Location = new System.Drawing.Point(3, 3);
            this.saveProgressBar.Name = "saveProgressBar";
            this.saveProgressBar.Size = new System.Drawing.Size(378, 24);
            this.saveProgressBar.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.captureListBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(384, 491);
            this.mainPanel.TabIndex = 2;
            // 
            // captureListBox
            // 
            this.captureListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureListBox.FormattingEnabled = true;
            this.captureListBox.Location = new System.Drawing.Point(0, 0);
            this.captureListBox.Name = "captureListBox";
            this.captureListBox.Size = new System.Drawing.Size(384, 491);
            this.captureListBox.TabIndex = 0;
            // 
            // pathTLP
            // 
            this.pathTLP.ColumnCount = 2;
            this.pathTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.pathTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pathTLP.Controls.Add(this.pathChangeButton, 1, 0);
            this.pathTLP.Controls.Add(this.pathTextBox, 0, 0);
            this.pathTLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pathTLP.Location = new System.Drawing.Point(0, 491);
            this.pathTLP.Name = "pathTLP";
            this.pathTLP.RowCount = 1;
            this.pathTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pathTLP.Size = new System.Drawing.Size(384, 30);
            this.pathTLP.TabIndex = 1;
            // 
            // pathChangeButton
            // 
            this.pathChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathChangeButton.Location = new System.Drawing.Point(259, 3);
            this.pathChangeButton.Name = "pathChangeButton";
            this.pathChangeButton.Size = new System.Drawing.Size(122, 24);
            this.pathChangeButton.TabIndex = 1;
            this.pathChangeButton.Text = "저장 경로 변경";
            this.pathChangeButton.UseVisualStyleBackColor = true;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTextBox.Location = new System.Drawing.Point(3, 3);
            this.pathTextBox.MinimumSize = new System.Drawing.Size(0, 24);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(250, 24);
            this.pathTextBox.TabIndex = 2;
            // 
            // buttonTLP
            // 
            this.buttonTLP.ColumnCount = 3;
            this.buttonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTLP.Controls.Add(this.deleteButton, 2, 0);
            this.buttonTLP.Controls.Add(this.savebutton, 1, 0);
            this.buttonTLP.Controls.Add(this.allSaveButton, 0, 0);
            this.buttonTLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTLP.Location = new System.Drawing.Point(0, 521);
            this.buttonTLP.Name = "buttonTLP";
            this.buttonTLP.RowCount = 1;
            this.buttonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonTLP.Size = new System.Drawing.Size(384, 40);
            this.buttonTLP.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(259, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 34);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // savebutton
            // 
            this.savebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savebutton.Location = new System.Drawing.Point(131, 3);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(122, 34);
            this.savebutton.TabIndex = 1;
            this.savebutton.Text = "저장";
            this.savebutton.UseVisualStyleBackColor = true;
            // 
            // allSaveButton
            // 
            this.allSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSaveButton.Location = new System.Drawing.Point(3, 3);
            this.allSaveButton.Name = "allSaveButton";
            this.allSaveButton.Size = new System.Drawing.Size(122, 34);
            this.allSaveButton.TabIndex = 0;
            this.allSaveButton.Text = "모두 저장";
            this.allSaveButton.UseVisualStyleBackColor = true;
            this.allSaveButton.Click += new System.EventHandler(this.allSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.formPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.formPanel.ResumeLayout(false);
            this.progressPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.pathTLP.ResumeLayout(false);
            this.pathTLP.PerformLayout();
            this.buttonTLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel formPanel;
        private TableLayoutPanel buttonTLP;
        private Button deleteButton;
        private Button savebutton;
        private Button allSaveButton;
        private TableLayoutPanel pathTLP;
        private ProgressBar saveProgressBar;
        private Button pathChangeButton;
        private Panel mainPanel;
        private CheckedListBox captureListBox;
        private Panel progressPanel;
        private TextBox pathTextBox;
    }
}