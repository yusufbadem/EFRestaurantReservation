namespace EFRestaurantReservation.Forms;

partial class CustomerFrm
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
        label4 = new Label();
        label5 = new Label();
        txtName = new TextBox();
        txtSurname = new TextBox();
        txtEmail = new TextBox();
        txtPhone = new TextBox();
        txtAddress = new TextBox();
        dgvCustomer = new DataGridView();
        btnAdd = new Button();
        btnDelete = new Button();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(49, 20);
        label1.TabIndex = 0;
        label1.Text = "Name";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(553, 9);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 1;
        label2.Text = "Phone";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(364, 9);
        label3.Name = "label3";
        label3.Size = new Size(46, 20);
        label3.TabIndex = 2;
        label3.Text = "Email";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(191, 9);
        label4.Name = "label4";
        label4.Size = new Size(67, 20);
        label4.TabIndex = 3;
        label4.Text = "Surname";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(702, 9);
        label5.Name = "label5";
        label5.Size = new Size(62, 20);
        label5.TabIndex = 4;
        label5.Text = "Address";
        // 
        // txtName
        // 
        txtName.Location = new Point(10, 41);
        txtName.Name = "txtName";
        txtName.Size = new Size(125, 27);
        txtName.TabIndex = 5;
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(191, 41);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(125, 27);
        txtSurname.TabIndex = 6;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(364, 41);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(125, 27);
        txtEmail.TabIndex = 7;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(517, 41);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(125, 27);
        txtPhone.TabIndex = 8;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(663, 41);
        txtAddress.Multiline = true;
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(231, 86);
        txtAddress.TabIndex = 9;
        // 
        // dgvCustomer
        // 
        dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomer.Location = new Point(24, 221);
        dgvCustomer.Name = "dgvCustomer";
        dgvCustomer.RowHeadersWidth = 51;
        dgvCustomer.Size = new Size(844, 217);
        dgvCustomer.TabIndex = 10;
        dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
        dgvCustomer.DoubleClick += dgvCustomer_DoubleClick;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.LimeGreen;
        btnAdd.Location = new Point(12, 83);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(630, 44);
        btnAdd.TabIndex = 11;
        btnAdd.Text = "Customer Add";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Firebrick;
        btnDelete.Location = new Point(24, 171);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(137, 44);
        btnDelete.TabIndex = 12;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.MediumTurquoise;
        btnUpdate.Location = new Point(191, 171);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(137, 44);
        btnUpdate.TabIndex = 13;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // CustomerFrm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(906, 450);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(btnAdd);
        Controls.Add(dgvCustomer);
        Controls.Add(txtAddress);
        Controls.Add(txtPhone);
        Controls.Add(txtEmail);
        Controls.Add(txtSurname);
        Controls.Add(txtName);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "CustomerFrm";
        Text = "CustomerFrm";
        Load += CustomerFrm_Load;
        ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txtName;
    private TextBox txtSurname;
    private TextBox txtEmail;
    private TextBox txtPhone;
    private TextBox txtAddress;
    private DataGridView dgvCustomer;
    private Button btnAdd;
    private Button btnDelete;
    private Button btnUpdate;
}