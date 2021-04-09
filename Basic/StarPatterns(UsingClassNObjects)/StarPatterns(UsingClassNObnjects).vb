Module Module1

    Sub Main()

        Dim num As Integer
        Dim HalfPyramidStar As HalfPyramidStarPattern = New HalfPyramidStarPattern()
        Dim HalfInvertedPyramidStar As HalfInvertedPyramidStarPattern = New HalfInvertedPyramidStarPattern()
        Dim MirroredHalfPyramidStar As MirroredHalfPyramidStarPattern = New MirroredHalfPyramidStarPattern()
        Dim MirroredHalfInvertedPyramidStar As MirroredHalfInvertedPyramidStarPattern = New MirroredHalfInvertedPyramidStarPattern()
        Dim HalfHollowPyramidStar As HalfHollowPyramidStarPattern = New HalfHollowPyramidStarPattern()
        Dim HalfInvertedHollowPyramidStar As HalfInvertedHollowPyramidStarPattern = New HalfInvertedHollowPyramidStarPattern()
        Dim HalfDiamondStar As HalfDiamondStarPattern = New HalfDiamondStarPattern()
        Dim FullDiamondStar As FullDiamondStarPattern = New FullDiamondStarPattern()

        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************************HALF PYRAMID STAR PATTERN*************************")
        Console.WriteLine("" & vbNewLine)

        HalfPyramidStar.halfPyramid(num)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*********************HALF INVERTED PYRAMID STAR PATTERN********************")
        Console.WriteLine("" & vbNewLine)

        HalfInvertedPyramidStar.halfInvertedPyramid(num)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("********************Mirrored HALF PYRAMID STAR PATTERN*********************")
        Console.WriteLine("" & vbNewLine)

        MirroredHalfPyramidStar.mirroredHalfPyramid(num)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("****************Mirrored HALF INVERTED PYRAMID STAR PATTERN****************")
        Console.WriteLine("" & vbNewLine)

        MirroredHalfInvertedPyramidStar.mirroredHalfInvertedPyramid(num)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("**********************HALF HOLLOW PYRAMID STAR PATTERN*********************")
        Console.WriteLine("" & vbNewLine)

        HalfHollowPyramidStar.halfHollowPyramid(num)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*****************HALF INVERTED HOLLOW PYRAMID STAR PATTERN*****************")
        Console.WriteLine("" & vbNewLine)

        HalfInvertedHollowPyramidStar.halfInvertedHollowPyramid(num)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************************HALF DIAMOND STAR PATTERN*************************")
        Console.WriteLine("" & vbNewLine)

        HalfDiamondStar.halfDiamond(num)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************************FULL DIAMOND STAR PATTERN*************************")
        Console.WriteLine("" & vbNewLine)

        FullDiamondStar.fullDiamond(num)

        Console.ReadKey()
    End Sub

    Public Class HalfPyramidStarPattern
        Public Sub halfPyramid(ByVal num As Integer)

            For i = 1 To num
                For j = 1 To i
                    Console.Write("* ")
                Next
                Console.WriteLine("" & vbNewLine)
            Next
        End Sub
    End Class
    Public Class HalfInvertedPyramidStarPattern
        Public Sub halfInvertedPyramid(ByVal num As Integer)

            For i = num To 1 Step -1
                For j = 1 To i
                    Console.Write("* ")
                Next
                Console.WriteLine("" & vbNewLine)
            Next
        End Sub
    End Class
    Public Class MirroredHalfPyramidStarPattern
        Public Sub mirroredHalfPyramid(ByVal num As Integer)

            For i = 1 To num
                For j = num To i Step -1
                    Console.Write("  ")
                Next
                For j = 1 To i
                    Console.Write("* ")
                Next
                Console.WriteLine("" & vbNewLine)
            Next

        End Sub
    End Class
    Public Class MirroredHalfInvertedPyramidStarPattern
        Public Sub mirroredHalfInvertedPyramid(ByVal num As Integer)

            For i = 1 To num
                For j = 1 To i
                    Console.Write("  ")
                Next
                For j = num To i Step -1
                    Console.Write("* ")
                Next
                Console.WriteLine("" & vbNewLine)
            Next

        End Sub
    End Class
    Public Class HalfHollowPyramidStarPattern
        Public Sub halfHollowPyramid(ByVal num As Integer)

            For i = 1 To num
                For j = 1 To i
                    If j = 1 Or i = j Or i = num Then
                        Console.Write("* ")
                    Else
                        Console.Write("  ")
                    End If
                Next
                Console.WriteLine("" & vbNewLine)
            Next

        End Sub
    End Class
    Public Class HalfInvertedHollowPyramidStarPattern
        Public Sub halfInvertedHollowPyramid(ByVal num As Integer)

            For i = 1 To num
                For j = num To i Step -1
                    Console.Write("  ")
                Next
                For j = 1 To i
                    If j = 1 Or i = j Or i = num Then
                        Console.Write("* ")
                    Else
                        Console.Write("  ")
                    End If
                Next
                Console.WriteLine("" & vbNewLine)
            Next

        End Sub
    End Class
    Public Class HalfDiamondStarPattern
        Public Sub halfDiamond(ByVal num As Integer)

            For i = 1 To num Step 1
                For j = num - 1 To i Step -1
                    Console.Write("  ")
                Next
                For j = 1 To (2 * i) - 1 Step 1
                    Console.Write("* ")
                Next
                Console.WriteLine("" & vbNewLine)
            Next

            'Alternate Method For Above Pattern
            'Console.WriteLine("" & vbNewLine)
            'Console.WriteLine("*************HALF DIAMOND STAR PATTERN*************")
            'Console.WriteLine("" & vbNewLine)

            'For i = 1 To num Step 1
            '    For j = i To num - 1 Step 1
            '        Console.Write("  ")
            '    Next
            '    For j = 1 To i
            '        Console.Write("* ")
            '    Next
            '    For j = 2 To i
            '        Console.Write("* ")
            '    Next
            '    Console.WriteLine("" & vbNewLine)
            'Next

        End Sub
    End Class
    Public Class FullDiamondStarPattern
        Public Sub fullDiamond(ByVal num As Integer)

            Dim odd As Integer = 1
            For i = 1 To num Step 1
                For j = i To num - 1 Step 1
                    Console.Write("  ")
                Next
                For j = 1 To odd Step 1
                    Console.Write("* ")
                Next
                odd += 2
                Console.WriteLine("" & vbNewLine)
            Next
            odd -= 4
            For i = 1 To num - 1 Step 1
                For j = 1 To i
                    Console.Write("  ")
                Next
                For j = 1 To odd Step 1
                    Console.Write("* ")
                Next
                odd -= 2
                Console.WriteLine("" & vbNewLine)
            Next

        End Sub
    End Class

End Module
