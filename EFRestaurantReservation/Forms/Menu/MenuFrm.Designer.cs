namespace EFRestaurantReservation.Forms;

partial class MenuFrm
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        txtTitle = new TextBox();
        txtDescription = new TextBox();
        txtPrice = new TextBox();
        btnAdd = new Button();
        btnDelete = new Button();
        btnUpdate = new Button();
        dgvMenu = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 47);
        label1.Name = "label1";
        label1.Size = new Size(38, 20);
        label1.TabIndex = 0;
        label1.Text = "Title";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 92);
        label2.Name = "label2";
        label2.Size = new Size(85, 20);
        label2.TabIndex = 1;
        label2.Text = "Description";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(282, 47);
        label3.Name = "label3";
        label3.Size = new Size(41, 20);
        label3.TabIndex = 2;
        label3.Text = "Price";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(118, 45);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(125, 27);
        txtTitle.TabIndex = 3;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(118, 85);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(125, 27);
        txtDescription.TabIndex = 4;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(388, 40);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(125, 27);
        txtPrice.TabIndex = 5;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(282, 84);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(231, 29);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Menu Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(18, 151);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(156, 29);
        btnDelete.TabIndex = 8;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(193, 151);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(156, 29);
        btnUpdate.TabIndex = 9;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // dgvMenu
        // 
        dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMenu.Location = new Point(18, 186);
        dgvMenu.Name = "dgvMenu";
        dgvMenu.RowHeadersWidth = 51;
        dgvMenu.Size = new Size(547, 252);
        dgvMenu.TabIndex = 10;
        // 
        // MenuFrm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dgvMenu);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(btnAdd);
        Controls.Add(txtPrice);
        Controls.Add(txtDescription);
        Controls.Add(txtTitle);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "MenuFrm";
        Text = "MenuFrm";
        Load += MenuFrm_Load;
        ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtTitle;
    private TextBox txtDescription;
    private TextBox txtPrice;
    private Button btnAdd;
    private Button btnDelete;
    private Button btnUpdate;
    private DataGridView dgvMenu;
}