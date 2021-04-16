using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public sealed partial class Form1 : Form
    {
        public Form1()
        {
            DoubleBuffered = true;
            ClientSize = new Size(1080, 920);
            var player = new Player(new Point(100, 100));
            var timer = new Timer {Interval = 1};


            timer.Tick += (sender, args) =>
            {
                player.Jump();

                if (player.Collider.Top + player.Collider.Height >= Size.Height)
                {
                    player.Collider.Y = Size.Height - player.Collider.Height;
                    player.Jumping = false;
                }

                Invalidate();
            };
            timer.Start();

            Paint += (sender, args) => { args.Graphics.FillRectangle(Brushes.Chocolate, player.Collider); };

            KeyDown += (sender, args) => { player.Move(args.KeyData); };
        }
    }
}