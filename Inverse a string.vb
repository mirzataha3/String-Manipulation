Module Module1

    Sub Main()
        'DECLARATION

        Dim i As Integer
        Dim Str, Str2 As String
        Dim thischar As Char

        'INITIALISATION

        i = 1
        Str = " "
        Str2 = " "
        thischar = " "

        'INPUT

        Console.Write("Enter the statement: ")
        Str = Console.ReadLine

        'LOOP

        For i = 1 To Len(Str)
            thischar = Mid(Str, i, 1)
            Str2 = thischar + Str2
        Next i

        'OUTPUT

        Console.WriteLine("New Statement: " & Str2)
        Console.ReadKey()
    End Sub

End Module
