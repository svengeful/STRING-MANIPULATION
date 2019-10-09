Module Module1

    Sub Main()
        Dim STR1, VOWEL As String
        Dim COUNT, vowels As Integer

        STR1 = ""
        VOWEL = "a,e,i,o,u"
        COUNT = 0
        vowels = 0

        Console.Write("enter the string to be checked")
        STR1 = Console.ReadLine

        STR1 = LCase(STR1)

        For COUNT = 1 To 10
            If InStr(VOWEL, Mid(STR1, COUNT, 1)) > 0 Then
                vowels = vowels + 1
            End If
        Next
        Console.WriteLine("thevowelin enetred string is:" & vowels)
        Console.ReadKey()
    End Sub

End Module
