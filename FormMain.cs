using SetPHPVersion;
using SQLServicesManager;

namespace WebTool;

public partial class FormMain : Form
{
    public FormMain()
    {
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Icon = Icon.ExtractAssociatedIcon(@"images\app.ico")!;
        InitializeComponent();
        // IsMdiContainer = true;
        LoadConfig();
        LoadForm();
    }
    void LoadForm()
    {
        FormService formService = new FormService();
        formService.FormBorderStyle = FormBorderStyle.None;
        formService.TopLevel = false;
        TabPageService.Controls.Add(formService);
        formService.Dock = DockStyle.Fill;
        formService.Show();
        //
        FormPHP formPHP = new FormPHP();
        formPHP.FormBorderStyle = FormBorderStyle.None;
        formPHP.TopLevel = false;
        TabPagePHP.Controls.Add(formPHP);
        formPHP.Dock = DockStyle.Fill;
        formPHP.Show();
    }
    public void LoadConfig()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "setting.ini");
        if (!File.Exists(path))
        {
            string configString =
            @"DefaultPhpPath=C:\xampp\php" + '\n'
            + @"PhpSearchPath=C:\php" + '\n'
            + @"MySQLServiceName=MYSQL80" + '\n'
            + @"MariaDBServiceName=MariaDB" + '\n'
            + @"MSSQLSQLServiceName=MSSQLSERVER";
            File.WriteAllText(path, configString);
        }
        var data = File.ReadAllText(path);
        if (data == null) return;
        var configData = data.Split('\n');
        foreach (var item in configData)
        {
            var configLine = item.Split('=');
            switch (configLine[0])
            {
                case "DefaultPhpPath":
                    AppConfig.DefaultPhpPath = configLine[1];
                    break;
                case "PhpSearchPath":
                    AppConfig.PhpSearchPath = configLine[1];
                    break;
                case "MySQLServiceName":
                    AppConfig.MySQLServiceName = configLine[1];
                    break;
                case "MariaDBServiceName":
                    AppConfig.MariaDBServiceName = configLine[1];
                    break;
                case "MSSQLSQLServiceName":
                    AppConfig.MSSQLSQLServiceName = configLine[1];
                    break;
                default: break;
            }
        }
    }
}
