namespace BurgerKiosk
{
    partial class frmKiosk
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKiosk));
            lblTitle = new Label();
            grpMenu = new GroupBox();
            picBulgogiBurger = new PictureBox();
            picChickenBurger = new PictureBox();
            picHamBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnClear = new Button();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.MenuHighlight;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(890, 128);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(picHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(68, 175);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(583, 761);
            grpMenu.TabIndex = 3;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(321, 317);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(229, 178);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picBulgogiBurger.TabIndex = 7;
            picBulgogiBurger.TabStop = false;
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(321, 535);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(229, 178);
            picChickenBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picChickenBurger.TabIndex = 9;
            picChickenBurger.TabStop = false;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(321, 99);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(229, 178);
            picHamBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picHamBurger.TabIndex = 8;
            picHamBurger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(27, 593);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(228, 63);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(27, 375);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(271, 63);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(27, 157);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(185, 63);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(714, 175);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(305, 511);
            grpOption.TabIndex = 4;
            grpOption.TabStop = false;
            grpOption.Text = "옵션 추가";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(15, 417);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(244, 63);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(15, 311);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(244, 63);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(15, 205);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(143, 63);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(15, 99);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(229, 63);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(1082, 175);
            grpOrder.Name = "grpOrder";
            grpOrder.RightToLeft = RightToLeft.No;
            grpOrder.Size = new Size(550, 611);
            grpOrder.TabIndex = 5;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(41, 491);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(344, 71);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOrder.ForeColor = Color.Blue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(41, 94);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(456, 358);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = SystemColors.ButtonFace;
            btnOrder.Location = new Point(1082, 842);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(286, 94);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(1387, 842);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(245, 94);
            btnClear.TabIndex = 2;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmKiosk
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 990);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblTitle);
            Name = "frmKiosk";
            Text = "Burger Kiosk v1.0";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picChickenBurger;
        private PictureBox picHamBurger;
        private CheckBox chkPotato;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnClear;
        private Label lblTotalCost;
    }
}
