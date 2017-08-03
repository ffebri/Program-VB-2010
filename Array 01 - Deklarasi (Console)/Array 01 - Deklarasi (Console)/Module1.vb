Module Module1

    Sub Main()
        Dim I As Integer

        'Deklarasi array berdimensi satu dengan 5 elemen:
        Dim aiA(4) As Integer 'atau aiA(0 To 4) As Integer
        Dim aiB() As Integer = New Integer(4) {}
        'Deklarasi array berdimensi satu dengan inisialisasi:
        Dim aiC() As Integer = {100, 200, 300, 400, 500}

        'Pemberian nilai array:
        aiA(0) = 1 : aiA(1) = 2
        For I = 2 To UBound(aiA)
            aiA(I) = I + 1
        Next

        For I = 0 To UBound(aiB)
            aiB(I) = 10 * (I + 1)
        Next

        'Penampilan nilai array:
        Console.WriteLine("Array aiA:")
        For I = 0 To UBound(aiA)
            Console.Write(aiA(I) & vbTab)
        Next
        Console.WriteLine("")

        Console.WriteLine("Array aiB:")
        For I = 0 To UBound(aiB)
            Console.Write(aiB(I) & vbTab)
        Next
        Console.WriteLine("")

        Console.WriteLine("Array aiC:")
        For I = 0 To UBound(aiC)
            Console.Write(aiC(I) & vbTab)
        Next
        Console.WriteLine("")
        Console.ReadKey()
    End Sub

End Module
