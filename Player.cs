using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    internal enum Rotation
    {
        Right,
        Left,
        Up,
        Down
    }

    public class Player
    {

        public Rectangle Collider;

        public bool Jumping;
        
        private Point _position;
        public int MoveSpeed { get; } = 10;
        public int JumpForce;
        private readonly int G = 10;

        public Player(Point position)
        {
            _position.X = position.X;
            _position.Y = position.Y;

            Collider = new Rectangle(position.X - 25, position.Y - 75, 50, 150);
        }

        public void Move(Keys value)
        {
            switch (value)
            {
                case Keys.A:
                    _position.X -= MoveSpeed;
                    Collider.X -= MoveSpeed;
                    break;
                case Keys.D:
                    _position.X += MoveSpeed;
                    Collider.X += MoveSpeed;
                    break;
                case Keys.Space:
                    Jumping = true;
                    Jump();
                    break;
            }
        }

        public void Jump()
        {
            if (Jumping)
            {
                Jumping = false;
                JumpForce = G;
            }

            Collider.Y -= JumpForce;
            _position.Y -= JumpForce;
            JumpForce -= 1;
        }
    }
}