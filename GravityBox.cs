using System;
using System.Drawing;

namespace Game
{
    public class GravityBox
    {
        public Rectangle Area;
        private Brush _color;
        private readonly DateTime _fallTime;
        private bool _falling = true;

        public GravityBox(Rectangle area, Brush color)
        {
            Area = area;
            _color = color;
            _fallTime = DateTime.Now;
        }

        public void Move()
        {
            if (!_falling) return;
            var seconds = _fallTime - DateTime.Now;
            var dY = 9.8d * Math.Pow(seconds.TotalSeconds, 2);
            Area.Y += (int) dY;
        }
        
        public Brush Color => _color;
    }
}