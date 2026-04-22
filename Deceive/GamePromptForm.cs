using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Deceive;

internal partial class GamePromptForm : Form
{
    [DllImport("DwmApi")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

    internal static LaunchGame SelectedGame = LaunchGame.Auto;
    internal static bool IsOnline = false;

    internal GamePromptForm() => InitializeComponent();

    private void OnFormLoad(object sender, EventArgs e)
    {
        Text = StartupHandler.DeceiveTitle;
        checkboxOnline.Checked = Persistence.GetAppPreference<bool?>("StartOnline") ?? false;
        if (DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4) != 0)
        {
            DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4);
        }
    }

    private void OnLoLLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.LoL);

    private void OnLoRLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.LoR);

    private void OnValorantLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.VALORANT);

    private void OnLionLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.Lion);

    private void OnRiotClientLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.RiotClient);

    private void HandleLaunchChoiceAsync(LaunchGame game)
    {
        if (checkboxRemember.Checked)
        {
            Persistence.SetDefaultLaunchGame(game);
            Persistence.SetAppPreference("StartOnline", checkboxOnline.Checked);
        }

        SelectedGame = game;
        IsOnline = checkboxOnline.Checked;
        DialogResult = DialogResult.OK;
    }
}
