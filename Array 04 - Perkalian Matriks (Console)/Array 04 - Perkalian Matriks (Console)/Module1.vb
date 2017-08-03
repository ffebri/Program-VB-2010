'Program Perkalian matriks C = A x B
'
Module Module1

    Sub Main()
        Const BATAS = 10

        Dim I, J, K, BrsA, KlmA, KlmB As Integer

        'Deklarasi array dua dimensi (matriks BATAS x BATAS):
        Dim adblA(BATAS, BATAS), adblB(BATAS, BATAS), adblC(BATAS, BATAS) As Double

        Console.WriteLine("Perkalian matriks C = A x B" & vbCrLf)

        'Input ukuran matriks A:
        Console.WriteLine("Masukkan ukuran matriks A:")
        Do
            Console.Write("Jumlah baris matriks A [1.." & BATAS & "] = ")
            BrsA = CInt(Console.ReadLine())
        Loop Until BrsA >= 1 And BrsA <= BATAS
        Do
            Console.Write("Jumlah kolom matriks A [1.." & BATAS & "] = ")
            KlmA = CInt(Console.ReadLine())
        Loop Until KlmA >= 1 And KlmA <= BATAS

        'Input ukuran kolom matriks B:
        Console.WriteLine("Masukkan ukuran kolom matriks B:")
        Console.WriteLine("Jumlah baris matriks B = " & KlmA)
        Do
            Console.Write("Jumlah kolom matriks B [1.." & BATAS & "] = ")
            KlmB = CInt(Console.ReadLine())
        Loop Until KlmB >= 1 And KlmB <= BATAS

        'Input elemen matriks A:
        Console.WriteLine("Masukkan elemen matriks A:")
        For I = 0 To BrsA - 1
            For J = 0 To KlmA - 1
                Console.Write("A(" & I + 1 & ", " & J + 1 & ") = ")
                adblA(I, J) = CDbl(Console.ReadLine())
            Next
        Next

        'Input elemen matriks B:
        Console.WriteLine("Masukkan elemen matriks B:")
        For I = 0 To KlmA - 1
            For J = 0 To KlmB - 1
                Console.Write("B(" & I + 1 & ", " & J + 1 & ") = ")
                adblB(I, J) = CDbl(Console.ReadLine())
            Next
        Next

        'Perkalian matriks C = A x B:
        For I = 0 To BrsA - 1
            For J = 0 To KlmB - 1
                adblC(I, J) = 0
                For K = 0 To KlmA - 1
                    adblC(I, J) += adblA(I, K) * adblB(K, J)
                Next
            Next
        Next

        'Tampilkan elemen matriks C:
        Console.WriteLine(vbCrLf & "Matriks C = A x B:")
        For I = 0 To BrsA - 1
            For J = 0 To KlmB - 1
                Console.Write(adblC(I, J) & vbTab)
            Next
            Console.WriteLine("")
        Next
        Console.ReadKey()

    End Sub

End Module
