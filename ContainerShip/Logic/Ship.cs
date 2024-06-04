using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip.Logic
{
    public class Ship
    {
        Vertical column;

        private List<Horizontal> RowList = new List<Horizontal>();
        public List<Container> sortedContainers = new List<Container>();
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int MaxWeigth { get; private set; }
        public int MinWeigth { get; private set; }
        public int MaxHeight { get; private set; }


        private int WeightLeft;
        private int WeightCenter;
        private int WeightRight;
        private int TotalWeight;

        public Ship(int length, int width, int maxHeight)
        {
            Width = length;
            Length = width;
            MaxWeigth = (length * width) * 150;
            MinWeigth = MaxWeigth / 2;
            MaxHeight = maxHeight;
        }

        public List<Container> DistributeContainers(List<Container> containers)
        {
            sortedContainers = containers.OrderByDescending(t => t.Weight).ToList();
            return sortedContainers;
        }

    }
}