using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class CustomTextBox : TextBox
{
    private string placeholderText = "";
    private Color placeholderColor = Color.Gray;
    private bool isPlaceholderActive = false;
    private int borderRadius = 15;
    private Color backgroundColor = Color.White;

    [Category("Custom Features")]
    public string PlaceholderText
    {
        get { return placeholderText; }
        set { placeholderText = value; Invalidate(); }
    }

    [Category("Custom Features")]
    public Color PlaceholderColor
    {
        get { return placeholderColor; }
        set { placeholderColor = value; Invalidate(); }
    }

    [Category("Custom Features")]
    public int BorderRadius
    {
        get { return borderRadius; }
        set { borderRadius = value; Invalidate(); }
    }

    [Category("Custom Features")]
    public Color BackgroundColor
    {
        get { return backgroundColor; }
        set { backgroundColor = value; Invalidate(); }
    }

    public CustomTextBox()
    {
        // Set default properties
        SetStyle(ControlStyles.UserPaint, true);
        this.BackColor = Color.White;
        this.BorderStyle = BorderStyle.None;

        // Handle placeholder events
        this.Enter += RemovePlaceholder;
        this.Leave += SetPlaceholder;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw background with border radius
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(backgroundColor), path);

            // Draw placeholder text if empty
            if (isPlaceholderActive)
            {
                TextRenderer.DrawText(e.Graphics, placeholderText, Font, ClientRectangle, placeholderColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        if (this.Text == "")
        {
            isPlaceholderActive = true;
            Invalidate();
        }
        else
        {
            isPlaceholderActive = false;
        }
    }

    private void RemovePlaceholder(object sender, EventArgs e)
    {
        if (isPlaceholderActive)
        {
            this.Text = "";
            this.ForeColor = SystemColors.WindowText;
        }
    }

    private void SetPlaceholder(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(this.Text))
        {
            isPlaceholderActive = true;
            this.Text = placeholderText;
            this.ForeColor = placeholderColor;
        }
    }
}
