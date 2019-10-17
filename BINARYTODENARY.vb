Module Module1

    Sub Main()
        Dim SONE, STWO, newCHAR As String
        Dim index, counter, LASTNUM As Integer
        Dim ValidBinaryString As Boolean

        SONE = ""
        STWO = ""
        newCHAR = ""
        LASTNUM = 0
        index = 0
        counter = 0
        ValidBinaryString = True

        Console.Write("Enter Binary String : ")
        SONE = Console.ReadLine

        If Len(SONE) <= 8 And Len(SONE) > 0 Then
            For counter = 1 To Len(SONE)
                newCHAR = Mid(SONE, counter, 1)
                If newCHAR <> "1" And newCHAR <> "0" Then
                    ValidBinaryString = False
                End If
            Next
        Else
            ValidBinaryString = True
        End If
        If ValidBinaryString = False Then
            Console.Write("The Binary string entered is not a binary number")
        Else
            Console.Write("The Binary string entered is a binary number ")
            ValidBinaryString = True
        End If

        '(b)'

        If ValidBinaryString = True Then

            For counter = 1 To Len(SONE)
                STWO = Mid(SONE, counter, 1) & STWO
            Next

            For counter = 1 To Len(STWO)
                newCHAR = Mid(STWO, counter, 1)
                index = 0
                If newCHAR = "1" Then
                    index = 1
                End If

                If counter = 1 Then
                    LASTNUM = LASTNUM + index
                End If

                If counter = 2 Then
                    LASTNUM = LASTNUM + index * 2
                End If

                If counter = 3 Then
                    LASTNUM = LASTNUM + index * 4
                End If

                If counter = 4 Then
                    LASTNUM = LASTNUM + index * 8
                End If

                If counter = 5 Then
                    LASTNUM = LASTNUM + index * 16
                End If

                If counter = 6 Then
                    LASTNUM = LASTNUM + index * 32
                End If

                If counter = 7 Then
                    LASTNUM = LASTNUM + index * 64
                End If

                If counter = 8 Then
                    LASTNUM = LASTNUM + index * 128
                End If
            Next

            Console.WriteLine(SONE & " = " & LASTNUM)
        End If

        Console.ReadKey()
        Console.ReadKey()

    End Sub

End Module
