using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip.Logic
{
    public class Vertical
    {
        List<Container> containers = new List<Container>();

        public int MaxWeight { get; private set; } = 150;
        public int MaxHeight { get; private set; }
        public int CurrentWeight { get; private set; }
        public bool IsFull { get; private set; } = false;
        public bool Reserved_ForValuable { get; private set; } = false;
        public bool IsFront { get; private set; }
        public bool IsBack { get; private set; }
        public int Position { get; private set; }


        public Vertical(int maxHeight, bool isFront, bool isBack)
        {
            MaxHeight = maxHeight;
            IsFront = isFront;
            IsBack = isBack;
        }


        public bool TryAddContainerToColumn(Container container)
        {
            if (Reserved_ForValuable)
            {
                return false;
            }

            if (container.Coolable && Position > 0)
            {
                return false;
            }

            if ((CurrentWeight + container.Weight) <= MaxWeight)
            {
                if (container.Valuable)
                {
                    if (containers.Count == 0)
                    {
                        containers.Add(container);

                    }
                    else
                    {
                        if (!containers[(containers.Count - 1)].Valuable)
                        {
                            containers.Add(container);

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    containers.Insert(0, container);
                }

                CurrentWeight += container.Weight;

                if ((CurrentWeight + container.MinWeight) >= MaxWeight)
                {
                    IsFull = true;
                }

                return true;
            }

            return false;

        }


        public void SetReserved()
        {
            Reserved_ForValuable = true;
        }
    }
}
