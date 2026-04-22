using System;
using System.IO;
using Newtonsoft.Json;

namespace Deceive;

internal static class Persistence
{
    internal static readonly string DataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Deceive");

    private static readonly string UpdateVersionPath = Path.Combine(DataDir, "updateVersionPrompted");
    private static readonly string DefaultLaunchGamePath = Path.Combine(DataDir, "launchGame");
    private static readonly string AppPreferencesPath = Path.Combine(DataDir, "appPreferences");

    static Persistence()
    {
        if (!Directory.Exists(DataDir))
            Directory.CreateDirectory(DataDir);
    }

    // Prompted update version.
    internal static string GetPromptedUpdateVersion() => File.Exists(UpdateVersionPath) ? File.ReadAllText(UpdateVersionPath) : string.Empty;

    internal static void SetPromptedUpdateVersion(string version) => File.WriteAllText(UpdateVersionPath, version);

    // Configured launch option.
    internal static LaunchGame GetDefaultLaunchGame()
    {
        if (!File.Exists(DefaultLaunchGamePath))
            return LaunchGame.Prompt;

        var contents = File.ReadAllText(DefaultLaunchGamePath);
        if (!Enum.TryParse(contents, true, out LaunchGame launchGame))
            launchGame = LaunchGame.Prompt;

        return launchGame;
    }

    internal static void SetDefaultLaunchGame(LaunchGame game) => File.WriteAllText(DefaultLaunchGamePath, game.ToString());

    internal static void SetAppPreference<T>(string key, T value)
    {
        var preferences = GetAppPreferences();
        preferences[key] = JsonConvert.SerializeObject(value);
        File.WriteAllText(AppPreferencesPath, JsonConvert.SerializeObject(preferences));
    }

    internal static T? GetAppPreference<T>(string key)
    {
        var preferences = GetAppPreferences();
        if (preferences.TryGetValue(key, out var value))
        {
            return JsonConvert.DeserializeObject<T?>(value);
        }
        return default(T);
    }

    private static System.Collections.Generic.Dictionary<string, string> GetAppPreferences()
    {
        if (!File.Exists(AppPreferencesPath))
            return new System.Collections.Generic.Dictionary<string, string>();

        var json = File.ReadAllText(AppPreferencesPath);
        return JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<string, string>>(json) ?? new System.Collections.Generic.Dictionary<string, string>();
    }
}
