<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.matriks1 = New System.Windows.Forms.TextBox()
        Me.hitungButton = New System.Windows.Forms.Button()
        Me.matriks2 = New System.Windows.Forms.TextBox()
        Me.operasi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hasilText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'matriks1
        '
        Me.matriks1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matriks1.Location = New System.Drawing.Point(89, 12)
        Me.matriks1.Multiline = True
        Me.matriks1.Name = "matriks1"
        Me.matriks1.Size = New System.Drawing.Size(340, 75)
        Me.matriks1.TabIndex = 11
        '
        'hitungButton
        '
        Me.hitungButton.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitungButton.Location = New System.Drawing.Point(354, 367)
        Me.hitungButton.Name = "hitungButton"
        Me.hitungButton.Size = New System.Drawing.Size(75, 23)
        Me.hitungButton.TabIndex = 10
        Me.hitungButton.Text = "Hitung"
        Me.hitungButton.UseVisualStyleBackColor = True
        '
        'matriks2
        '
        Me.matriks2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matriks2.Location = New System.Drawing.Point(89, 131)
        Me.matriks2.Multiline = True
        Me.matriks2.Name = "matriks2"
        Me.matriks2.Size = New System.Drawing.Size(340, 75)
        Me.matriks2.TabIndex = 9
        '
        'operasi
        '
        Me.operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.operasi.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operasi.FormattingEnabled = True
        Me.operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.operasi.Location = New System.Drawing.Point(89, 97)
        Me.operasi.Name = "operasi"
        Me.operasi.Size = New System.Drawing.Size(340, 24)
        Me.operasi.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Matriks 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Operasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Matriks 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Hasil"
        '
        'hasilText
        '
        Me.hasilText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasilText.Location = New System.Drawing.Point(89, 222)
        Me.hasilText.Multiline = True
        Me.hasilText.Name = "hasilText"
        Me.hasilText.ReadOnly = True
        Me.hasilText.Size = New System.Drawing.Size(340, 75)
        Me.hasilText.TabIndex = 13
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hasilText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.matriks1)
        Me.Controls.Add(Me.hitungButton)
        Me.Controls.Add(Me.matriks2)
        Me.Controls.Add(Me.operasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents matriks1 As System.Windows.Forms.TextBox
    Friend WithEvents hitungButton As System.Windows.Forms.Button
    Friend WithEvents matriks2 As System.Windows.Forms.TextBox
    Friend WithEvents operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hasilText As System.Windows.Forms.TextBox
End Class
