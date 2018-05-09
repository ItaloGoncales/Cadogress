namespace Cadogress
{
    partial class InserterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserterForm));
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.AddInButton = new System.Windows.Forms.Button();
            this.RegTable = new System.Windows.Forms.ListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantitySumBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.TotalValueSumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(12, 24);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(184, 20);
            this.DescriptionBox.TabIndex = 0;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(199, 24);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(77, 20);
            this.QuantityBox.TabIndex = 1;
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(279, 24);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(77, 20);
            this.ValueBox.TabIndex = 2;
            // 
            // AddInButton
            // 
            this.AddInButton.Location = new System.Drawing.Point(364, 20);
            this.AddInButton.Name = "AddInButton";
            this.AddInButton.Size = new System.Drawing.Size(84, 25);
            this.AddInButton.TabIndex = 3;
            this.AddInButton.Text = "Adicionar";
            this.AddInButton.UseVisualStyleBackColor = true;
            this.AddInButton.Click += new System.EventHandler(this.AddInButton_Click);
            // 
            // RegTable
            // 
            this.RegTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Quantity,
            this.Value,
            this.TotalValue});
            this.RegTable.GridLines = true;
            this.RegTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RegTable.Location = new System.Drawing.Point(12, 51);
            this.RegTable.Name = "RegTable";
            this.RegTable.Size = new System.Drawing.Size(436, 114);
            this.RegTable.TabIndex = 4;
            this.RegTable.UseCompatibleStateImageBehavior = false;
            this.RegTable.View = System.Windows.Forms.View.Details;
            this.RegTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RegTable_MouseDoubleClick);
            // 
            // Description
            // 
            this.Description.Tag = "";
            this.Description.Text = "Descrição";
            this.Description.Width = 185;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantidade";
            this.Quantity.Width = 78;
            // 
            // Value
            // 
            this.Value.Text = "Valor";
            this.Value.Width = 80;
            // 
            // TotalValue
            // 
            this.TotalValue.Text = "Valor Total";
            this.TotalValue.Width = 89;
            // 
            // QuantitySumBox
            // 
            this.QuantitySumBox.Location = new System.Drawing.Point(197, 171);
            this.QuantitySumBox.Name = "QuantitySumBox";
            this.QuantitySumBox.Size = new System.Drawing.Size(79, 20);
            this.QuantitySumBox.TabIndex = 5;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(156, 171);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(37, 13);
            this.SumLabel.TabIndex = 6;
            this.SumLabel.Text = "Soma:";
            // 
            // TotalValueSumBox
            // 
            this.TotalValueSumBox.Location = new System.Drawing.Point(358, 171);
            this.TotalValueSumBox.Name = "TotalValueSumBox";
            this.TotalValueSumBox.Size = new System.Drawing.Size(89, 20);
            this.TotalValueSumBox.TabIndex = 7;
            // 
            // InserterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(456, 201);
            this.Controls.Add(this.TotalValueSumBox);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.QuantitySumBox);
            this.Controls.Add(this.RegTable);
            this.Controls.Add(this.AddInButton);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.DescriptionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InserterForm";
            this.Text = "Registry Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button AddInButton;
        private System.Windows.Forms.ListView RegTable;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader TotalValue;
        private System.Windows.Forms.TextBox QuantitySumBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.TextBox TotalValueSumBox;
    }
}

