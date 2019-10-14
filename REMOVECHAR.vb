Module Module1

    Sub Main()
        Dim mySTR, finalStr, myCHAR, nextchar As String
        Dim COUNTER As Integer

        mySTR = ""
        finalStr = ""
        myCHAR = ""
        nextchar = ""
        COUNTER = 0

        Console.WriteLine("enter string : ")
        mySTR = Console.ReadLine

        Console.Write("enter character to remove: ")
        myCHAR = Console.ReadLine

        For COUNTER = 1 To Len(mySTR)
            nextchar = Left(mySTR, 1)
            If nextchar <> myCHAR Then
                finalStr = finalStr & nextchar
            End If
        Next

        Console.WriteLine(" FINAL STRING is = " & finalStr)
        Console.ReadKey()

    End Sub

End Module
