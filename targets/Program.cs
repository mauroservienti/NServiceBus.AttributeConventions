using System.IO;
using System.Threading.Tasks;
using static Bullseye.Targets;
using static SimpleExec.Command;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var sdk = new DotnetSdkManager();
        var dotnet = await sdk.GetDotnetCliPath();

        Target("default", DependsOn("test"));

        Target("restore",
            Directory.EnumerateFiles("src", "*.sln", SearchOption.AllDirectories),
            solution => Run(dotnet, $"restore \"{solution}\""));
        
        Target("build", DependsOn("restore"),
            Directory.EnumerateFiles("src", "*.sln", SearchOption.AllDirectories),
            solution => Run(dotnet, $"build \"{solution}\" --no-restore --configuration Release"));

        Target("test", DependsOn("build"),
            Directory.EnumerateFiles("src", "*Tests.csproj", SearchOption.AllDirectories),
            proj => Run(dotnet, $"test \"{proj}\" --configuration Release --no-build"));
        
        await RunTargetsAndExitAsync(args);
    }
}
