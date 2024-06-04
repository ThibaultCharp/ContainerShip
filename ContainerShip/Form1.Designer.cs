using System.Windows.Forms;

namespace ContainerShip
{
    partial class Form1
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
            lblWidth = new Label();
            nupLength = new NumericUpDown();
            nupWidth = new NumericUpDown();
            lblLength = new Label();
            btnAddContainer = new Button();
            nupWeight = new NumericUpDown();
            lblWeight = new Label();
            gbBoatControls = new GroupBox();
            buttonRun = new Button();
            lblHeight = new Label();
            nupHeight = new NumericUpDown();
            gbContainerControls = new GroupBox();
            cbCoolable = new CheckBox();
            cbValuable = new CheckBox();
            nupAmount = new NumericUpDown();
            label1 = new Label();
            lblType = new Label();
            lbContainers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nupLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupWeight).BeginInit();
            gbBoatControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupHeight).BeginInit();
            gbContainerControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupAmount).BeginInit();
            SuspendLayout();
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(37, 72);
            lblWidth.Margin = new Padding(6, 0, 6, 0);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(78, 32);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Width";
            // 
            // nupLength
            // 
            nupLength.Location = new Point(44, 110);
            nupLength.Margin = new Padding(6, 8, 6, 8);
            nupLength.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            nupLength.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nupLength.Name = "nupLength";
            nupLength.Size = new Size(125, 39);
            nupLength.TabIndex = 3;
            nupLength.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // nupWidth
            // 
            nupWidth.Location = new Point(41, 218);
            nupWidth.Margin = new Padding(6, 8, 6, 8);
            nupWidth.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            nupWidth.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nupWidth.Name = "nupWidth";
            nupWidth.Size = new Size(128, 39);
            nupWidth.TabIndex = 5;
            nupWidth.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(41, 178);
            lblLength.Margin = new Padding(6, 0, 6, 0);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(88, 32);
            lblLength.TabIndex = 4;
            lblLength.Text = "Length";
            // 
            // btnAddContainer
            // 
            btnAddContainer.Location = new Point(49, 496);
            btnAddContainer.Margin = new Padding(6, 8, 6, 8);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(210, 56);
            btnAddContainer.TabIndex = 8;
            btnAddContainer.Text = "AddContainer";
            btnAddContainer.UseVisualStyleBackColor = true;
            btnAddContainer.Click += btnAddContainer_Click;
            // 
            // nupWeight
            // 
            nupWeight.Location = new Point(41, 104);
            nupWeight.Margin = new Padding(6, 8, 6, 8);
            nupWeight.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nupWeight.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            nupWeight.Name = "nupWeight";
            nupWeight.Size = new Size(128, 39);
            nupWeight.TabIndex = 11;
            nupWeight.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(41, 64);
            lblWeight.Margin = new Padding(6, 0, 6, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(90, 32);
            lblWeight.TabIndex = 12;
            lblWeight.Text = "Weight";
            // 
            // gbBoatControls
            // 
            gbBoatControls.Controls.Add(buttonRun);
            gbBoatControls.Controls.Add(lblHeight);
            gbBoatControls.Controls.Add(nupHeight);
            gbBoatControls.Controls.Add(lblWidth);
            gbBoatControls.Controls.Add(nupLength);
            gbBoatControls.Controls.Add(lblLength);
            gbBoatControls.Controls.Add(nupWidth);
            gbBoatControls.Location = new Point(384, 510);
            gbBoatControls.Margin = new Padding(6, 8, 6, 8);
            gbBoatControls.Name = "gbBoatControls";
            gbBoatControls.Padding = new Padding(6, 8, 6, 8);
            gbBoatControls.Size = new Size(275, 568);
            gbBoatControls.TabIndex = 13;
            gbBoatControls.TabStop = false;
            gbBoatControls.Text = "Ship";
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(41, 496);
            buttonRun.Margin = new Padding(6, 8, 6, 8);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(210, 56);
            buttonRun.TabIndex = 19;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(41, 300);
            lblHeight.Margin = new Padding(6, 0, 6, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(86, 32);
            lblHeight.TabIndex = 6;
            lblHeight.Text = "Height";
            // 
            // nupHeight
            // 
            nupHeight.Location = new Point(41, 340);
            nupHeight.Margin = new Padding(6, 8, 6, 8);
            nupHeight.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupHeight.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            nupHeight.Name = "nupHeight";
            nupHeight.Size = new Size(128, 39);
            nupHeight.TabIndex = 7;
            nupHeight.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // gbContainerControls
            // 
            gbContainerControls.Controls.Add(cbCoolable);
            gbContainerControls.Controls.Add(cbValuable);
            gbContainerControls.Controls.Add(nupAmount);
            gbContainerControls.Controls.Add(label1);
            gbContainerControls.Controls.Add(lblType);
            gbContainerControls.Controls.Add(nupWeight);
            gbContainerControls.Controls.Add(btnAddContainer);
            gbContainerControls.Controls.Add(lblWeight);
            gbContainerControls.Location = new Point(26, 510);
            gbContainerControls.Margin = new Padding(6, 8, 6, 8);
            gbContainerControls.Name = "gbContainerControls";
            gbContainerControls.Padding = new Padding(6, 8, 6, 8);
            gbContainerControls.Size = new Size(325, 568);
            gbContainerControls.TabIndex = 14;
            gbContainerControls.TabStop = false;
            gbContainerControls.Text = "Container";
            // 
            // cbCoolable
            // 
            cbCoolable.AutoSize = true;
            cbCoolable.Location = new Point(47, 278);
            cbCoolable.Margin = new Padding(6, 8, 6, 8);
            cbCoolable.Name = "cbCoolable";
            cbCoolable.Size = new Size(140, 36);
            cbCoolable.TabIndex = 18;
            cbCoolable.Text = "Coolable";
            cbCoolable.UseVisualStyleBackColor = true;
            // 
            // cbValuable
            // 
            cbValuable.AutoSize = true;
            cbValuable.Location = new Point(47, 222);
            cbValuable.Margin = new Padding(6, 8, 6, 8);
            cbValuable.Name = "cbValuable";
            cbValuable.Size = new Size(136, 36);
            cbValuable.TabIndex = 17;
            cbValuable.Text = "Valuable";
            cbValuable.UseVisualStyleBackColor = true;
            // 
            // nupAmount
            // 
            nupAmount.Location = new Point(44, 392);
            nupAmount.Margin = new Padding(6, 8, 6, 8);
            nupAmount.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nupAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupAmount.Name = "nupAmount";
            nupAmount.Size = new Size(128, 39);
            nupAmount.TabIndex = 15;
            nupAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 352);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 16;
            label1.Text = "Amount";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(41, 182);
            lblType.Margin = new Padding(6, 0, 6, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(65, 32);
            lblType.TabIndex = 13;
            lblType.Text = "Type";
            // 
            // lbContainers
            // 
            lbContainers.FormattingEnabled = true;
            lbContainers.Location = new Point(42, 26);
            lbContainers.Margin = new Padding(6, 8, 6, 8);
            lbContainers.Name = "lbContainers";
            lbContainers.Size = new Size(613, 452);
            lbContainers.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 1108);
            Controls.Add(lbContainers);
            Controls.Add(gbContainerControls);
            Controls.Add(gbBoatControls);
            Margin = new Padding(6, 8, 6, 8);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nupLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupWeight).EndInit();
            gbBoatControls.ResumeLayout(false);
            gbBoatControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupHeight).EndInit();
            gbContainerControls.ResumeLayout(false);
            gbContainerControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nupLength;
        private System.Windows.Forms.NumericUpDown nupWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nupWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox gbBoatControls;
        private System.Windows.Forms.GroupBox gbContainerControls;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnAddContainer;
        private NumericUpDown nupAmount;
        private Label label1;
        private CheckBox cbValuable;
        private CheckBox cbCoolable;
        private ListBox lbContainers;
        private Label lblHeight;
        private NumericUpDown nupHeight;
        private Button buttonRun;
    }
}