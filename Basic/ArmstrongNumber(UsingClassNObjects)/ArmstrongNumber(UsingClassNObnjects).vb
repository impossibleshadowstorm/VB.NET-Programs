Module Module1

    Sub Main()
        Dim num As Integer
        Dim arm As Integer
        Dim digit As Integer
        Dim armstrongNumber As CheckArmstrongNumbers = New CheckArmstrongNumbers()

        Console.WriteLine("                                     PROGRAM TO CHECK WHETHER THE NUMBER IS ARMSTRONG")
        Console.WriteLine("                                  **--------------------------------------------------**")

        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())

        digit = armstrongNumber.findNumberOfDigits(num)
        arm = armstrongNumber.armstrong(digit, num)


        Console.WriteLine("                                        +++--------------------+++")
        Console.WriteLine("                                        +++ FACTORIAL OF ARRAY +++")
        Console.WriteLine("                                        +++--------------------+++")
        Console.WriteLine("" & vbNewLine)

        If arm = num Then
            Console.WriteLine("{0} IS AN ARMSTRONG NUMBER!!!", num)
        Else
            Console.WriteLine("{0} IS NOT AN ARMSTRONG NUMBER!!!", num)
        End If

        Console.ReadKey()
    End Sub

    Public Class CheckArmstrongNumbers
        Public Function findNumberOfDigits(ByVal num As Integer) As Integer
            Dim digit As Integer = 0

            While num > 0
                digit += 1
                num = Math.Floor(num / 10)
            End While

            Return digit
        End Function
        Public Function armstrong(ByVal digit As Integer, ByVal num As Integer) As Integer
            Dim remainder As Integer
            Dim cube As Double
            Dim arm As Integer = 0

            While num > 0
                remainder = num Mod 10
                cube = remainder ^ digit
                arm += cube
                num = Math.Floor(num / 10)
            End While

            Return arm
        End Function
    End Class

End Module
