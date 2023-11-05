namespace WebTool;

partial class FormMain
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
        this.TabControl = new System.Windows.Forms.TabControl();
        this.TabPagePHP = new System.Windows.Forms.TabPage();
        this.TabPageService = new System.Windows.Forms.TabPage();
        this.TabControl.SuspendLayout();
        this.TabPagePHP.SuspendLayout();
        this.TabPageService.SuspendLayout();
        this.SuspendLayout();
        //
        // TabControl
        //
        this.TabControl.Controls.Add(this.TabPagePHP);
        this.TabControl.Controls.Add(this.TabPageService);
        this.TabControl.ItemSize = new System.Drawing.Size(134,35);
        this.TabControl.SelectedIndex = 0;
        this.TabControl.Text =  "TabControl6";
        this.TabControl.Location = new System.Drawing.Point(8,12);
        this.TabControl.Size = new System.Drawing.Size(628,408);
        this.TabControl.TabIndex = 6;
        //
        // TabPagePHP
        //
        this.TabPagePHP.Location = new System.Drawing.Point(4,39);
        this.TabPagePHP.TabIndex = 7;
        this.TabPagePHP.Text =  "PHP Versions";
        this.TabPagePHP.Size = new System.Drawing.Size(620,365);
        //
        // TabPageService
        //
        this.TabPageService.Location = new System.Drawing.Point(4,39);
        this.TabPageService.TabIndex = 8;
        this.TabPageService.Text =  "SQL Services";
        this.TabPageService.Size = new System.Drawing.Size(536,281);
     //
     // form
     //
        this.Size = new System.Drawing.Size(684,500);
        this.Text =  "Web Tool";
        this.Controls.Add(this.TabControl);
        this.TabControl.ResumeLayout(false);
        this.TabPagePHP.ResumeLayout(false);
        this.TabPageService.ResumeLayout(false);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.TabControl TabControl;
    private System.Windows.Forms.TabPage TabPagePHP;
    private System.Windows.Forms.TabPage TabPageService;
}

