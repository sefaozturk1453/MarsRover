using System;
using System.Collections.Generic;
using System.Linq;

namespace RoverApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int roverCount = 2; //Hareket edecek araç sayısı.
            
            //Platonon sınırları belirlenir.
            var dimensions = Console.ReadLine().Split().Select(numberStr => Convert.ToInt32(numberStr)).ToList();

            var terrainDimensions = (dimensions[0], dimensions[1]);

            var previousRovers = new List<MarsRover>();

            for (int i = 0; i < roverCount; i++)
            {
                var roverPositionStr = Console.ReadLine();
                var route = Console.ReadLine();
                var positionInfo = roverPositionStr.Split();

                var position = (Convert.ToInt32(positionInfo[0]), Convert.ToInt32(positionInfo[1]));
                var direction = Enum.Parse<Directions>(positionInfo[2]);

                var rover = new MarsRover(position, direction);
                StartRover(rover, route, terrainDimensions, previousRovers);
                previousRovers.Add(rover);
            }

            Console.WriteLine("---------egebimtes Case--------");
        }


        public static void StartRover(MarsRover rover, string route, (int, int) terrainDimensions, List<MarsRover> obstacleRovers)
        {
            var (maxWidth, maxHeight) = terrainDimensions;

            foreach (var letter in route)
            {
                if (letter == 'M')
                {
                    if (rover.WillBeOut(terrainDimensions))
                        continue;
                    if (WillRoversCollide(rover, obstacleRovers))
                        continue;

                    rover.UpdatePosition();
                }
                else
                    rover.Turn(letter);
            }

            Console.WriteLine(rover);
        }

        private static bool WillRoversCollide(MarsRover rover, IReadOnlyCollection<MarsRover> obstacleRovers)
        {
            return obstacleRovers.Count != 0 && obstacleRovers.Any(rover.WillCollide);
        }

    }
}
