using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method , AllowMultiple = true)]
public class Version : System.Attribute
{
    public string version { get; private set; }
    public Version(string version)
    {
        this.version = version;
    }
    public override string ToString()
    {
        return this.version.ToString(); ;
    }
}
