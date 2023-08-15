using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeKiosk
{
    public partial class KioskGUI : Form
    {
        public CoffeeBase currentCoffee;
        private bool useDecaf;
        private Panel currentPanel;

        public KioskGUI()
        {
            InitializeComponent();
            UpdateDecafLabel();
        }

#region GUI Interact
        private void btn_Cappuccino_Click(object sender, EventArgs e)
        {
            currentCoffee = new Cappuccino();
            UpdateCupGUI(pan_CappuccinoCup);
        }

        private void btn_Latte_Click(object sender, EventArgs e)
        {
            currentCoffee = new Latte();
            UpdateCupGUI(pan_Mug);
        }

        private void btn_UseDecaf_Click(object sender, EventArgs e)
        {
            useDecaf = !useDecaf;
            UpdateDecafLabel();
        }

        private void btn_PourCoffee_Click(object sender, EventArgs e)
        {
            PourCoffee();   
        }
#endregion

#region Methods
        private void PourCoffee()
        {
            currentCoffee.PourCoffee(useDecaf);
            currentCoffee = null;
        }
#endregion

#region GUI Update
        private void UpdateDecafLabel()
        {
            lbl_UseDecaf.Text = (useDecaf == false) ? "No Decaf" : "Decaf";
        }
        private void UpdateCupGUI(Panel targetPanel)
        {
            if(currentPanel != null)
                currentPanel.Visible = false;
            if (targetPanel != null)
            {
                currentPanel = targetPanel;
                currentPanel.Visible = true;
            }
        }
#endregion
    }
}
