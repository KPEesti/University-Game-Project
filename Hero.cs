using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms.VisualStyles;

namespace Game
{
    public class Hero
    {
        public GravityBox GravityBox;

        public Hero(Point position)
        {
            this.GravityBox = new GravityBox(new Rectangle(position, new Size(50, 150)), Brushes.Coral);
        }
    }
}