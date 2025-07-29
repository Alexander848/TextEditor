using System.Windows.Forms;

namespace TextEditorApplication
{
    partial class MainWindow
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
            mainTextBox = new TextBox();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            menuItemEdit = new ToolStripMenuItem();
            menuItemSettings = new ToolStripMenuItem();
            openFile = new ToolStripMenuItem();
            saveFile = new ToolStripMenuItem();
            saveAsFile = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainTextBox
            // 
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Dock = DockStyle.Fill;
            mainTextBox.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, menuItemEdit, menuItemSettings });
            menuStrip.Name = "menuStrip";
            menuStrip.Dock = DockStyle.Top;
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { openFile, saveFile, saveAsFile });
            fileMenu.Name = "fileMenu";
            fileMenu.Text = "File";
            // 
            // openFile
            // 
            openFile.Name = "openFile";
            openFile.Text = "Open";
            openFile.Click += OpenFile_Click;
            // 
            // saveFile
            // 
            saveFile.Name = "saveFile";
            saveFile.Text = "Save";
            saveFile.Click += SaveFile_Click;
            // 
            // saveAsFile
            // 
            saveAsFile.Name = "saveAsFile";
            saveAsFile.Text = "Save As";
            saveAsFile.Click += SaveAsFile_Click;
            // 
            // menuItemEdit
            // 
            menuItemEdit.Name = "menuItemEdit";
            menuItemEdit.Text = "Edit";
            // 
            // menuItemSettings
            // 
            menuItemSettings.Name = "menuItemSettings";
            menuItemSettings.Text = "Settings";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(Screen.PrimaryScreen.Bounds.Width/4*3, Screen.PrimaryScreen.Bounds.Height/4*3);
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(mainTextBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainWindow";
            Text = "Text Editor";
            Load += MainWindow_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mainTextBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem menuItemEdit;
        private ToolStripMenuItem menuItemSettings;
        private ToolStripMenuItem openFile;
        private ToolStripMenuItem saveFile;
        private ToolStripMenuItem saveAsFile;
    }
}
