Module Module1

    Sub Main()
        Dim num1, num2 As Integer

        Console.WriteLine("                                    PROGRAM TO SHOW DEMO OF SUB KEYWORD USING ADDITION PROGRAM")
        Console.WriteLine("                                 **------------------------------------------------------------** ")

        Console.Write("" & vbNewLine + "ENTER FIRST NUMBER:: ")
        num1 = CInt(Console.ReadLine())
        Console.Write("" & vbNewLine + "ENTER SECOND NUMBER:: ")
        num2 = CInt(Console.ReadLine())


        Console.WriteLine("                                        +++ --------------- +++")
        Console.WriteLine("                                        +++ ADDITION RESULT +++")
        Console.WriteLine("                                        +++ --------------- +++" & vbNewLine)

        Dim sum As Integer = Addition(num1, num2)

        Console.WriteLine("THE SUM OF {0} AND {1} IS:: {2}", num1, num2, sum)

        Console.ReadKey()
    End Sub

    Public Function Addition(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ''Function Keyword Is Used To Create A Function Which Returns Data To Main Function

        Return num1 + num2
    End Function

End Module
