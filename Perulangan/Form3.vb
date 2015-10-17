Public Class Form3

    Private Function masukan(ByVal matriks As String) As List(Of List(Of Integer))
        Dim daftar As New List(Of List(Of Integer))
        Dim baris As String() = matriks.Split(vbCrLf)
        Dim panjangBaris As Integer = baris.Length
        Dim angka As Integer = (panjangBaris - 1)
        Dim i As Integer = 0
        Do While (i <= angka)
            Dim kolom As String() = baris(i).Split(" ")
            Dim angka2 As Integer = kolom.Length
            daftar.Add(New List(Of Integer))
            Dim angka3 As Integer = (angka2 - 1)
            Dim j As Integer = 0
            Do While (j <= angka3)
                daftar.Item(i).Add(Convert.ToInt32(kolom(j)))
                j += 1
            Loop
            If ((i <> 0) AndAlso (daftar.Item(i).Count <> daftar.Item((i - 1)).Count)) Then
                Return Nothing
            End If
            i += 1
        Loop
        Return daftar
    End Function

    Private Sub cetakHasil(ByVal matrix As List(Of List(Of Integer)))
        Dim hasil As String = ""
        Dim angka As Integer = (matrix.Count - 1)
        Dim i As Integer = 0
        Do While (i <= angka)
            Dim angka2 As Integer = (matrix.Item(i).Count - 1)
            Dim j As Integer = 0
            Do While (j <= angka2)
                hasil = (hasil & Convert.ToString(matrix.Item(i).Item(j)) & vbTab)
                j += 1
            Loop
            hasil = (hasil & vbCrLf)
            i += 1
        Loop
        Me.hasilText.Text = hasil
    End Sub


    Private Function tambah(ByVal matrix1 As List(Of List(Of Integer)), ByVal matrix2 As List(Of List(Of Integer))) As List(Of List(Of Integer))
        Dim angka As Integer = (matrix1.Count - 1)
        Dim i As Integer = 0
        Do While (i <= angka)
            Dim angka2 As Integer = (matrix1.Item(i).Count - 1)
            Dim j As Integer = 0
            Do While (j <= angka2)
                Dim daftar As List(Of Integer) = matrix1.Item(i)
                daftar.Item(j) = (daftar.Item(j) + matrix2.Item(i).Item(j))
                j += 1
            Loop
            i += 1
        Loop
        Return matrix1
    End Function

    Private Function kurang(ByVal matrix1 As List(Of List(Of Integer)), ByVal matrix2 As List(Of List(Of Integer))) As List(Of List(Of Integer))
        Dim angka As Integer = (matrix1.Count - 1)
        Dim i As Integer = 0
        Do While (i <= angka)
            Dim angka2 As Integer = (matrix1.Item(i).Count - 1)
            Dim j As Integer = 0
            Do While (j <= angka2)
                Dim daftar As List(Of Integer) = matrix1.Item(i)
                daftar.Item(j) = (daftar.Item(j) - matrix2.Item(i).Item(j))
                j += 1
            Loop
            i += 1
        Loop
        Return matrix1
    End Function



    Private Function sesuai(ByVal matrix1 As List(Of List(Of Integer)), ByVal matrix2 As List(Of List(Of Integer))) As Boolean
        Return ((matrix1.Count = matrix2.Count) AndAlso (matrix1.Item(0).Count = matrix2.Item(0).Count))
    End Function

    Private Sub hitungButton_Click(sender As Object, e As EventArgs) Handles hitungButton.Click
        Dim daftarMatriks1 As List(Of List(Of Integer)) = Me.masukan(Me.matriks1.Text)
        Dim daftarMatriks2 As List(Of List(Of Integer)) = Me.masukan(Me.matriks2.Text)
        If ((Not daftarMatriks1 Is Nothing) And (Not daftarMatriks2 Is Nothing)) Then
            If Me.sesuai(daftarMatriks1, daftarMatriks2) Then
                Select Case Convert.ToString(Me.operasi.SelectedItem)
                    Case "Tambah"
                        daftarMatriks1 = Me.tambah(daftarMatriks1, daftarMatriks2)
                        Me.cetakHasil(daftarMatriks1)
                        Exit Select
                    Case "Kurang"
                        daftarMatriks1 = Me.kurang(daftarMatriks1, daftarMatriks2)
                        Me.cetakHasil(daftarMatriks1)
                        Exit Select
                End Select
            Else
                MessageBox.Show("Jumlah baris dan kolom untuk kedua matriks harus sama!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Else
            MessageBox.Show("Bukan matriks yang valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub

End Class