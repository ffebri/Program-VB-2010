'Program untuk membuat password acak minimal 3 karakter yang terdiri
'dari huruf dan angka dengan ketentuan:
'1. Minimal harus ada 1 huruf kapital, 1 huruf kecil, dan 1 angka.
'2. Karakter pertama harus huruf, boleh huruf kapital atau huruf kecil.

Public Class Form1

    Private Sub btnBuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuat.Click
        Const BATAS = 25
        Dim asPassword(BATAS - 1) As String, sPassword As String
        Dim I, J, JumKar, Acak As Integer
        Dim blnKapital, blnKecil, blnAngka As Boolean, blnPswdSudahAda As Boolean

        JumKar = Val(txtJumKar.Text)
        If JumKar < 3 Then
            MsgBox("Jumlah karakter password minimal harus 3!", , "Pesan Kesalahan")
            Exit Sub
        End If

        Randomize() 'Inisialisasi pembangkit bilangan random
        I = 0
        Do
            blnKapital = False : blnKecil = False : blnAngka = False
            sPassword = ""
            For J = 1 To JumKar
                If J = 1 Then 'karakter pertama harus huruf
                    Acak = Int(Rnd() * 2) 'Angka acak 0, 1
                    'karakter ketujuh diisi dengan huruf kapital jika huruf kapital belum ada
                ElseIf J = JumKar - 1 And blnKapital = False Then
                    Acak = 0
                    'karakter ketujuh diisi dengan huruf kecil jika huruf kecil belum ada
                ElseIf J = JumKar - 1 And blnKecil = False Then
                    Acak = 1
                    'karakter ketujuh diisi dengan angka jika angka belum ada
                ElseIf J = JumKar And blnAngka = False Then
                    Acak = 2
                Else
                    Acak = Int(Rnd() * 3) 'Angka acak 0, 1, 2
                End If
                If Acak = 0 Then 'huruf kapital
                    blnKapital = True
                    Acak = Int(Rnd() * 26) + 65 'Angka acak (0, 1, 2,..., 25) + 65
                ElseIf Acak = 1 Then 'huruf kecil
                    blnKecil = True
                    Acak = Int(Rnd() * 26) + 97 'Angka acak (0, 1, 2,..., 25) + 97
                Else 'angka
                    blnAngka = True
                    Acak = Int(Rnd() * 10) + 48 'Angka acak (0, 1, 2,..., 9) + 48
                End If
                sPassword = sPassword & Chr(Acak)
            Next

            'Periksa apakah password ini sudah ada.
            blnPswdSudahAda = False
            For J = 0 To I - 1
                If asPassword(J) = sPassword Then
                    blnPswdSudahAda = True
                    Exit For
                End If
            Next
            If Not blnPswdSudahAda Then
                asPassword(I) = sPassword
                I += 1
            End If
        Loop Until I = BATAS

        txtPassword.Text = ""
        For I = 0 To BATAS - 1
            txtPassword.Text = txtPassword.Text & asPassword(I) & vbCrLf
        Next
    End Sub
End Class
