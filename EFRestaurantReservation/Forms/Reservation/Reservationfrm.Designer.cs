namespace EFRestaurantReservation.Forms.Reservation;

partial class Reservationfrm
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
        cmbNameSurname = new ComboBox();
        dtpDate = new DateTimePicker();
        txtNotes = new TextBox();
        btnAddReservation = new Button();
        dgvReservation = new DataGridView();
        txtId = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
        SuspendLayout();
        // 
        // cmbNameSurname
        // 
        cmbNameSurname.FormattingEnabled = true;
        cmbNameSurname.Location = new Point(25, 48);
        cmbNameSurname.Name = "cmbNameSurname";
        cmbNameSurname.Size = new Size(252, 28);
        cmbNameSurname.TabIndex = 0;
        cmbNameSurname.SelectedIndexChanged += cmbNameSurname_SelectedIndexChanged;
        // 
        // dtpDate
        // 
        dtpDate.Location = new Point(293, 49);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(250, 27);
        dtpDate.TabIndex = 1;
        // 
        // txtNotes
        // 
        txtNotes.Location = new Point(25, 106);
        txtNotes.Multiline = true;
        txtNotes.Name = "txtNotes";
        txtNotes.Size = new Size(518, 113);
        txtNotes.TabIndex = 2;
        // 
        // btnAddReservation
        // 
        btnAddReservation.Location = new Point(25, 256);
        btnAddReservation.Name = "btnAddReservation";
        btnAddReservation.Size = new Size(518, 49);
        btnAddReservation.TabIndex = 3;
        btnAddReservation.Text = "Finish Reservation";
        btnAddReservation.UseVisualStyleBackColor = true;
        btnAddReservation.Click += btnAddReservation_Click;
        // 
        // dgvReservation
        // 
        dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvReservation.Location = new Point(597, 46);
        dgvReservation.Name = "dgvReservation";
        dgvReservation.RowHeadersWidth = 51;
        dgvReservation.Size = new Size(493, 259);
        dgvReservation.TabIndex = 4;
        dgvReservation.CellContentClick += dgvReservation_CellContentClick;
        dgvReservation.DoubleClick += dgvReservation_DoubleClick;
        // 
        // txtId
        // 
        txtId.Location = new Point(25, 12);
        txtId.Name = "txtId";
        txtId.Size = new Size(125, 27);
        txtId.TabIndex = 5;
        // 
        // Reservationfrm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1102, 342);
        Controls.Add(txtId);
        Controls.Add(dgvReservation);
        Controls.Add(btnAddReservation);
        Controls.Add(txtNotes);
        Controls.Add(dtpDate);
        Controls.Add(cmbNameSurname);
        Name = "Reservationfrm";
        Text = "Reservation";
        Load += Reservationfrm_Load;
        ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cmbNameSurname;
    private DateTimePicker dtpDate;
    private TextBox txtNotes;
    private Button btnAddReservation;
    private DataGridView dgvReservation;
    private TextBox txtId;
}