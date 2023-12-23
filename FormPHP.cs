using System.Diagnostics;

namespace SetPHPVersion;

public partial class FormPHP : Form
{
    string[] variables = { };
    List<Version> versions = new List<Version>();
    string defaultPath = AppConfig.DefaultPhpPath;
    string phpSearchPath = AppConfig.PhpSearchPath;
    string currentPathExe = "";
    string currentVersion = "";
    public FormPHP()
    {
        InitializeComponent();
        this.ComboBoxPHP.DropDownStyle = ComboBoxStyle.DropDownList;
        LoadForm();
    }
    private void LoadForm()
    {
        this.versions = GetAllPHPVersions();
        foreach (var version in versions)
        {
            ComboBoxPHP.Items.Add(version.version);
        }
        this.variables = GetAllVariables();
        this.currentVersion = GetCurrentVersion();
        this.ComboBoxPHP.Text = currentVersion;
        LabelCurrentVersion.Text = "Current version: " + currentVersion;
    }
    public string GetCurrentVersion()
    {
        string executableName = "php.exe";
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "where",
            Arguments = executableName,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        Process process = new Process { StartInfo = psi };
        process.Start();
        string path = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        if (!string.IsNullOrWhiteSpace(path))
        {
            path = path.Trim();
            this.currentPathExe = path;
        }
        else
        {
            variables = variables.Append(defaultPath).ToArray();
            variables.Append(defaultPath);
            DialogResult dialogResult = MessageBox.Show(
                $"'{executableName}' not found in the PATH variable. Set to Default Version?",
                "Warning",
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.Yes)
            {
                string result = string.Join(";", variables);
                Environment.SetEnvironmentVariable("Path", result, EnvironmentVariableTarget.Machine);
                MessageBox.Show("Success reset PHP version");
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }
        var versionInfo = FileVersionInfo.GetVersionInfo(path); // Will typically return "1.0.0.0" in your case
        if (versionInfo.FileVersion != null) return versionInfo.FileVersion;
        else return "";
    }
    public string[] GetAllVariables()
    {
        string[] variables = { };
        string? currentPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
        if (currentPath == null) return variables;
        return currentPath.Split(';');
    }
    public List<Version> GetAllPHPVersions()
    {
        string directoryPath = this.phpSearchPath;
        string[] directories;
        List<Version> versions = new List<Version>();
        try
        {
            directories = Directory.GetDirectories(directoryPath);
        }
        catch
        {
            Directory.CreateDirectory(this.phpSearchPath);
            return versions;
            // throw new Exception("Cannot Read PHP Directory");
        }
        foreach (var item in directories)
        {
            var exePath = item + @"\php.exe";
            var versionInfo = FileVersionInfo.GetVersionInfo(exePath); // Will typically return "1.0.0.0" in your case
            var version = new Version(versionInfo.FileVersion, item);
            versions.Add(version);
        }
        return versions;
    }
    public void OpenIniFile()
    {
        string filePath = this.currentPathExe.Replace("php.exe", "php.ini");
        try
        {
            if (!File.Exists(filePath)) File.Copy(this.currentPathExe.Replace("php.exe", "php.ini-development"), filePath);
            ProcessStartInfo psi = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true,
            };
            Process.Start(psi);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    private void SetVersion()
    {
        var version = ComboBoxPHP.Text;
        if (version == currentVersion) return;
        var newPath = new List<string>();
        string selectedPath = "";
        string selectedVersion = "";
        foreach (var item in versions)
        {
            if (item.version == version)
            {
                selectedPath = item.path;
                selectedVersion = item.version;
                break;
            }
        }
        foreach (var item in variables)
        {
            if (currentPathExe == item + @"\php.exe")
            {
                newPath.Add(selectedPath);
            }
            else newPath.Add(item);
        }
        string result = string.Join(";", newPath);
        Environment.SetEnvironmentVariable("Path", result, EnvironmentVariableTarget.Machine);
        MessageBox.Show("Success change PHP version to " + selectedVersion);
        Application.Exit();
    }
    private void ResetVersion()
    {
        var newPath = new List<string>();
        foreach (var item in variables)
        {
            if (currentPathExe == item + @"\php.exe")
            {
                newPath.Add(defaultPath);
            }
            else newPath.Add(item);
        }
        string result = string.Join(";", newPath);
        Environment.SetEnvironmentVariable("Path", result, EnvironmentVariableTarget.Machine);
        MessageBox.Show("Success reset PHP version");
        Application.Exit();
    }
    private void ButtonSave_Click(System.Object? sender, System.EventArgs e)
    {
        SetVersion();
    }
    private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
    {
        ResetVersion();
    }
    private void ButtonConfig_Click(System.Object? sender, System.EventArgs e)
    {
        OpenIniFile();
    }
}
