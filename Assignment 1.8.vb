Module Module1

    Sub Main()
        'DECLARATION

        Dim s, s2 As String
        Dim thischar, firstchar As Char

        'INITIALISATION

        s = " "
        s2 = " "
        thischar = " "
        firstchar = " "

        'INPUT

        Console.Write("Enter statement: ")
        s = Console.ReadLine

        'PROCESS

        firstchar = Left(s, 1)

        For i = 1 To Len(s)
            thischar = Mid(s, i, 1)
            If thischar <> firstchar Then
                s2 = s2 + thischar
            Else
                s2 = s2 + ("*")
            End If
        Next i

        Console.WriteLine("New statement: " & s2)
        Console.ReadKey()
    End Sub

End Module
