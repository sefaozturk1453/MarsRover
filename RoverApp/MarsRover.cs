using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp
{
    public class MarsRover
    {
        public (int,int) Position { get; set; }
        public (int,int) NextPosition { get; set; }
        public Directions Direction { get; set; }

        public MarsRover((int, int) position, Directions direction)
        {
            Position = position;
            Direction = direction;
        }
        public override string ToString()
        {
            var (x, y) = Position;
            return $"{x} {y} {Direction}";
        }


        public bool WillBeOut((int, int) terrainDimensions)
        {
            var (nextX, nextY) = NextPosition;
            var (maxWidth, maxHeight) = terrainDimensions;

            return nextX < 0 || maxWidth < nextX || nextY < 0 || maxHeight < nextY;
        }

        private (int, int) CalculateNextPosition()
        {
            var (x, y) = Position;
            return Direction switch
            {
                Directions.N => (x, y + 1),
                Directions.E => (x + 1, y),
                Directions.S => (x, y - 1),
                Directions.W => (x - 1, y),
                _ => (x, y)
            };
        }

        public void Turn(char turn)
        {
            var turnValue = turn switch
            {
                'R' => 1,
                'L' => -1,
                _ => 0
            };

            Direction = (Directions)((4 + (int)Direction + turnValue) % 4);
            NextPosition = CalculateNextPosition();
        }

        public void UpdatePosition()
        {
            Position = CalculateNextPosition();
            NextPosition = CalculateNextPosition();
        }

        public bool WillCollide(MarsRover otherRover)
        {
            return NextPosition == otherRover.Position;
        }

     
    }
}
