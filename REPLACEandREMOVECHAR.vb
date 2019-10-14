Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, Char2, nextChar As String
        Dim counter As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        nextChar = ""
        counter = 0

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to replace: ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        Char2 = Console.ReadLine

        For counter = 1 To Len(Str1)
            nextChar = Left(Str1, 4)
            If nextChar = Char1 Then
                nextChar = Char2
            End If
            Str2 = Str2 & nextChar
        Next

        Console.WriteLine("Final string = " & Str2)
        Console.ReadKey()


    End Sub

End Module
