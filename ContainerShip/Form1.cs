using ContainerShip.Logic;

namespace ContainerShip
{
    public partial class Form1 : Form
    {

        Ship ship;

        List<Container> containers = new List<Container>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            bool coolable = false;
            bool valuable = false;
            int weight = Convert.ToInt32(nupWeight.Value);



            if (cbCoolable.Checked)
            {
                coolable = true;
            }
            if (cbValuable.Checked)
            {
                valuable = true;
            }


            Container container = new Container(weight, valuable, coolable);

            for (int i = 0; i < nupAmount.Value; i++)
            {
                containers.Add(container);
                lbContainers.Items.Add(container);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ship = new Ship(Convert.ToInt32(nupLength.Value),
                          Convert.ToInt32(nupWidth.Value),
                          Convert.ToInt32(nupHeight.Value));

            lbContainers.Items.Clear();

            foreach (Container container in ship.DistributeContainers(containers))
            {
                lbContainers.Items.Add(container);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            ship = new Ship(Convert.ToInt32(nupLength.Value),
              Convert.ToInt32(nupWidth.Value),
              Convert.ToInt32(nupHeight.Value));

            lbContainers.Items.Clear();

            foreach (Container container in ship.DistributeContainers(containers))
            {
                lbContainers.Items.Add(container);
            }
        }
    }
}
