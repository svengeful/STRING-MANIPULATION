Module Module1

    Sub Main()
        Dim Str1, Str2, Str3, firstWord, lastWord As String
        Dim Sp As Integer

        Str1 = ""
        Str2 = ""
        Str3 = ""
        firstWord = ""
        lastWord = ""
        Sp = 0

        Console.Write("Enter 1st string of 3 words: ")
        Str1 = Console.ReadLine

        Console.Write("Enter 2nd string of 3 words: ")
        Str2 = Console.ReadLine

        Sp = InStr(Str1, " ")
        firstWord = Right(Str1, Sp - 2)

        Sp = InStr(Str2, " ")
        lastWord = Left(Str2, Sp - 1)

        Str3 = firstWord & " " & lastWord
        Console.WriteLine(Str3)

        Console.ReadKey()
    End Sub

End Module
