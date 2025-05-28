using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ToggleSwitch
{
    public class ToggleSwitch : CheckBox
    {
        // Properties var
        private Color onBackColor = Color.RoyalBlue;
        private Color onBtnColor = Color.White;
        private Color offBackColor = Color.DarkGray;
        private Color offBtnColor = Color.FromKnownColor(KnownColor.WindowFrame);
        private bool solidStyle = true;

        //Properties Fields
        [Category("ToggleButtons")]
        [DisplayName("Switch-On Back Color")]
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        [DisplayName("Switch-On Button Color")]
        public Color OnBtnColor
        {
            get
            {
                return onBtnColor; // Read actual color
            }
            set
            {
                onBtnColor = value;
                this.Invalidate(); // Write new color
            }
        }
        [DisplayName("Switch-Off Back Color")]
        public Color OffBackColor
        {
            get
            {
                return offBackColor; // Read actual color
            }
            set
            {
                offBackColor = value;   
                this.Invalidate();  // Write new color
            }
        }
        [DisplayName("Switch-Off Button Color")]
        public Color OffBtnColor
        {
            get
            {
                return offBtnColor; // Read actual color
            }
            set
            {
                offBtnColor = value;
                this.Invalidate(); // Write new color
            }
        }


        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                // Forces non-text written.
            }
        }

        [DefaultValue(true)]
        [DisplayName("Solid State")]
        public bool SolidStyle
        {
            get
            {
                return solidStyle;
            }
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        //Constructor
        public ToggleSwitch()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Clear
            pevent.Graphics.Clear(this.Parent.BackColor);

            int toggleSize = this.Height - 9;
            int toggleY = (this.Height - toggleSize) / 2;

            if (this.Checked) //On
            {
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                }

                pevent.Graphics.FillEllipse(new SolidBrush(onBtnColor),
                    new Rectangle(this.Width - this.Height +1, toggleY, toggleSize, toggleSize));
            }
            else //Off
            {
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                }

                pevent.Graphics.FillEllipse(new SolidBrush(offBtnColor),
                    new Rectangle(6, toggleY, toggleSize, toggleSize));
            }
        }
    }
}
