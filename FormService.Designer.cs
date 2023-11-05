namespace SQLServicesManager;

partial class FormService
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
        this.PictureBoxMYSQL = new System.Windows.Forms.PictureBox();
        this.PictureBoxMariaDB = new System.Windows.Forms.PictureBox();
        this.PictureBoxMSSQL = new System.Windows.Forms.PictureBox();
        this.ButtonMySQL = new System.Windows.Forms.Button();
        this.ButtonMariaDB = new System.Windows.Forms.Button();
        this.ButtonMSSQL = new System.Windows.Forms.Button();
        this.LabelMySQL = new System.Windows.Forms.Label();
        this.LabelMariaDB = new System.Windows.Forms.Label();
        this.LabelMSSQL = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMYSQL)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMariaDB)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSSQL)).BeginInit();
        this.SuspendLayout();
        //
        // PictureBoxMYSQL
        //
        this.PictureBoxMYSQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.PictureBoxMYSQL.TabIndex = 2;
        this.PictureBoxMYSQL.Text = "MySQL";
        this.PictureBoxMYSQL.Location = new System.Drawing.Point(124, 40);
        //
        // PictureBoxMariaDB
        //
        this.PictureBoxMariaDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.PictureBoxMariaDB.TabIndex = 1;
        this.PictureBoxMariaDB.Text = "MariaDB";
        this.PictureBoxMariaDB.Location = new System.Drawing.Point(124, 132);
        //
        // PictureBoxMSSQL
        //
        this.PictureBoxMSSQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.PictureBoxMSSQL.TabIndex = 2;
        this.PictureBoxMSSQL.Text = "MSSQL";
        this.PictureBoxMSSQL.Location = new System.Drawing.Point(124, 232);
        //
        // ButtonMySQL
        //
        this.ButtonMySQL.Text = "Start";
        this.ButtonMySQL.Location = new System.Drawing.Point(492, 36);
        this.ButtonMySQL.Size = new System.Drawing.Size(112, 50);
        this.ButtonMySQL.TabIndex = 3;
        this.ButtonMySQL.Click += new System.EventHandler(ButtonMySQL_Click);
        //
        // ButtonMariaDB
        //
        this.ButtonMariaDB.Text = "Start";
        this.ButtonMariaDB.Location = new System.Drawing.Point(492, 132);
        this.ButtonMariaDB.Size = new System.Drawing.Size(112, 50);
        this.ButtonMariaDB.TabIndex = 4;
        this.ButtonMariaDB.Click += new System.EventHandler(ButtonMariaDB_Click);
        //
        // ButtonMSSQL
        //
        this.ButtonMSSQL.Text = "Start";
        this.ButtonMSSQL.Location = new System.Drawing.Point(492, 232);
        this.ButtonMSSQL.Size = new System.Drawing.Size(112, 50);
        this.ButtonMSSQL.TabIndex = 5;
        this.ButtonMSSQL.Click += new System.EventHandler(ButtonMSSQL_Click);
        //
        // LabelMySQL
        //
        this.LabelMySQL.AutoSize = true;
        this.LabelMySQL.Text = "MySQL";
        this.LabelMySQL.Location = new System.Drawing.Point(12, 48);
        this.LabelMySQL.Size = new System.Drawing.Size(79, 30);
        this.LabelMySQL.TabIndex = 6;
        //
        // LabelMariaDB
        //
        this.LabelMariaDB.AutoSize = true;
        this.LabelMariaDB.Text = "MariaDB";
        this.LabelMariaDB.Location = new System.Drawing.Point(8, 140);
        this.LabelMariaDB.Size = new System.Drawing.Size(93, 30);
        this.LabelMariaDB.TabIndex = 7;
        //
        // LabelMSSQL
        //
        this.LabelMSSQL.AutoSize = true;
        this.LabelMSSQL.Text = "MS SQL";
        this.LabelMSSQL.Location = new System.Drawing.Point(12, 240);
        this.LabelMSSQL.Size = new System.Drawing.Size(86, 30);
        this.LabelMSSQL.TabIndex = 8;
        //
        // form
        //
        this.Size = new System.Drawing.Size(680, 450);
        this.Text = "SQL Services Manager";
        this.Controls.Add(this.PictureBoxMYSQL);
        this.Controls.Add(this.PictureBoxMariaDB);
        this.Controls.Add(this.PictureBoxMSSQL);
        this.Controls.Add(this.ButtonMySQL);
        this.Controls.Add(this.ButtonMariaDB);
        this.Controls.Add(this.ButtonMSSQL);
        this.Controls.Add(this.LabelMySQL);
        this.Controls.Add(this.LabelMariaDB);
        this.Controls.Add(this.LabelMSSQL);
        ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMYSQL)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMariaDB)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSSQL)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.PictureBox PictureBoxMYSQL;
    private System.Windows.Forms.PictureBox PictureBoxMariaDB;
    private System.Windows.Forms.PictureBox PictureBoxMSSQL;
    private System.Windows.Forms.Button ButtonMySQL;
    private System.Windows.Forms.Button ButtonMariaDB;
    private System.Windows.Forms.Button ButtonMSSQL;
    private System.Windows.Forms.Label LabelMySQL;
    private System.Windows.Forms.Label LabelMariaDB;
    private System.Windows.Forms.Label LabelMSSQL;
}

// private void ButtonMySQL_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonMariaDB_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonMSSQL_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

