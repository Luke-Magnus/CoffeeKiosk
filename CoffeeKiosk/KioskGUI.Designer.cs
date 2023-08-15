namespace CoffeeKiosk
{
    partial class KioskGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cappuccino = new System.Windows.Forms.Button();
            this.btn_Latte = new System.Windows.Forms.Button();
            this.btn_UseDecaf = new System.Windows.Forms.Button();
            this.btn_PourCoffee = new System.Windows.Forms.Button();
            this.lbl_UseDecaf = new System.Windows.Forms.Label();
            this.pan_CappuccinoCup = new System.Windows.Forms.Panel();
            this.img_LargeCup = new System.Windows.Forms.Panel();
            this.img_CoffeeShot_Capp = new System.Windows.Forms.Panel();
            this.img_Milk_Capp = new System.Windows.Forms.Panel();
            this.pan_Mug = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.img_MilkShot_Mug = new System.Windows.Forms.Panel();
            this.img_CoffeeShot_Mug = new System.Windows.Forms.Panel();
            this.pan_CappuccinoCup.SuspendLayout();
            this.img_LargeCup.SuspendLayout();
            this.pan_Mug.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cappuccino
            // 
            this.btn_Cappuccino.Location = new System.Drawing.Point(12, 11);
            this.btn_Cappuccino.Name = "btn_Cappuccino";
            this.btn_Cappuccino.Size = new System.Drawing.Size(75, 23);
            this.btn_Cappuccino.TabIndex = 0;
            this.btn_Cappuccino.Text = "Cappuccino";
            this.btn_Cappuccino.UseVisualStyleBackColor = true;
            this.btn_Cappuccino.Click += new System.EventHandler(this.btn_Cappuccino_Click);
            // 
            // btn_Latte
            // 
            this.btn_Latte.Location = new System.Drawing.Point(99, 11);
            this.btn_Latte.Name = "btn_Latte";
            this.btn_Latte.Size = new System.Drawing.Size(75, 23);
            this.btn_Latte.TabIndex = 1;
            this.btn_Latte.Text = "Latte";
            this.btn_Latte.UseVisualStyleBackColor = true;
            this.btn_Latte.Click += new System.EventHandler(this.btn_Latte_Click);
            // 
            // btn_UseDecaf
            // 
            this.btn_UseDecaf.Location = new System.Drawing.Point(12, 78);
            this.btn_UseDecaf.Name = "btn_UseDecaf";
            this.btn_UseDecaf.Size = new System.Drawing.Size(75, 23);
            this.btn_UseDecaf.TabIndex = 2;
            this.btn_UseDecaf.Text = "Use Decaf";
            this.btn_UseDecaf.UseVisualStyleBackColor = true;
            this.btn_UseDecaf.Click += new System.EventHandler(this.btn_UseDecaf_Click);
            // 
            // btn_PourCoffee
            // 
            this.btn_PourCoffee.Location = new System.Drawing.Point(12, 246);
            this.btn_PourCoffee.Name = "btn_PourCoffee";
            this.btn_PourCoffee.Size = new System.Drawing.Size(162, 23);
            this.btn_PourCoffee.TabIndex = 3;
            this.btn_PourCoffee.Text = "Pour Coffee";
            this.btn_PourCoffee.UseVisualStyleBackColor = true;
            this.btn_PourCoffee.Click += new System.EventHandler(this.btn_PourCoffee_Click);
            // 
            // lbl_UseDecaf
            // 
            this.lbl_UseDecaf.AutoSize = true;
            this.lbl_UseDecaf.Location = new System.Drawing.Point(106, 83);
            this.lbl_UseDecaf.Name = "lbl_UseDecaf";
            this.lbl_UseDecaf.Size = new System.Drawing.Size(32, 13);
            this.lbl_UseDecaf.TabIndex = 4;
            this.lbl_UseDecaf.Text = "False";
            // 
            // pan_CappuccinoCup
            // 
            this.pan_CappuccinoCup.Controls.Add(this.img_LargeCup);
            this.pan_CappuccinoCup.Location = new System.Drawing.Point(189, 11);
            this.pan_CappuccinoCup.Name = "pan_CappuccinoCup";
            this.pan_CappuccinoCup.Size = new System.Drawing.Size(200, 259);
            this.pan_CappuccinoCup.TabIndex = 5;
            this.pan_CappuccinoCup.Visible = false;
            // 
            // img_LargeCup
            // 
            this.img_LargeCup.BackColor = System.Drawing.SystemColors.Desktop;
            this.img_LargeCup.Controls.Add(this.img_Milk_Capp);
            this.img_LargeCup.Controls.Add(this.img_CoffeeShot_Capp);
            this.img_LargeCup.Location = new System.Drawing.Point(17, 67);
            this.img_LargeCup.Name = "img_LargeCup";
            this.img_LargeCup.Size = new System.Drawing.Size(159, 149);
            this.img_LargeCup.TabIndex = 0;
            // 
            // img_CoffeeShot_Capp
            // 
            this.img_CoffeeShot_Capp.BackColor = System.Drawing.Color.SaddleBrown;
            this.img_CoffeeShot_Capp.Location = new System.Drawing.Point(16, 92);
            this.img_CoffeeShot_Capp.Name = "img_CoffeeShot_Capp";
            this.img_CoffeeShot_Capp.Size = new System.Drawing.Size(128, 44);
            this.img_CoffeeShot_Capp.TabIndex = 1;
            // 
            // img_Milk_Capp
            // 
            this.img_Milk_Capp.BackColor = System.Drawing.Color.Wheat;
            this.img_Milk_Capp.Location = new System.Drawing.Point(16, 3);
            this.img_Milk_Capp.Name = "img_Milk_Capp";
            this.img_Milk_Capp.Size = new System.Drawing.Size(128, 83);
            this.img_Milk_Capp.TabIndex = 2;
            // 
            // pan_Mug
            // 
            this.pan_Mug.Controls.Add(this.panel2);
            this.pan_Mug.Location = new System.Drawing.Point(189, 10);
            this.pan_Mug.Name = "pan_Mug";
            this.pan_Mug.Size = new System.Drawing.Size(200, 259);
            this.pan_Mug.TabIndex = 6;
            this.pan_Mug.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.img_MilkShot_Mug);
            this.panel2.Controls.Add(this.img_CoffeeShot_Mug);
            this.panel2.Location = new System.Drawing.Point(17, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 210);
            this.panel2.TabIndex = 0;
            // 
            // img_MilkShot_Mug
            // 
            this.img_MilkShot_Mug.BackColor = System.Drawing.Color.Wheat;
            this.img_MilkShot_Mug.Location = new System.Drawing.Point(16, 19);
            this.img_MilkShot_Mug.Name = "img_MilkShot_Mug";
            this.img_MilkShot_Mug.Size = new System.Drawing.Size(128, 108);
            this.img_MilkShot_Mug.TabIndex = 2;
            // 
            // img_CoffeeShot_Mug
            // 
            this.img_CoffeeShot_Mug.BackColor = System.Drawing.Color.SaddleBrown;
            this.img_CoffeeShot_Mug.Location = new System.Drawing.Point(16, 153);
            this.img_CoffeeShot_Mug.Name = "img_CoffeeShot_Mug";
            this.img_CoffeeShot_Mug.Size = new System.Drawing.Size(128, 44);
            this.img_CoffeeShot_Mug.TabIndex = 1;
            // 
            // KioskGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 281);
            this.Controls.Add(this.pan_Mug);
            this.Controls.Add(this.pan_CappuccinoCup);
            this.Controls.Add(this.lbl_UseDecaf);
            this.Controls.Add(this.btn_PourCoffee);
            this.Controls.Add(this.btn_UseDecaf);
            this.Controls.Add(this.btn_Latte);
            this.Controls.Add(this.btn_Cappuccino);
            this.Name = "KioskGUI";
            this.Text = "Kiosk";
            this.pan_CappuccinoCup.ResumeLayout(false);
            this.img_LargeCup.ResumeLayout(false);
            this.pan_Mug.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cappuccino;
        private System.Windows.Forms.Button btn_Latte;
        private System.Windows.Forms.Button btn_UseDecaf;
        private System.Windows.Forms.Button btn_PourCoffee;
        private System.Windows.Forms.Label lbl_UseDecaf;
        private System.Windows.Forms.Panel pan_CappuccinoCup;
        private System.Windows.Forms.Panel img_LargeCup;
        private System.Windows.Forms.Panel img_Milk_Capp;
        private System.Windows.Forms.Panel img_CoffeeShot_Capp;
        private System.Windows.Forms.Panel pan_Mug;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel img_MilkShot_Mug;
        private System.Windows.Forms.Panel img_CoffeeShot_Mug;
    }
}

