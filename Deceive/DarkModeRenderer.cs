using System.Drawing;
using System.Windows.Forms;

namespace Deceive
{
    /// <summary>
    /// A custom ToolStripProfessionalRenderer for rendering dark mode tool strips.
    /// </summary>
    public class DarkModeRenderer : ToolStripProfessionalRenderer
    {
        private readonly Color backColor = Color.FromArgb(32, 32, 32);
        private readonly Color selectedColor = Color.FromArgb(45, 45, 48);
        private readonly Color borderColor = Color.FromArgb(64, 64, 64);

        /// <summary>
        /// Initializes a new instance of the <see cref="DarkModeRenderer"/> class.
        /// </summary>
        public DarkModeRenderer() : base(new DarkModeColorTable())
        {
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderMenuItemBackground" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Enabled)
            {
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(selectedColor), new Rectangle(Point.Empty, e.Item.Size));
                    e.Graphics.DrawRectangle(new Pen(borderColor), new Rectangle(Point.Empty, new Size(e.Item.Size.Width - 1, e.Item.Size.Height - 1)));
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(backColor), new Rectangle(Point.Empty, e.Item.Size));
                }

                e.Item.ForeColor = Color.White;
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(backColor), new Rectangle(Point.Empty, e.Item.Size));
                e.Item.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderItemText" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemTextRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.Enabled)
            {
                e.TextColor = Color.White;
            }
            else
            {
                e.TextColor = Color.Gray;
            }
            base.OnRenderItemText(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderImageMargin" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.AffectedBounds);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderToolStripBorder" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDown)
            {
                e.Graphics.DrawRectangle(new Pen(borderColor), new Rectangle(Point.Empty, new Size(e.ToolStrip.Width - 1, e.ToolStrip.Height - 1)));
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderToolStripBackground" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.AffectedBounds);
        }
    }

    /// <summary>
    /// Provides custom color settings for dark mode rendering of tool strips.
    /// </summary>
    public class DarkModeColorTable : ProfessionalColorTable
    {
        private readonly Color backColor = Color.FromArgb(32, 32, 32);
        private readonly Color borderColor = Color.FromArgb(64, 64, 64);

        /// <summary>
        /// Gets the starting color of the gradient used in the MenuStrip.
        /// </summary>
        public override Color MenuStripGradientBegin => backColor;
        /// <summary>
        /// Gets the ending color of the gradient used in the MenuStrip.
        /// </summary>
        public override Color MenuStripGradientEnd => backColor;
        /// <summary>
        /// Gets the starting color of the gradient used when a menu item is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientBegin => backColor;
        /// <summary>
        /// Gets the ending color of the gradient used when a menu item is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientEnd => backColor;
        /// <summary>
        /// Gets the color of the border around a menu item.
        /// </summary>
        public override Color MenuItemBorder => backColor;
        /// <summary>
        /// Gets the color of the border around a menu.
        /// </summary>
        public override Color MenuBorder => backColor;
        /// <summary>
        /// Gets the color of the separator.
        /// </summary>
        public override Color SeparatorDark => Color.Gray;
    }
}
