using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BurgerThing.UtilityNamespace;

namespace BurgerThing
{
    public partial class BurgerThingForm : Form
    {
        public  static readonly List<string>       ToppingsList = new List<string>();
        private static readonly List<RadioButton>    BunButtons = new List<RadioButton>();
        private static readonly List<RadioButton> BurgerButtons = new List<RadioButton>();
        private static readonly List<Burger>            Burgers = new List<Burger>();
        private static readonly Dictionary<TreeNode, Burger> burgerNodes = new Dictionary<TreeNode, Burger>();
        public static int ItemNumber;
        public BurgerThingForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            toppingCheckBoxes.CheckOnClick = true;
            BunButtons.Add(whiteBunRadio);
            BunButtons.Add(onionBunRadio);
            BunButtons.Add(ryeBunRadio);
            BunButtons.Add(wrapRadio);
            BurgerButtons.Add(realBurgerRadio);
            BurgerButtons.Add(stupidBurger);
            ToppingsList.Add(BurgerEnums.LETTUCE_STRING);
            ToppingsList.Add(BurgerEnums.TOMATO_STRING);
            ToppingsList.Add(BurgerEnums.ONION_STRING);
            ToppingsList.Add(BurgerEnums.PICKLES_STRING);
            ToppingsList.Add(BurgerEnums.CHEESE_STRING);
            ToppingsList.Add(BurgerEnums.BACON_STRING);
            ToppingsList.ForEach(s => toppingCheckBoxes.Items.Add(s));
            quitButton.Click += (sender, args) => Application.Exit();
            TreeNode tree = new TreeNode("Order");
            orderTree.Nodes.Add(tree);
            
            calcButton.Click += (sender, args) =>
            {
                List<BurgerEnums.Toppings> tops = new List<BurgerEnums.Toppings>();
                List<TreeNode> toppingNodes = new List<TreeNode>();
                RadioButton selectedBuger = null;
                RadioButton selectedBun = null;
                BurgerBuilder b = new BurgerBuilder();
                TreeNode orderNode = new TreeNode("Burger " + ItemNumber);
                foreach (string selectedItem in toppingCheckBoxes.CheckedItems)
                {
                    if (!Enum.TryParse(selectedItem, true, out BurgerEnums.Toppings topping)) continue;
                    tops.Add(topping);
                    toppingNodes.Add(new TreeNode(topping.GetDescription()));

                }
                BunButtons.ForEach((button1 =>
                {
                    if (button1.Checked)
                    {
                        selectedBun = button1;
                    }
                }));
                b.BugerToppings(tops);
                b.BunChoice(BurgerEnums.StrToBun(selectedBun.Text));
                BurgerButtons.ForEach((button =>
                {
                    if (button.Checked)
                    {
                        selectedBuger = button;
                    }
                } ));
                
                b.BurgerChoice(BurgerEnums.StrToBurger(selectedBuger.Text));
                b.BurgerCount(1);
                Burger burger = b.Build();
                Burgers.Add(burger);
                ItemNumber++;
                burgerNodes.Add(orderNode, burger);
                orderNode.Nodes.Add(new TreeNode("Burger ID", new[] {new TreeNode(burger.burgerId.ToString())}));
                orderNode.Nodes.Add(new TreeNode("Bun", new[] { new TreeNode(burger.bun.GetDescription()) }));
                orderNode.Nodes.Add(new TreeNode("Burger Meat", new []{new TreeNode(burger.TypeOfBurger.GetDescription())}));
                orderNode.Nodes.Add(new TreeNode("Toppings", toppingNodes.ToArray()));
                orderNode.Nodes.Add(new TreeNode("Price", new[] {new TreeNode(Burger.BurgerPrice(burger).ToString("C"))}));
                tree.Nodes.Add(orderNode);
                tree.Expand();
             };
            
            realBurgerRadio.Focus();
            totalButton.Click += (sender, args) =>
            {
                outputBox.Clear();
                outputBox.AppendText($"Total Price: {CalcPrice():C}");

            };
            deleteButton.Click += (sender, args) =>
            {
                List<TreeNode> selectednodes = new List<TreeNode>();
                foreach (TreeNode treeNode in tree.Nodes)
                {
                    if (treeNode.IsSelected)
                    {
                        selectednodes.Add(treeNode);
                    }
                }

                if (!orderTree.SelectedNode.Text.Equals("Order") 
                    && orderTree.SelectedNode.Text.Contains("Burger") 
                    && !orderTree.SelectedNode.Text.Equals("Burger Meat") 
                    && !orderTree.SelectedNode.Text.Equals("Burger ID"))
                {
                    burgerNodes.Remove(orderTree.SelectedNode);
                    orderTree.Nodes.Remove(orderTree.SelectedNode);
                } else if (orderTree.SelectedNode.Text.Equals("Order"))
                {
                    MessageBox.Show(@"You need to select a burger to remove!");
                }
                



            };
            while (true)
            {
                calcButton.PerformClick();
            }
            
        }
        

        public float CalcPrice()
        {
            float prices = 0.00f;
            burgerNodes.Values.ToList().ForEach((burger =>
            {
                prices += Burger.BurgerPrice(burger);

            }));
            return prices;
        }

    }
}
