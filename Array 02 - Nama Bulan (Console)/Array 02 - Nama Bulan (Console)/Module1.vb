'Catatan:
'Dim asBulan() As String = {"Januari", "Februari", dst.}
'boleh ditulis:
'Dim asBulan() = {"Januari", "Februari", dst.}

Module Module1

    Sub Main()
        Dim asBulan() As String = {"Januari", "Februari", "Maret", "April", "Mei", _
                                   "Juni", "Juli", "Agustus", "September", "Oktober", _
                                   "November", "Desember"}
        Dim I As Byte

        Console.WriteLine("Nama-Nama Bulan:")
        For I = 0 To UBound(asBulan)
            Console.WriteLine(I + 1 & ": " & asBulan(I))
        Next
        Console.ReadKey()
    End Sub

End Module
