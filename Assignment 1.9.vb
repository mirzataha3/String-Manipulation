Module Module1

    Sub Main()
        'DECLARATION

        Dim a, b, str1, str2 As String
        Dim thischar As Char
        Dim i As Integer

        'INITIALISATION

        a = " "
        b = " "
        str1 = " "
        str2 = " "
        thischar = " "
        i = 3

        'INPUT 

        Console.Write("Enter statement 1: ")
        str1 = Console.ReadLine
        Console.Write("Enter statement 2: ")
        str2 = Console.ReadLine

        'PROCESS

        a = Left(str1, 2)
        b = Left(str2, 2)

        For i = 3 To Len(str1)
            thischar = Mid(str1, i, 1)
            b = b + thischar
        Next i

        For i = 3 To Len(str2)
            thischar = Mid(str2, i, 1)
            a = a + thischar
        Next i

        Console.WriteLine("New statement: " & b & " " & a)
        Console.ReadKey()
    End Sub

End Module
