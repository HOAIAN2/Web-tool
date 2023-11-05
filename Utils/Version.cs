public class Version
{
    public string? version;
    public string path;
    public Version(string? version, string path)
    {
        this.version = version;
        this.path = path;
    }
}
public class Setting
{
    public string defaultPath;
    public Setting(string defaultPath)
    {
        this.defaultPath = defaultPath;
    }
}