Module Module1

    Sub Main()
        Dim num As Integer
        Dim digit As Integer

        Console.WriteLine("                                         PROGRAM TO FIND NUMBER OF 2s IN 1 TO N")
        Console.WriteLine("                                     **-----------------------------------------** ")

        Console.WriteLine("" & vbNewLine)


        Console.Write("ENTER THE NUMBER OF TESTCASES:: ")
        Dim test As Integer = CInt(Console.ReadLine())

        For i = 1 To test

            Console.WriteLine("" & vbNewLine + "----------------------------------------------------------------------------------------------")
            Console.WriteLine("                                            TESTCASE {0} ", i)
            Console.WriteLine("----------------------------------------------------------------------------------------------" & vbNewLine & vbNewLine)

            Console.Write("ENTER A NUMBER TO CHECK:: ")
            num = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)

            Console.Write("ENTER DIGIT TO CHECK:: ")
            digit = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)

            'methodOneFindingNumberOfDigits(num, digit)
            secondOneFindingNumberOfDigits(num, digit)


        Next
    End Sub

    '    Public Sub methodOneFindingNumberOfDigits(ByVal num As Integer, ByVal digit As Integer)

    '        Dim count As Integer = 0

    '        For j = 0 To num
    '            count += numberOf2s(j, digit)
    '        Next

    '        Console.WriteLine("                                        +++ -------------------------- +++")
    '        Console.WriteLine("                                        +++ NUMBER OF DIGITS IN 1 TO N +++")
    '        Console.WriteLine("                                        +++ -------------------------- +++" & vbNewLine)

    '        Console.WriteLine("NUMBER OF {0} IN 0 TO {1} IS:: {2}", digit, num, count)

    '    End Sub

    '    Public Function numberOf2s(ByVal num As Integer, ByVal digit As Integer) As Integer

    '        Dim count As Integer = 0

    '        While num > 0
    '            If (num Mod 10) = digit Then
    '                count += 1
    '            End If

    '            num \= 10
    '        End While

    '        Return count

    '    End Function

    Public Sub secondOneFindingNumberOfDigits(ByVal num As Integer, ByVal digit As Integer)

        Dim numString As String = ""
        Dim digitString As String = digit.ToString()
        Dim digitCharacter As Char = Convert.ToChar(digitString(0))
        Dim count As Integer = 0

        For i = digit To num
            numString += i.ToString()
        Next

        For i = 0 To numString.Length - 1
            Dim NumStringCharacter As Char = Convert.ToChar(numString(i))

            If NumStringCharacter = digitCharacter Then
                count += 1
            End If
        Next

        Console.WriteLine("                                        +++ -------------------------- +++")
        Console.WriteLine("                                        +++ NUMBER OF DIGITS IN 0 TO N +++")
        Console.WriteLine("                                        +++ -------------------------- +++" & vbNewLine)

        Console.WriteLine("NUMBER OF {0} IN 0 TO {1} IS:: {2}", digit, num, count)

    End Sub
End Module
