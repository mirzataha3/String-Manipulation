Module Module1

    Sub Main()
        'DECLARATION

        Dim c, i, tasc1, tasc2, asc1 As Integer
        Dim str1, str2 As String
        Dim thischar, thischar2, a, b As Char

        'INITIALISATION

        c = 1
        i = 1
        tasc1 = 0
        tasc2 = 0
        asc1 = 0
        str1 = " "
        str2 = " "
        thischar = " "
        thischar2 = " "
        a = " "
        b = " "

        'INPUT

        Console.Write("Enter statement 1: ")
        str1 = Console.ReadLine
        Console.Write("Enter statement 2: ")
        str2 = Console.ReadLine


        'CASE NEUTRALISATION

        str1 = UCase(str1)
        str2 = UCase(str2)

        'CONDITION

        If Len(str1) = Len(str2) Then

            'LOOP

            For i = 1 To Len(str1)
                a = Mid(str1, i, 1)
                tasc1 = tasc1 + Asc(a)
            Next i

            'LOOP

            For i = 1 To Len(str2)
                b = Mid(str2, i, 1)
                tasc2 = tasc2 + Asc(b)
            Next i

            'CONDITION

            If tasc1 = tasc2 Then

                'LOOP

                For i = 1 To Len(str1)
                    thischar = Mid(str1, i, 1)
                    asc1 = Asc(thischar)
                    tasc2 = tasc2 - asc1
                Next i

                'CONDITION

                If tasc2 = 0 Then

                    'OUTPUT

                    Console.WriteLine("The strings are Anagram")
                End If
            Else
                Console.WriteLine("The strings are not Anagram.")
            End If
        Else
            Console.WriteLine("The strings are not Anagram.")
        End If
        Console.ReadKey()
    End Sub

End Module
