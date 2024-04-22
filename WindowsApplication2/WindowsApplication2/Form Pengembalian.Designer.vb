<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.DataGridViewDataBuku = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNoTransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerTanggalPengembalian = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDenda = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewDataBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 92)
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
        'DataGridViewDataBuku
        '
        Me.DataGridViewDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDataBuku.Location = New System.Drawing.Point(12, 110)
        Me.DataGridViewDataBuku.Name = "DataGridViewDataBuku"
        Me.DataGridViewDataBuku.Size = New System.Drawing.Size(342, 246)
        Me.DataGridViewDataBuku.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No Transaksi"
        '
        'TextBoxNoTransaksi
        '
        Me.TextBoxNoTransaksi.Location = New System.Drawing.Point(511, 117)
        Me.TextBoxNoTransaksi.Name = "TextBoxNoTransaksi"
        Me.TextBoxNoTransaksi.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxNoTransaksi.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tanggal Pengembalian"
        '
        'DateTimePickerTanggalPengembalian
        '
        Me.DateTimePickerTanggalPengembalian.Location = New System.Drawing.Point(495, 144)
        Me.DateTimePickerTanggalPengembalian.Name = "DateTimePickerTanggalPengembalian"
        Me.DateTimePickerTanggalPengembalian.Size = New System.Drawing.Size(125, 20)
        Me.DateTimePickerTanggalPengembalian.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Kembalikan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(495, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Denda"
        '
        'TextBoxDenda
        '
        Me.TextBoxDenda.Location = New System.Drawing.Point(511, 176)
        Me.TextBoxDenda.Name = "TextBoxDenda"
        Me.TextBoxDenda.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxDenda.TabIndex = 10
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 368)
        Me.Controls.Add(Me.TextBoxDenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePickerTanggalPengembalian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNoTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewDataBuku)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form5"
        Me.Text = "Form Pengembalian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewDataBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridViewDataBuku As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNoTransaksi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerTanggalPengembalian As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxDenda As TextBox
End Class
