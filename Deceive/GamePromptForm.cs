using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Deceive;

internal partial class GamePromptForm : Form
{
    [DllImport("DwmApi")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

    internal static LaunchGame SelectedGame = LaunchGame.Auto;

    private class StatusItem
    {
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public override string ToString() => Name;
    }

    internal GamePromptForm()
    {
        InitializeComponent();
        
        // Force dark mode properties on the combo box
        comboStatus.DrawMode = DrawMode.OwnerDrawFixed;
        comboStatus.FlatStyle = FlatStyle.Flat;
        comboStatus.BackColor = Color.FromArgb(45, 45, 48);
        comboStatus.ForeColor = Color.White;
        comboStatus.DrawItem += comboStatus_DrawItem;
    }

    private void OnFormLoad(object sender, EventArgs e)
    {
        Text = StartupHandler.DeceiveTitle;
        
        if (DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4) != 0)
        {
            DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4);
        }

        // Initialize status dropdown
        var items = new[]
        {
            new StatusItem { Name = "Online", Value = "chat" },
            new StatusItem { Name = "Offline", Value = "offline" },
            new StatusItem { Name = "Mobile", Value = "mobile" }
        };
        comboStatus.Items.AddRange(items);

        var startupStatus = Persistence.GetStartupStatus();
        string initialValue;

        if (startupStatus == "last")
        {
            var statusFile = Path.Combine(Persistence.DataDir, "status");
            initialValue = File.Exists(statusFile) ? File.ReadAllText(statusFile) : "offline";
        }
        else
        {
            initialValue = startupStatus;
        }

        var selected = items.FirstOrDefault(i => i.Value == initialValue) ?? items[0];
        comboStatus.SelectedItem = selected;
    }

    private void comboStatus_DrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index < 0) return;

        var combo = (ComboBox)sender;
        var item = (StatusItem)combo.Items[e.Index];

        // Background of the item
        var isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
        var backColor = isSelected ? Color.FromArgb(63, 63, 70) : combo.BackColor;
        
        using (var brush = new SolidBrush(backColor))
        {
            e.Graphics.FillRectangle(brush, e.Bounds);
        }

        // Text of the item
        using (var brush = new SolidBrush(combo.ForeColor))
        {
            // Center the text vertically a bit more nicely
            var textRect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            e.Graphics.DrawString(item.Name, e.Font, brush, textRect);
        }

        // Remove the default dotted focus rectangle which looks white/ugly on dark
        // e.DrawFocusRectangle(); 
    }

    private void OnLoLLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.LoL);

    private void OnLoRLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.LoR);

    private void OnValorantLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.VALORANT);

    private void OnLionLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.Lion);

    private void OnRiotClientLaunch(object sender, EventArgs e) => HandleLaunchChoiceAsync(LaunchGame.RiotClient);

    private void HandleLaunchChoiceAsync(LaunchGame game)
    {
        var selectedStatus = (StatusItem)comboStatus.SelectedItem;
        
        // Save the chosen status as the current status for this session
        var statusFile = Path.Combine(Persistence.DataDir, "status");
        File.WriteAllText(statusFile, selectedStatus.Value);

        if (checkboxDefaultStatus.Checked)
        {
            Persistence.SetStartupStatus(selectedStatus.Value);
        }

        if (checkboxRemember.Checked)
        {
            Persistence.SetDefaultLaunchGame(game);
        }

        SelectedGame = game;
        DialogResult = DialogResult.OK;
    }
}
