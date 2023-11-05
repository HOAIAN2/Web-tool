namespace SQLServicesManager;
using System.ServiceProcess;

public partial class FormService : Form
{
    ServiceController mySQLService = new ServiceController(AppConfig.MySQLServiceName);
    ServiceController mariaDBService = new ServiceController(AppConfig.MariaDBServiceName);
    ServiceController msSQLService = new ServiceController(AppConfig.MSSQLSQLServiceName);
    public FormService()
    {
        InitializeComponent();
        this.PictureBoxMYSQL.Image = Image.FromFile(@"images\MySQL.png");
        this.PictureBoxMariaDB.Image = Image.FromFile(@"images\MariaDB.png");
        this.PictureBoxMSSQL.Image = Image.FromFile(@"images\MSSQL.png");
        LoadForm();
    }
    void LoadForm()
    {
        if (mySQLService.Status == ServiceControllerStatus.Stopped)
            ButtonMySQL.Text = "Start";
        else ButtonMySQL.Text = "Stop";
        //
        if (mariaDBService.Status == ServiceControllerStatus.Stopped)
            ButtonMariaDB.Text = "Start";
        else ButtonMariaDB.Text = "Stop";
        //
        if (msSQLService.Status == ServiceControllerStatus.Stopped)
            ButtonMSSQL.Text = "Start";
        else ButtonMSSQL.Text = "Stop";
    }
    private void ButtonMySQL_Click(System.Object? sender, System.EventArgs e)
    {
        if (ButtonMySQL.Text == "Start")
        {
            mySQLService.Start();
            mySQLService.WaitForStatus(ServiceControllerStatus.Running);
            ButtonMySQL.Text = "Stop";
        }
        else
        {
            mySQLService.Stop();
            mySQLService.WaitForStatus(ServiceControllerStatus.Stopped);
            ButtonMySQL.Text = "Start";
        }
    }

    private void ButtonMariaDB_Click(System.Object? sender, System.EventArgs e)
    {
        if (ButtonMariaDB.Text == "Start")
        {
            mariaDBService.Start();
            mariaDBService.WaitForStatus(ServiceControllerStatus.Running);
            ButtonMariaDB.Text = "Stop";
        }
        else
        {
            mariaDBService.Stop();
            mariaDBService.WaitForStatus(ServiceControllerStatus.Stopped);
            ButtonMariaDB.Text = "Start";
        }
    }

    private void ButtonMSSQL_Click(System.Object? sender, System.EventArgs e)
    {
        if (ButtonMSSQL.Text == "Start")
        {
            msSQLService.Start();
            msSQLService.WaitForStatus(ServiceControllerStatus.Running);
            ButtonMSSQL.Text = "Stop";
        }
        else
        {
            msSQLService.Stop();
            msSQLService.WaitForStatus(ServiceControllerStatus.Stopped);
            ButtonMSSQL.Text = "Start";
        }
    }
}
