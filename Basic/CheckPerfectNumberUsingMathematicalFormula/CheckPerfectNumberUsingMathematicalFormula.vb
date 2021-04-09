Imports System.Numerics

Module Module1

    Sub Main()

        Dim num, power1, power2 As Long
        Dim countprime As Integer = 0
        Dim i As Long = 1

        Console.WriteLine("ENTER NUMBER TILL YOU WANT TO PRINT PERFFECT NUMBERS LIST:: ")
        num = CInt(Console.ReadLine())

        While countprime <> num
            'Console.WriteLine("" & vbNewLine & vbNewLine + "I:: {0}", i)

            power1 = (2 ^ i) - 1

            power2 = 2 ^ (i - 1)

            Dim bool As Boolean = checkPrime(power1)

            If bool Then
                countprime = countprime + 1
                'Dim ans As ULong = power1 * power2
                Dim perfect As Long = power1 * power2
                Console.WriteLine("{0}. {1}", countprime, perfect)
            End If

            i += 1
        End While


        Console.ReadKey()
    End Sub

    Public Function checkPrime(ByVal num As Long) As Boolean

        Dim bool As Boolean = False
        Dim i As Long = 0

        For i = 2 To num \ 2
            If num Mod i = 0 Then Exit For
        Next
        'Console.WriteLine("INSIDE i IS:: {0}", i)
        If i = (num \ 2) + 1 Then
            bool = True
        End If

        'Console.WriteLine("VALUE OF BOOL IS:: {0}", bool)

        Return bool

    End Function

End Module
