Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
        Form3.Close()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
        Form2.Close()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If (MessageBox.Show("Apakah anda ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Environment.Exit(0)
        End If
    End Sub
End Class
