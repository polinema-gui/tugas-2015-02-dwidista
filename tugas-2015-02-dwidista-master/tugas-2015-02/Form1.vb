Public Class Form1
    Dim nilai1, nilai2 As Long
    Dim hasil As Double
    Dim operasi, txtnilai1, txtnilai2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles samadengan.Click
        nilai1 = Val(txtnilai1)
        nilai2 = Val(txtnilai2)
        If operasi = "+" Then
            hasil = nilai1 + nilai2
            TextHasil.Text = hasil
        ElseIf operasi = "-" Then
            hasil = nilai1 - nilai2
            TextHasil.Text = hasil
        ElseIf operasi = "*" Then
            hasil = nilai1 * nilai2
            TextHasil.Text = hasil
        ElseIf operasi = ":" Then
            hasil = nilai1 / nilai2
            TextHasil.Text = hasil
        End If
        operasi = ""
        txtnilai1 = ""
        txtnilai2 = ""
        txtnilai1 = Str$(hasil)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextHasil.TextChanged

    End Sub

    Private Sub satu_Click(sender As Object, e As EventArgs) Handles satu.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "1"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "1"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub dua_Click(sender As Object, e As EventArgs) Handles dua.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "2"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "2"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub tiga_Click(sender As Object, e As EventArgs) Handles tiga.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "3"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "3"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub empat_Click(sender As Object, e As EventArgs) Handles empat.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "4"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "4"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub lima_Click(sender As Object, e As EventArgs) Handles lima.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "5"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "5"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub enam_Click(sender As Object, e As EventArgs) Handles enam.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "6"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "6"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub tujuh_Click(sender As Object, e As EventArgs) Handles tujuh.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "7"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "7"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub delapan_Click(sender As Object, e As EventArgs) Handles delapan.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "8"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "8"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub sembilan_Click(sender As Object, e As EventArgs) Handles sembilan.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "9"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "9"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "0"
            TextHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "0"
            TextHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        operasi = "+"
    End Sub

    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        operasi = "-"
    End Sub

    Private Sub kali_Click(sender As Object, e As EventArgs) Handles kali.Click
        operasi = "*"
    End Sub

    Private Sub bagi_Click(sender As Object, e As EventArgs) Handles bagi.Click
        operasi = ":"
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles hapus.Click
        operasi = ""
        txtnilai1 = ""
        txtnilai2 = ""
        TextHasil.Clear()
    End Sub

    Private Function nila1() As Long
        Throw New NotImplementedException
    End Function

End Class
