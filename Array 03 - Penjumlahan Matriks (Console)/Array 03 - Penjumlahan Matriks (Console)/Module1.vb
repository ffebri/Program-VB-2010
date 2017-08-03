Module Module1

    Sub Main()
        Dim I, J As Integer

        'Deklarasi array dua dimensi (matriks 2x3):
        Dim adblA(1, 2), adblC(1, 2) As Double
        'Deklarasi array dua dimensi (matriks 2x3) dengan inisialisasi:
        Dim adblB(,) As Double = {{10, 20, 30}, {-10, -20, -30}}

        'Input elemen matriks A:
        Console.WriteLine("Input elemen matriks A:")
        For I = 0 To UBound(adblA, 1)
            For J = 0 To UBound(adblA, 2)
                Console.Write("A(" & I + 1 & ", " & J + 1 & ") = ")
                adblA(I, J) = CDbl(Console.ReadLine())
            Next
        Next

        'Penjumlahan matriks C = A + B:
        For I = 0 To UBound(adblA, 1)
            For J = 0 To UBound(adblA, 2)
                adblC(I, J) = adblA(I, J) + adblB(I, J)
            Next
        Next

        'Tampilkan elemen matriks A:
        Console.WriteLine(vbCrLf & "Matriks A:")
        For I = 0 To UBound(adblA, 1)
            For J = 0 To UBound(adblA, 2)
                Console.Write(adblA(I, J) & vbTab)
            Next
            Console.WriteLine("")
        Next

        'Tampilkan elemen matriks B:
        Console.WriteLine(vbCrLf & "Matriks B:")
        For I = 0 To UBound(adblB, 1)
            For J = 0 To UBound(adblB, 2)
                Console.Write(adblB(I, J) & vbTab)
            Next
            Console.WriteLine("")
        Next

        'Tampilkan elemen matriks C:
        Console.WriteLine(vbCrLf & "Matriks C = A + B:")
        For I = 0 To UBound(adblC, 1)
            For J = 0 To UBound(adblC, 2)
                Console.Write(adblC(I, J) & vbTab)
            Next
            Console.WriteLine("")
        Next
        Console.ReadKey()
    End Sub

End Module
