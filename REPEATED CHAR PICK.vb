Module Module1

    Sub Main()
        Dim str2, nextchar, str1, repeatchar, newchar As String
        Dim count, oldcharcount, pchar As Integer

        nextchar = ""
        count = 0
        oldcharcount = 1
        str1 = ""
        pchar = 0
        repeatchar = ""
        newchar = ""
        str2 = ""

        Console.WriteLine("enter string:")
        str1 = Console.ReadLine

            For count = 1 To Len(str1)
                str2 = str1
            nextchar = Mid(str1, count, 1)
            Do While InStr(str2, nextchar) > 0
                pchar = pchar + 1
                nextchar = Mid(str2, count, 1)
                str2 = Left(str2, InStr(str2, nextchar) - 1) & Right(str2, Len(str2) - InStr(str2, nextchar))
            Loop

            If pchar > oldcharcount Then
                InStr(str2, nextchar)
                repeatchar = newchar
            End If
            oldcharcount = pchar
            pchar = 0
        Next
        If nextchar = "" Then
            Console.WriteLine("all characters are present once:")
            nextchar = "" = Console.ReadLine

            If repeatchar = "" Then
                Console.WriteLine("all chars are not repeated: ")
                repeatchar = "" = Console.ReadLine

                If repeatchar <> "" Then
                    Console.WriteLine("most repeat char is: " & repeatchar)

                End If
            End If
        End If
        Console.WriteLine("invalid string entered:")

        Console.ReadKey()

    End Sub

End Module
