Module Module1

    Sub Main()
        Dim palindrome, num As Integer
        Dim palindromeNumber As CheckPalindrome = New CheckPalindrome()

        Console.WriteLine("*****************************************************************************************************")
        Console.WriteLine("                                            CHECK PALINDROME NUMBERS")
        Console.WriteLine("*****************************************************************************************************")

        Console.WriteLine("" & vbNewLine)

        Console.Write("ENTER THE NUMBER OF TESTCASES:: ")
        Dim test As Integer = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        For i = 1 To test
            palindrome = 0

            Console.WriteLine("                                                TESTCASE {0} ", i)
            Console.WriteLine("                                             **--------------**")
            Console.WriteLine("" & vbNewLine)

            Console.Write("ENTER A NUMBER:: ")
            num = CInt(Console.ReadLine())

            palindrome = palindromeNumber.returnPalindromeNumber(num)

            If num = palindrome Then
                Console.WriteLine("" & vbNewLine + "{0} IS A PALINDROME NUMBER !!", num)
            Else
                Console.WriteLine("" & vbNewLine + "{0} IS NOT A PALINDROME NUMBER !!", num)
            End If

            Console.WriteLine("" & vbNewLine)
        Next

        Console.ReadKey()
    End Sub

    Public Class CheckPalindrome
        Public Function returnPalindromeNumber(ByVal num As Integer) As Integer
            Dim palindrome As Integer

            While num > 0
                'remainder = num Mod 10
                palindrome = palindrome * 10 + (num Mod 10)
                num = Math.Floor(num / 10)
            End While

            Return palindrome
        End Function
    End Class

End Module
