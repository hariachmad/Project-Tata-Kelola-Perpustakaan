<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewDataBuku = New System.Windows.Forms.DataGridView()
        Me.TextBoxNoAnggota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxKodeBuku = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerPengambilan = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerPengembalian = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonPinjam = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewDataBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 83)
        Me.Panel1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "UNIVERSITAS ILHAM MAULANA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(424, 31)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "TATA KELOLA PERPUSTAKAAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewDataBuku)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 268)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Peminjaman"
        '
        'DataGridViewDataBuku
        '
        Me.DataGridViewDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDataBuku.Location = New System.Drawing.Point(6, 16)
        Me.DataGridViewDataBuku.Name = "DataGridViewDataBuku"
        Me.DataGridViewDataBuku.Size = New System.Drawing.Size(342, 246)
        Me.DataGridViewDataBuku.TabIndex = 0
        '
        'TextBoxNoAnggota
        '
        Me.TextBoxNoAnggota.Location = New System.Drawing.Point(451, 117)
        Me.TextBoxNoAnggota.Name = "TextBoxNoAnggota"
        Me.TextBoxNoAnggota.Size = New System.Drawing.Size(236, 20)
        Me.TextBoxNoAnggota.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No Anggota"
        '
        'TextBoxKodeBuku
        '
        Me.TextBoxKodeBuku.Location = New System.Drawing.Point(451, 150)
        Me.TextBoxKodeBuku.Name = "TextBoxKodeBuku"
        Me.TextBoxKodeBuku.Size = New System.Drawing.Size(236, 20)
        Me.TextBoxKodeBuku.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Kode Buku"
        '
        'DateTimePickerPengambilan
        '
        Me.DateTimePickerPengambilan.Location = New System.Drawing.Point(512, 181)
        Me.DateTimePickerPengambilan.Name = "DateTimePickerPengambilan"
        Me.DateTimePickerPengambilan.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePickerPengambilan.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(381, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tanggal Pengambilan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tanggal Pengembalian"
        '
        'DateTimePickerPengembalian
        '
        Me.DateTimePickerPengembalian.Location = New System.Drawing.Point(512, 208)
        Me.DateTimePickerPengembalian.Name = "DateTimePickerPengembalian"
        Me.DateTimePickerPengembalian.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePickerPengembalian.TabIndex = 12
        '
        'TextBoxHarga
        '
        Me.TextBoxHarga.Location = New System.Drawing.Point(451, 253)
        Me.TextBoxHarga.Name = "TextBoxHarga"
        Me.TextBoxHarga.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHarga.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(381, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Harga"
        '
        'ButtonPinjam
        '
        Me.ButtonPinjam.Location = New System.Drawing.Point(422, 300)
        Me.ButtonPinjam.Name = "ButtonPinjam"
        Me.ButtonPinjam.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPinjam.TabIndex = 15
        Me.ButtonPinjam.Text = "PINJAM"
        Me.ButtonPinjam.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(503, 300)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 16
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 381)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonPinjam)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxHarga)
        Me.Controls.Add(Me.DateTimePickerPengembalian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePickerPengambilan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxKodeBuku)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNoAnggota)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "FORM PEMINJAMAN BUKU"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewDataBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewDataBuku As DataGridView
    Friend WithEvents TextBoxNoAnggota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxKodeBuku As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerPengambilan As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerPengembalian As DateTimePicker
    Friend WithEvents TextBoxHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonPinjam As Button
    Friend WithEvents ButtonCancel As Button
End Class
