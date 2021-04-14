using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public sealed partial class Form1 : Form
    {
        public Form1()
        {
            DoubleBuffered = true;
            ClientSize = new Size(600, 600);
            var hero = new Hero(new Point(100, 100));
            var timer = new Timer() {Interval = 1};

            timer.Tick += (sender, args) =>
            {
                hero.GravityBox.Move();
                Invalidate();
            };
            timer.Start();

            Paint += (sender, args) =>
            {
                args.Graphics.FillRectangle(hero.GravityBox.Color, hero.GravityBox.Area);
            };

            KeyDown += (sender, args) =>
            {
                switch (args.KeyData)
                {
                    case Keys.S:
                        hero.GravityBox.Area.Y += 5;
                        break;
                    case Keys.W:
                        hero.GravityBox.Area.Y -= 5;
                        break;
                    case Keys.A:
                        hero.GravityBox.Area.X -= 5;
                        break;
                    case Keys.D:
                        hero.GravityBox.Area.X += 5;
                        break;
                }
            };
            InitializeComponent();
        }
    }
}