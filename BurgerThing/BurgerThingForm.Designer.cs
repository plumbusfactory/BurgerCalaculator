namespace BurgerThing
{
    partial class BurgerThingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurgerThingForm));
            this.titleBox = new System.Windows.Forms.TextBox();
            this.realBurgerRadio = new System.Windows.Forms.RadioButton();
            this.stupidBurger = new System.Windows.Forms.RadioButton();
            this.toppingCheckBoxes = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wrapRadio = new System.Windows.Forms.RadioButton();
            this.ryeBunRadio = new System.Windows.Forms.RadioButton();
            this.onionBunRadio = new System.Windows.Forms.RadioButton();
            this.whiteBunRadio = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.orderTree = new System.Windows.Forms.TreeView();
            this.totalButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(186, 12);
            this.titleBox.Multiline = true;
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(200, 32);
            this.titleBox.TabIndex = 32767;
            this.titleBox.Text = "HAMBURGER MENU";
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // realBurgerRadio
            // 
            this.realBurgerRadio.Checked = true;
            this.realBurgerRadio.Location = new System.Drawing.Point(6, 19);
            this.realBurgerRadio.Name = "realBurgerRadio";
            this.realBurgerRadio.Size = new System.Drawing.Size(171, 36);
            this.realBurgerRadio.TabIndex = 1;
            this.realBurgerRadio.TabStop = true;
            this.realBurgerRadio.Text = "Regular";
            this.realBurgerRadio.UseVisualStyleBackColor = true;
            // 
            // stupidBurger
            // 
            this.stupidBurger.Location = new System.Drawing.Point(6, 61);
            this.stupidBurger.Name = "stupidBurger";
            this.stupidBurger.Size = new System.Drawing.Size(171, 36);
            this.stupidBurger.TabIndex = 2;
            this.stupidBurger.Text = "Veggie";
            this.stupidBurger.UseVisualStyleBackColor = true;
            // 
            // toppingCheckBoxes
            // 
            this.toppingCheckBoxes.FormattingEnabled = true;
            this.toppingCheckBoxes.Location = new System.Drawing.Point(186, 195);
            this.toppingCheckBoxes.Name = "toppingCheckBoxes";
            this.toppingCheckBoxes.Size = new System.Drawing.Size(313, 139);
            this.toppingCheckBoxes.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.realBurgerRadio);
            this.groupBox1.Controls.Add(this.stupidBurger);
            this.groupBox1.Location = new System.Drawing.Point(186, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Burger Type";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(186, 340);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Add to order";
            this.calcButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(424, 340);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(186, 392);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(313, 104);
            this.outputBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 32768;
            this.textBox1.Text = "Please slect one";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wrapRadio);
            this.groupBox3.Controls.Add(this.ryeBunRadio);
            this.groupBox3.Controls.Add(this.onionBunRadio);
            this.groupBox3.Controls.Add(this.whiteBunRadio);
            this.groupBox3.Location = new System.Drawing.Point(392, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 129);
            this.groupBox3.TabIndex = 32770;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bun";
            // 
            // wrapRadio
            // 
            this.wrapRadio.AutoSize = true;
            this.wrapRadio.Location = new System.Drawing.Point(7, 97);
            this.wrapRadio.Name = "wrapRadio";
            this.wrapRadio.Size = new System.Drawing.Size(51, 17);
            this.wrapRadio.TabIndex = 3;
            this.wrapRadio.Text = "Wrap";
            this.wrapRadio.UseVisualStyleBackColor = true;
            // 
            // ryeBunRadio
            // 
            this.ryeBunRadio.AutoSize = true;
            this.ryeBunRadio.Location = new System.Drawing.Point(7, 74);
            this.ryeBunRadio.Name = "ryeBunRadio";
            this.ryeBunRadio.Size = new System.Drawing.Size(66, 17);
            this.ryeBunRadio.TabIndex = 2;
            this.ryeBunRadio.Text = "Rye Bun";
            this.ryeBunRadio.UseVisualStyleBackColor = true;
            // 
            // onionBunRadio
            // 
            this.onionBunRadio.AutoSize = true;
            this.onionBunRadio.Location = new System.Drawing.Point(7, 51);
            this.onionBunRadio.Name = "onionBunRadio";
            this.onionBunRadio.Size = new System.Drawing.Size(75, 17);
            this.onionBunRadio.TabIndex = 1;
            this.onionBunRadio.Text = "Onion Bun";
            this.onionBunRadio.UseVisualStyleBackColor = true;
            // 
            // whiteBunRadio
            // 
            this.whiteBunRadio.AutoSize = true;
            this.whiteBunRadio.Checked = true;
            this.whiteBunRadio.Location = new System.Drawing.Point(7, 27);
            this.whiteBunRadio.Name = "whiteBunRadio";
            this.whiteBunRadio.Size = new System.Drawing.Size(75, 17);
            this.whiteBunRadio.TabIndex = 0;
            this.whiteBunRadio.TabStop = true;
            this.whiteBunRadio.Text = "White Bun";
            this.whiteBunRadio.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 32772;
            this.textBox2.Text = "Total order";
            // 
            // orderTree
            // 
            this.orderTree.Location = new System.Drawing.Point(12, 60);
            this.orderTree.Name = "orderTree";
            this.orderTree.Size = new System.Drawing.Size(168, 427);
            this.orderTree.TabIndex = 32773;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(343, 340);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 32774;
            this.totalButton.Text = "Calc Total";
            this.totalButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 369);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 32775;
            this.textBox3.Text = "Price";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(267, 340);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 32776;
            this.deleteButton.Text = "Remove Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // BurgerThingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 499);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.orderTree);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toppingCheckBoxes);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BurgerThingForm";
            this.Text = "BurgerThingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton realBurgerRadio;
        private System.Windows.Forms.RadioButton stupidBurger;
        private System.Windows.Forms.CheckedListBox toppingCheckBoxes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton wrapRadio;
        private System.Windows.Forms.RadioButton ryeBunRadio;
        private System.Windows.Forms.RadioButton onionBunRadio;
        private System.Windows.Forms.RadioButton whiteBunRadio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TreeView orderTree;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button deleteButton;
    }
}

