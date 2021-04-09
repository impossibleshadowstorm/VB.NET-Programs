'
'
' PROGRAM TO PRINT COUNT UPPERCASE LETTERS IN STRING
'
' INPUT:: 
'   CoUntUpperCASE
'
' OUTPUT::
'   Total UpperCase Letter In CoUntUpperCASE Is 7
'
'

Module Module1

    Sub Main()

        Console.WriteLine("                             PROGRAM TO PRINT COUNT UPPERCASE LETTERS IN STRING")
        Console.WriteLine("                          **----------------------------------------------------**" & vbNewLine & vbNewLine)

        Console.Write("ENTER A STRING:: ")
        Dim str As String = Console.ReadLine()


        Console.WriteLine("" & vbNewLine + "                                           +++ SOLUTION +++")
        Console.WriteLine("                                           +++ -------- +++" & vbNewLine & vbNewLine)

        Dim length As Integer = str.Length()

        Dim ucount As Integer = CountUpperCase(str, length)
        Console.WriteLine("SO, THE TOTAL COUNT OF UPPERCASE IS:: {0}", ucount & vbNewLine & vbNewLine)

        Dim lcount As Integer = CountLowerCase(str, length)
        Console.WriteLine("SO, THE TOTAL COUNT OF UPPERCASE IS:: {0}", lcount)

        Console.ReadKey()
    End Sub

    Public Function CountUpperCase(ByVal str As String, ByVal length As Integer) As Integer
        Dim ucount As Integer = 0

        Console.Write("UPPERCASE LETTERS IN {0} ARE:: || ", str)

        For i = 0 To length - 1
            Dim character As Integer = Convert.ToInt32(str(i))

            If character >= 65 And character <= 90 Then
                Console.Write("  {0}   ||", str(i))
                ucount += 1
            End If
        Next

        Console.WriteLine("" & vbNewLine)

        Return ucount
    End Function
    Public Function CountLowerCase(ByVal str As String, ByVal length As Integer) As Integer
        Dim lcount As Integer = 0

        Console.Write("LOWERCASE LETTERS IN {0} ARE:: || ", str)
        For i = 0 To length - 1
            Dim character As Integer = Convert.ToInt32(str(i))

            If character >= 97 And character <= 122 Then
                Console.Write("  {0}   ||", str(i))
                lcount += 1
            End If
        Next

        Console.WriteLine("" & vbNewLine)

        Return lcount
    End Function

End Module
