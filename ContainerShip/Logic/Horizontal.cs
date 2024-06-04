using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip.Logic
{
    public class Horizontal
    {
        private List<Vertical> columns = new List<Vertical>();

        public int Width { get; private set; }
        public RowSide Side { get; private set; }
        public int MaxHeight { get; private set; }


        public enum RowSide
        {
            Left = 1,
            Centre = 2,
            Right = 3,
        }

        public Horizontal(int width, int side, int maxHeight)
        {
            Width = width;
            MaxHeight = maxHeight;
            Side = (RowSide)side;
        }

        public bool TryAddContainer(Container container)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                if (columns[i].TryAddContainerToColumn(container))
                {
                    if (ValuableContainerReservationCheck(container, i))
                    {
                        return true;
                    }

                    return true;
                }
            }
            return false;
        }


        private bool ValuableContainerReservationCheck(Container container, int index)
        {
            if (container.Valuable)
            {
                if (columns[index].IsBack || columns[index].IsFront)
                {
                    return true;
                }
                else if (!columns[(index - 1)].Reserved_ForValuable && (index + 1) < (columns.Count))
                {
                    columns[index + 1].SetReserved();
                    return true;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
