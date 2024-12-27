namespace Tyuiu.BrovkinAA.Sprint7.Project.V8
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons = new Panel();
            menuStripButtons = new MenuStrip();
            toolStripMenuLoadItem = new ToolStripMenuItem();
            toolStripMenuEmployeeInfoItem = new ToolStripMenuItem();
            toolStripMenuCarsInfoItem = new ToolStripMenuItem();
            toolStripMenuDeliveryInfoItem = new ToolStripMenuItem();
            toolStripMenuActionsItem = new ToolStripMenuItem();
            toolStripMenuAddDataItem = new ToolStripMenuItem();
            toolStripMenuDoneItem = new ToolStripMenuItem();
            toolStripMenuSaveItem = new ToolStripMenuItem();
            toolStripMenuInfoButtonItem = new ToolStripMenuItem();
            краткоеРуководствоToolStripMenuItem = new ToolStripMenuItem();
            panelLoadDataTop = new Panel();
            groupBoxLoadData = new GroupBox();
            dataGridViewLoadData = new DataGridView();
            splitterTopBottom = new Splitter();
            panelLoadDataLeft = new Panel();
            groupBoxInfoLeft = new GroupBox();
            dataGridViewDataLeft = new DataGridView();
            splitterBetweenTwoPanels = new Splitter();
            panelLoadDataRight = new Panel();
            groupBoxInfoRight = new GroupBox();
            dataGridViewDataRight = new DataGridView();
            toolTip = new ToolTip(components);
            panelButtons.SuspendLayout();
            menuStripButtons.SuspendLayout();
            panelLoadDataTop.SuspendLayout();
            groupBoxLoadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadData).BeginInit();
            panelLoadDataLeft.SuspendLayout();
            groupBoxInfoLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataLeft).BeginInit();
            panelLoadDataRight.SuspendLayout();
            groupBoxInfoRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataRight).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(menuStripButtons);
            panelButtons.Dock = DockStyle.Left;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(3);
            panelButtons.Size = new Size(93, 661);
            panelButtons.TabIndex = 0;
            // 
            // menuStripButtons
            // 
            menuStripButtons.Dock = DockStyle.Fill;
            menuStripButtons.Items.AddRange(new ToolStripItem[] { toolStripMenuLoadItem, toolStripMenuActionsItem, toolStripMenuDoneItem, toolStripMenuSaveItem, toolStripMenuInfoButtonItem });
            menuStripButtons.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStripButtons.Location = new Point(3, 3);
            menuStripButtons.Name = "menuStripButtons";
            menuStripButtons.Size = new Size(87, 655);
            menuStripButtons.TabIndex = 0;
            menuStripButtons.Text = "menuStrip1";
            // 
            // toolStripMenuLoadItem
            // 
            toolStripMenuLoadItem.AutoSize = false;
            toolStripMenuLoadItem.AutoToolTip = true;
            toolStripMenuLoadItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuLoadItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuEmployeeInfoItem, toolStripMenuCarsInfoItem, toolStripMenuDeliveryInfoItem });
            toolStripMenuLoadItem.Image = (Image)resources.GetObject("toolStripMenuLoadItem.Image");
            toolStripMenuLoadItem.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuLoadItem.Name = "toolStripMenuLoadItem";
            toolStripMenuLoadItem.Padding = new Padding(4);
            toolStripMenuLoadItem.Size = new Size(80, 80);
            toolStripMenuLoadItem.Text = "Load";
            toolStripMenuLoadItem.ToolTipText = "Открыть файл";
            // 
            // toolStripMenuEmployeeInfoItem
            // 
            toolStripMenuEmployeeInfoItem.Name = "toolStripMenuEmployeeInfoItem";
            toolStripMenuEmployeeInfoItem.Size = new Size(217, 22);
            toolStripMenuEmployeeInfoItem.Text = "Информация о водителях";
            toolStripMenuEmployeeInfoItem.Click += toolStripMenuEmployeeInfoItem_Click;
            // 
            // toolStripMenuCarsInfoItem
            // 
            toolStripMenuCarsInfoItem.Name = "toolStripMenuCarsInfoItem";
            toolStripMenuCarsInfoItem.Size = new Size(217, 22);
            toolStripMenuCarsInfoItem.Text = "Информация о машинах";
            toolStripMenuCarsInfoItem.Click += toolStripMenuCarsInfoItem_Click;
            // 
            // toolStripMenuDeliveryInfoItem
            // 
            toolStripMenuDeliveryInfoItem.Name = "toolStripMenuDeliveryInfoItem";
            toolStripMenuDeliveryInfoItem.Size = new Size(217, 22);
            toolStripMenuDeliveryInfoItem.Text = "Информация о доставках";
            toolStripMenuDeliveryInfoItem.Click += toolStripMenuDeliveryInfoItem_Click;
            // 
            // toolStripMenuActionsItem
            // 
            toolStripMenuActionsItem.AutoSize = false;
            toolStripMenuActionsItem.AutoToolTip = true;
            toolStripMenuActionsItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuActionsItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuAddDataItem });
            toolStripMenuActionsItem.Enabled = false;
            toolStripMenuActionsItem.Image = (Image)resources.GetObject("toolStripMenuActionsItem.Image");
            toolStripMenuActionsItem.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuActionsItem.Name = "toolStripMenuActionsItem";
            toolStripMenuActionsItem.Padding = new Padding(4);
            toolStripMenuActionsItem.Size = new Size(80, 80);
            toolStripMenuActionsItem.Text = "Action";
            toolStripMenuActionsItem.ToolTipText = "Доступные действия";
            // 
            // toolStripMenuAddDataItem
            // 
            toolStripMenuAddDataItem.Name = "toolStripMenuAddDataItem";
            toolStripMenuAddDataItem.Size = new Size(170, 22);
            toolStripMenuAddDataItem.Text = "Добавить данные";
            toolStripMenuAddDataItem.Click += toolStripMenuAddDataItem_Click;
            // 
            // toolStripMenuDoneItem
            // 
            toolStripMenuDoneItem.AutoSize = false;
            toolStripMenuDoneItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuDoneItem.Enabled = false;
            toolStripMenuDoneItem.Image = (Image)resources.GetObject("toolStripMenuDoneItem.Image");
            toolStripMenuDoneItem.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuDoneItem.Name = "toolStripMenuDoneItem";
            toolStripMenuDoneItem.Size = new Size(80, 80);
            toolStripMenuDoneItem.Text = "Done";
            toolStripMenuDoneItem.Click += toolStripMenuDoneItem_Click;
            // 
            // toolStripMenuSaveItem
            // 
            toolStripMenuSaveItem.AutoSize = false;
            toolStripMenuSaveItem.AutoToolTip = true;
            toolStripMenuSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuSaveItem.Enabled = false;
            toolStripMenuSaveItem.Image = (Image)resources.GetObject("toolStripMenuSaveItem.Image");
            toolStripMenuSaveItem.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuSaveItem.Name = "toolStripMenuSaveItem";
            toolStripMenuSaveItem.Padding = new Padding(4);
            toolStripMenuSaveItem.Size = new Size(80, 80);
            toolStripMenuSaveItem.Text = "Save";
            toolStripMenuSaveItem.ToolTipText = "Сохранить данные";
            toolStripMenuSaveItem.Click += toolStripMenuSaveItem_Click;
            // 
            // toolStripMenuInfoButtonItem
            // 
            toolStripMenuInfoButtonItem.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuInfoButtonItem.AutoSize = false;
            toolStripMenuInfoButtonItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuInfoButtonItem.DropDownItems.AddRange(new ToolStripItem[] { краткоеРуководствоToolStripMenuItem });
            toolStripMenuInfoButtonItem.Image = (Image)resources.GetObject("toolStripMenuInfoButtonItem.Image");
            toolStripMenuInfoButtonItem.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuInfoButtonItem.Name = "toolStripMenuInfoButtonItem";
            toolStripMenuInfoButtonItem.Size = new Size(80, 80);
            toolStripMenuInfoButtonItem.Text = "Info";
            toolStripMenuInfoButtonItem.ToolTipText = "Информация о программе";
            // 
            // краткоеРуководствоToolStripMenuItem
            // 
            краткоеРуководствоToolStripMenuItem.Name = "краткоеРуководствоToolStripMenuItem";
            краткоеРуководствоToolStripMenuItem.Size = new Size(190, 22);
            краткоеРуководствоToolStripMenuItem.Text = "Краткое руководство";
            краткоеРуководствоToolStripMenuItem.Click += toolStripMenuItemInformation_Click;
            // 
            // panelLoadDataTop
            // 
            panelLoadDataTop.Controls.Add(groupBoxLoadData);
            panelLoadDataTop.Dock = DockStyle.Top;
            panelLoadDataTop.Location = new Point(93, 0);
            panelLoadDataTop.Name = "panelLoadDataTop";
            panelLoadDataTop.Padding = new Padding(3);
            panelLoadDataTop.Size = new Size(1091, 515);
            panelLoadDataTop.TabIndex = 1;
            // 
            // groupBoxLoadData
            // 
            groupBoxLoadData.Controls.Add(dataGridViewLoadData);
            groupBoxLoadData.Dock = DockStyle.Fill;
            groupBoxLoadData.Location = new Point(3, 3);
            groupBoxLoadData.Name = "groupBoxLoadData";
            groupBoxLoadData.Padding = new Padding(5);
            groupBoxLoadData.Size = new Size(1085, 509);
            groupBoxLoadData.TabIndex = 0;
            groupBoxLoadData.TabStop = false;
            groupBoxLoadData.Text = "Данные из файла:";
            // 
            // dataGridViewLoadData
            // 
            dataGridViewLoadData.AllowUserToAddRows = false;
            dataGridViewLoadData.AllowUserToDeleteRows = false;
            dataGridViewLoadData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadData.Dock = DockStyle.Fill;
            dataGridViewLoadData.Location = new Point(5, 21);
            dataGridViewLoadData.Name = "dataGridViewLoadData";
            dataGridViewLoadData.Size = new Size(1075, 483);
            dataGridViewLoadData.TabIndex = 0;
            dataGridViewLoadData.CellMouseClick += dataGridViewLoadData_CellMouseClick;
            dataGridViewLoadData.CellValueChanged += dataGridViewLoadData_CellValueChanged;
            // 
            // splitterTopBottom
            // 
            splitterTopBottom.Dock = DockStyle.Top;
            splitterTopBottom.Location = new Point(93, 515);
            splitterTopBottom.Name = "splitterTopBottom";
            splitterTopBottom.Size = new Size(1091, 10);
            splitterTopBottom.TabIndex = 2;
            splitterTopBottom.TabStop = false;
            // 
            // panelLoadDataLeft
            // 
            panelLoadDataLeft.Controls.Add(groupBoxInfoLeft);
            panelLoadDataLeft.Dock = DockStyle.Left;
            panelLoadDataLeft.Location = new Point(93, 525);
            panelLoadDataLeft.Name = "panelLoadDataLeft";
            panelLoadDataLeft.Padding = new Padding(3);
            panelLoadDataLeft.Size = new Size(520, 136);
            panelLoadDataLeft.TabIndex = 3;
            // 
            // groupBoxInfoLeft
            // 
            groupBoxInfoLeft.Controls.Add(dataGridViewDataLeft);
            groupBoxInfoLeft.Dock = DockStyle.Fill;
            groupBoxInfoLeft.Location = new Point(3, 3);
            groupBoxInfoLeft.Name = "groupBoxInfoLeft";
            groupBoxInfoLeft.Padding = new Padding(5);
            groupBoxInfoLeft.Size = new Size(514, 130);
            groupBoxInfoLeft.TabIndex = 0;
            groupBoxInfoLeft.TabStop = false;
            groupBoxInfoLeft.Text = "Инфрмация:";
            // 
            // dataGridViewDataLeft
            // 
            dataGridViewDataLeft.AllowUserToAddRows = false;
            dataGridViewDataLeft.AllowUserToDeleteRows = false;
            dataGridViewDataLeft.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataLeft.Dock = DockStyle.Fill;
            dataGridViewDataLeft.Location = new Point(5, 21);
            dataGridViewDataLeft.Name = "dataGridViewDataLeft";
            dataGridViewDataLeft.Size = new Size(504, 104);
            dataGridViewDataLeft.TabIndex = 0;
            dataGridViewDataLeft.CellValueChanged += dataGridViewLeftData_CellValueChanged;
            // 
            // splitterBetweenTwoPanels
            // 
            splitterBetweenTwoPanels.Location = new Point(613, 525);
            splitterBetweenTwoPanels.Name = "splitterBetweenTwoPanels";
            splitterBetweenTwoPanels.Size = new Size(3, 136);
            splitterBetweenTwoPanels.TabIndex = 4;
            splitterBetweenTwoPanels.TabStop = false;
            // 
            // panelLoadDataRight
            // 
            panelLoadDataRight.Controls.Add(groupBoxInfoRight);
            panelLoadDataRight.Dock = DockStyle.Fill;
            panelLoadDataRight.Location = new Point(616, 525);
            panelLoadDataRight.Name = "panelLoadDataRight";
            panelLoadDataRight.Padding = new Padding(3);
            panelLoadDataRight.Size = new Size(568, 136);
            panelLoadDataRight.TabIndex = 5;
            // 
            // groupBoxInfoRight
            // 
            groupBoxInfoRight.Controls.Add(dataGridViewDataRight);
            groupBoxInfoRight.Dock = DockStyle.Fill;
            groupBoxInfoRight.Location = new Point(3, 3);
            groupBoxInfoRight.Name = "groupBoxInfoRight";
            groupBoxInfoRight.Padding = new Padding(5);
            groupBoxInfoRight.Size = new Size(562, 130);
            groupBoxInfoRight.TabIndex = 0;
            groupBoxInfoRight.TabStop = false;
            groupBoxInfoRight.Text = "Информация:";
            // 
            // dataGridViewDataRight
            // 
            dataGridViewDataRight.AllowUserToAddRows = false;
            dataGridViewDataRight.AllowUserToDeleteRows = false;
            dataGridViewDataRight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataRight.Dock = DockStyle.Fill;
            dataGridViewDataRight.Location = new Point(5, 21);
            dataGridViewDataRight.Name = "dataGridViewDataRight";
            dataGridViewDataRight.Size = new Size(552, 104);
            dataGridViewDataRight.TabIndex = 0;
            dataGridViewDataRight.CellValueChanged += dataGridViewRightData_CellValueChanged;
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panelLoadDataRight);
            Controls.Add(splitterBetweenTwoPanels);
            Controls.Add(panelLoadDataLeft);
            Controls.Add(splitterTopBottom);
            Controls.Add(panelLoadDataTop);
            Controls.Add(panelButtons);
            MainMenuStrip = menuStripButtons;
            MinimumSize = new Size(1200, 700);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бровкин А.А. | Проект";
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            menuStripButtons.ResumeLayout(false);
            menuStripButtons.PerformLayout();
            panelLoadDataTop.ResumeLayout(false);
            groupBoxLoadData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadData).EndInit();
            panelLoadDataLeft.ResumeLayout(false);
            groupBoxInfoLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataLeft).EndInit();
            panelLoadDataRight.ResumeLayout(false);
            groupBoxInfoRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataRight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private MenuStrip menuStripButtons;
        private ToolStripMenuItem toolStripMenuLoadItem;
        private ToolStripMenuItem toolStripMenuSaveItem;
        private ToolStripMenuItem toolStripMenuEmployeeInfoItem;
        private ToolStripMenuItem toolStripMenuCarsInfoItem;
        private ToolStripMenuItem toolStripMenuDeliveryInfoItem;
        private ToolStripMenuItem toolStripMenuActionsItem;
        private ToolStripMenuItem toolStripMenuInfoButtonItem;
        private Panel panelLoadDataTop;
        private Splitter splitterTopBottom;
        private Panel panelLoadDataLeft;
        private Splitter splitterBetweenTwoPanels;
        private GroupBox groupBoxLoadData;
        private Panel panelLoadDataRight;
        private DataGridView dataGridViewLoadData;
        private GroupBox groupBoxInfoLeft;
        private GroupBox groupBoxInfoRight;
        private DataGridView dataGridViewDataLeft;
        private DataGridView dataGridViewDataRight;
        private ToolTip toolTip;
        private ToolStripMenuItem краткоеРуководствоToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuAddDataItem;
        private ToolStripMenuItem toolStripMenuDoneItem;
    }
}
