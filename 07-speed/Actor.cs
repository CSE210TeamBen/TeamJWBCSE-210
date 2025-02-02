using System;

namespace _07_speed
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Actor
    {
        protected Point _position;
        protected Point _velocity;

        protected int _width = Constants.DEFAULT_SQUARE_SIZE;
        protected int _height = Constants.DEFAULT_SQUARE_SIZE;

        protected string _text = "";

        public Actor()
        {

        }

        public bool HasText()
        {
            return _text != "";
        }

        public bool HasBox()
        {
            return _width > 0 && _height > 0;
        }

        public string GetText()
        {
            return _text;
        }

        public int GetX()
        {
            return _position.GetX();
        }

        public int GetY()
        {
            return _position.GetY();
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public Point GetVelocity()
        {
            return _velocity;
        }

        public int GetLength()
        {
            int len = _text.Length;
            return len;
        }

        public void SetVelocity(Point newVelocity)
        {
            _velocity = newVelocity;
        }
        public void SetPosition(Point newPosition)
        {
            _position = newPosition;
        }

        /// <summary>
        /// Moves the actor forward one space according to the current
        /// velocity.
        /// </summary>
        public void MoveNext()
        {
            int x = _position.GetX();
            int y = _position.GetY();

            int newX = x+_velocity.GetX();
            int newY = y;

            if (newY < 0)
            {
                newY = Constants.MAX_Y;
            }

            _position = new Point(newX, newY);
        }

        public override string ToString()
        {
            return $"Position: ({_position.GetX()}, {_position.GetY()}), Velocity({_velocity.GetX()}, {_velocity.GetY()})";
        }

    }

}