<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pilihanCombo = New System.Windows.Forms.ComboBox()
        Me.inputText = New System.Windows.Forms.TextBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.hasilText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baris"
        '
        'pilihanCombo
        '
        Me.pilihanCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pilihanCombo.FormattingEnabled = True
        Me.pilihanCombo.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Inverted Hollow Pyramid"})
        Me.pilihanCombo.Location = New System.Drawing.Point(71, 18)
        Me.pilihanCombo.Name = "pilihanCombo"
        Me.pilihanCombo.Size = New System.Drawing.Size(369, 21)
        Me.pilihanCombo.TabIndex = 2
        '
        'inputText
        '
        Me.inputText.Location = New System.Drawing.Point(71, 48)
        Me.inputText.Name = "inputText"
        Me.inputText.Size = New System.Drawing.Size(288, 20)
        Me.inputText.TabIndex = 3
        Me.inputText.Text = "0"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(365, 43)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 4
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'hasilText
        '
        Me.hasilText.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasilText.Location = New System.Drawing.Point(24, 74)
        Me.hasilText.Multiline = True
        Me.hasilText.Name = "hasilText"
        Me.hasilText.Size = New System.Drawing.Size(416, 339)
        Me.hasilText.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.hasilText)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.inputText)
        Me.Controls.Add(Me.pilihanCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pilihanCombo As System.Windows.Forms.ComboBox
    Friend WithEvents inputText As System.Windows.Forms.TextBox
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents hasilText As System.Windows.Forms.TextBox
End Class
