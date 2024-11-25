namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        private bool drawRectangle = false;
        private bool drawEllipse = false;
        private bool drawLine = false;

        private Color selectedColor = Color.Black;
        private Font text = new Font("Arial", 30, FontStyle.Bold);
        private string displayText = string.Empty;
        private Point textPosition = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(selectedColor, 3);
            Brush brush = new SolidBrush(selectedColor);

            Rectangle rectangle = new Rectangle(50, 50, 100, 50);
            Rectangle ellipse = new Rectangle(100, 150, 100, 50);
            Point lineStart = new Point(200, 200);
            Point lineEnd = new Point(300, 250);

            if (drawRectangle)
            {
                g.DrawRectangle(pen, rectangle);
            }
            if (drawEllipse)
            {
                g.DrawEllipse(pen, ellipse);
            }
            if (drawLine)
            {
                g.DrawLine(pen, lineStart, lineEnd);
            }
            if (!string.IsNullOrEmpty(displayText))
            {
                g.DrawString(displayText, text, brush, textPosition);
            }

            pen.Dispose();
        }

        private void DrawRectangleBTN_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
            Invalidate();
        }

        private void DrawEllipseBTN_Click(object sender, EventArgs e)
        {
            drawEllipse = true;
            Invalidate();
        }

        private void DrawLineBTN_Click(object sender, EventArgs e)
        {
            drawLine = true;
            Invalidate();
        }
        private void ChooseColorBTN_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
        }
        private void AddTextBTN_Click(object sender, EventArgs e)
        {
            AddTextForm form = new AddTextForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                displayText = form.Text;
                textPosition = new Point(form.InputX, form.InputY);
                Invalidate();
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            drawRectangle = false;
            drawEllipse = false;
            drawLine = false;
            displayText = string.Empty;
            Invalidate();
        }

       
    }
}