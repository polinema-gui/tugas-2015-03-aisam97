﻿Public Class Form2
    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Dim input As Integer = Convert.ToInt32(Me.inputText.Text)
        If input <> "0" Then
            Select Case Convert.ToString(Me.pilihanCombo.SelectedItem)
                Case "Pyramid"
                    Me.hasilText.Text = Me.pyramid(input)
                    Exit Select
                Case "Hollow Pyramid"
                    Me.hasilText.Text = Me.hollowPyramid(input)
                    Exit Select
                Case "Inverted Pyramid"
                    Me.hasilText.Text = Me.invertedPyramid(input)
                    Exit Select
                Case "Inverted Hollow Pyramid"
                    Me.hasilText.Text = Me.invertedHollowPyramid(input)
                    Exit Select
                Case Nothing
                    MessageBox.Show("Silahkan pilih pola terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Select
            End Select
        Else
            MessageBox.Show("Silahkan masukkan angka terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Function hollowPyramid(ByVal input As Integer) As String
        Dim hasil As String = String.Empty
        Dim i, j As Integer
        For i = 1 To input
            For j = i To input - 1
                hasil &= " "
            Next
            For j = 1 To i
                If ((j = 1) Or (i = input)) Then
                    hasil &= "*"
                Else
                    hasil &= " "
                End If
            Next
            For j = 1 To i - 1
                If ((j = i - 1) Or (i = input)) Then
                    hasil &= "*"
                Else
                    hasil &= " "
                End If
            Next
            hasil &= vbCrLf
        Next
        Return hasil
    End Function

    Private Function invertedHollowPyramid(ByVal input As Integer) As String
        Dim hasil As String = String.Empty
        Dim i, j As Integer
        For i = 1 To input
            For j = 1 To i - 1
                hasil &= " "
            Next
            For j = i To input
                If (i = 1 Or j = i) Then
                    hasil &= "*"
                Else
                    hasil &= " "
                End If
            Next
            For j = i To input - 1
                If ((i = 1) Or (j = input - 1)) Then
                    hasil &= "*"
                Else
                    hasil &= " "
                End If
            Next
            hasil &= vbCrLf
        Next
        Return hasil

    End Function

    Private Function invertedPyramid(ByVal input As Integer) As String
        Dim hasil As String = String.Empty
        For baris As Integer = 1 To input
            For spasi As Integer = baris - 1 To 1 Step -1
                hasil &= " "
            Next
            For bintang As Integer = input * 2 To baris * 2 Step -1
                hasil &= "*"
            Next
            hasil &= vbCrLf
        Next
        Return hasil
    End Function

    Private Function pyramid(ByVal input As Integer) As String
        Dim hasil As String = String.Empty
        For baris As Integer = 1 To input
            For spasi As Integer = input - 1 To baris Step -1
                hasil &= " "
            Next
            For bintang As Integer = 1 To (2 * baris - 1)
                hasil &= "*"
            Next
            hasil &= vbCrLf
        Next
        Return hasil
    End Function

    Private Sub inputText_MouseClick(sender As Object, e As MouseEventArgs) Handles inputText.MouseClick
        inputText.Text = ""
    End Sub
End Class