using SaveTheCommunism.Utilities;
using System;

namespace SaveTheCommunism.Model
{
    public class Enemy : Character
    {
        public Enemy(int health, int damage, Vector position, int speed, Directions initialMoveDirection)
            : base(health, damage, position, new Vector(speed, speed), initialMoveDirection)
        {
        }

        public Enemy(int health, int damage, int x, int y, int speed, Directions initialMoveDirection)
            : base(health, damage, new Vector(x, y), new Vector(speed, speed), initialMoveDirection)
        {
        }

        public void Move(Vector playerPosition)
        {
            var deltaX = Math.Abs(playerPosition.X - Position.X);
            var deltaY = Math.Abs(playerPosition.Y - Position.Y);

            if (Position.X < playerPosition.X && Position.Y < playerPosition.Y)
            {
                if (deltaX > deltaY)
                    MoveDirection = Directions.Right;
                else if (deltaX == deltaY)
                    MoveDirection = Directions.RightDown;
                else
                    MoveDirection = Directions.Down;
            }

            if (Position.X < playerPosition.X && Position.Y >= playerPosition.Y)
            {
                if (deltaX > deltaY)
                    MoveDirection = Directions.Right;
                else if (deltaX == deltaY)
                    MoveDirection = Directions.RightUp;
                else
                    MoveDirection = Directions.Up;
            }

            if (Position.X >= playerPosition.X && Position.Y < playerPosition.Y)
            {
                if (deltaX > deltaY)
                    MoveDirection = Directions.Left;
                else if (deltaX == deltaY)
                    MoveDirection = Directions.LeftDown;
                else
                    MoveDirection = Directions.Down;
            }

            if (Position.X >= playerPosition.X && Position.Y >= playerPosition.Y)
            {
                if (deltaX > deltaY)
                    MoveDirection = Directions.Left;
                else if (deltaX == deltaY)
                    MoveDirection = Directions.LeftUp;
                else
                    MoveDirection = Directions.Up;
            }

            if (deltaX == 0 && deltaY == 0)
                MoveDirection = Directions.None;

            Move();
        }
    }
}