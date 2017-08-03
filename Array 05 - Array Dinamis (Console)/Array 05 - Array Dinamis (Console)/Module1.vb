Module Module1

    Sub Main()
        Dim I As Integer
        Dim aiA() As Integer = {1, 2, 3}
        Dim aiB() As Integer = {1, 2, 3}

        Console.WriteLine("Array Dinamis." & vbCrLf)

        Console.WriteLine("Array aiA sebelum ReDim:")
        For I = 0 To UBound(aiA)
            Console.Write(aiA(I) & vbTab)
        Next
        Console.WriteLine("")

        ReDim aiA(4) 'Semua nilai array diinisialisasikan ke nilai default (untuk numerik = 0)

        Console.WriteLine("Array aiA setelah ReDim:")
        For I = 0 To UBound(aiA)
            Console.Write(aiA(I) & vbTab)
        Next
        Console.WriteLine("")

        Console.WriteLine("Array aiB sebelum ReDim Preserve:")
        For I = 0 To UBound(aiB)
            Console.Write(aiB(I) & vbTab)
        Next
        Console.WriteLine("")

        ReDim Preserve aiB(4) 'Nilai lama dipertahankan

        Console.WriteLine("Array aiB setelah ReDim Preserve:")
        For I = 0 To UBound(aiB)
            Console.Write(aiB(I) & vbTab)
        Next
        Console.WriteLine("")
        Console.ReadKey()
    End Sub

End Module
