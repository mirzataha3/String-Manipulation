Module Module1

    Sub Main()
        'DECLARATION

        Dim str1, str2 As String
        Dim char1, char2, char3 As Char
        Dim i As Integer

        'INITIALISATION

        str1 = " "
        str2 = " "
        char1 = " "
        char2 = " "
        char3 = " "
        i = 0

        'INPUT

        Console.Write("Enter the statement: ")
        str1 = Console.ReadLine
        Console.Write("Enter character you want to replace: ")
        char1 = Console.ReadLine
        Console.Write("Enter character you want in place: ")
        char2 = Console.ReadLine

        'LOOP

        For i = 1 To Len(str1)
            char3 = Mid(str1, i, 1)

            'CONDITION

            If char3 <> char1 Then

                str2 = str2 + char3
            Else
                str2 = str2 + char2
            End If
        Next

        'OUTPUT

        Console.WriteLine("New statement: " & str2)
        Console.ReadKey()
    End Sub

End Module
