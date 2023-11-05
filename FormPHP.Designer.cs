namespace SetPHPVersion;

partial class FormPHP
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
        this.ComboBoxPHP = new System.Windows.Forms.ComboBox();
        this.ButtonSave = new System.Windows.Forms.Button();
        this.LabelCurrentVersion = new System.Windows.Forms.Label();
        this.ButtonReset = new System.Windows.Forms.Button();
        this.LabelSelect = new System.Windows.Forms.Label();
        this.ButtonConfig = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // ComboBoxPHP
        //
        this.ComboBoxPHP.DropDownWidth = 192;
        this.ComboBoxPHP.Text =  "ComboBox0";
        this.ComboBoxPHP.Location = new System.Drawing.Point(240,40);
        this.ComboBoxPHP.Size = new System.Drawing.Size(224,38);
        //
        // ButtonSave
        //
        this.ButtonSave.Text =  "Save";
        this.ButtonSave.Location = new System.Drawing.Point(492,40);
        this.ButtonSave.Size = new System.Drawing.Size(112,40);
        this.ButtonSave.TabIndex = 1;
        this.ButtonSave.Click += new System.EventHandler(ButtonSave_Click);
        //
        // LabelCurrentVersion
        //
        this.LabelCurrentVersion.AutoSize =  true;
        this.LabelCurrentVersion.Text =  "Current version";
        this.LabelCurrentVersion.Location = new System.Drawing.Point(20,324);
        this.LabelCurrentVersion.Size = new System.Drawing.Size(154,30);
        this.LabelCurrentVersion.TabIndex = 2;
        //
        // ButtonReset
        //
        this.ButtonReset.Text =  "Reset";
        this.ButtonReset.Location = new System.Drawing.Point(492,148);
        this.ButtonReset.Size = new System.Drawing.Size(112,40);
        this.ButtonReset.TabIndex = 3;
        this.ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
        //
        // LabelSelect
        //
        this.LabelSelect.AutoSize =  true;
        this.LabelSelect.Text =  "Select PHP Versions";
        this.LabelSelect.Location = new System.Drawing.Point(28,40);
        this.LabelSelect.Size = new System.Drawing.Size(196,30);
        this.LabelSelect.TabIndex = 4;
        //
        // ButtonConfig
        //
        this.ButtonConfig.Text =  "Config";
        this.ButtonConfig.Location = new System.Drawing.Point(492,96);
        this.ButtonConfig.Size = new System.Drawing.Size(112,40);
        this.ButtonConfig.TabIndex = 5;
        this.ButtonConfig.Click += new System.EventHandler(ButtonConfig_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(680,450);
        this.Text =  "PHP Version";
        this.Controls.Add(this.ComboBoxPHP);
        this.Controls.Add(this.ButtonSave);
        this.Controls.Add(this.LabelCurrentVersion);
        this.Controls.Add(this.ButtonReset);
        this.Controls.Add(this.LabelSelect);
        this.Controls.Add(this.ButtonConfig);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.ComboBox ComboBoxPHP;
    private System.Windows.Forms.Button ButtonSave;
    private System.Windows.Forms.Label LabelCurrentVersion;
    private System.Windows.Forms.Button ButtonReset;
    private System.Windows.Forms.Label LabelSelect;
    private System.Windows.Forms.Button ButtonConfig;
}

// private void ButtonSave_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonConfig_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

