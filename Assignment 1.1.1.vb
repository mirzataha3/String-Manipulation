Module Module1

    Sub Main()
        'DECLARATION

        Dim s, first, last As String
        Dim a, b, i As Integer
        Dim thischar As Char
        'INITIALISATION

        s = " "
        first = " "
        last = " "
        a = 0
        b = 0
        i = 0
        thischar = " "

        'INPUT

        Console.Write("Enter the statement: ")
        s = Console.ReadLine

        'PROCESS


        a = InStr(s, "not")
        b = InStr(s, "bad")

        For i = 1 To (a - 1)
            thischar = Mid(s, i, 1)
            first = first + thischar
        Next

        For i = (b + 3) To Len(s)
            thischar = Mid(s, i, 1)
            last = last + thischar
        Next

        Console.WriteLine("New statement: " & first & "good" & last)
        Console.ReadKey()
    End Sub

End Module
