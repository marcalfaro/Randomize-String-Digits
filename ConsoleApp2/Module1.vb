Option Explicit On
Imports System.Text.RegularExpressions

Module Module1

    Sub Main()

        Console.WriteLine("Example Input String:") : Console.WriteLine()
        Dim orig As String = "Mozilla/5.0 (Linux; Android 6.0.1; SM-G935S Build/MMB29K; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/55.0.2883.91 Mobile Safari/537.36"
        Console.WriteLine(orig)
        Console.WriteLine()

        For i As Integer = 1 To 5
            Dim initialSeed As Integer = 0
            Dim newString1 As String = RandomizeNumerics(initialSeed, orig, 10, 100)
            Console.WriteLine(newString1)
        Next

        Console.WriteLine()

        Console.WriteLine("Example Input String:") : Console.WriteLine()
        Dim grocerylist As String = "Grocery list: 1 bottle of Soda, 2 eggs, 3kg fish, 4pcs of apples, and 3cm cloth"
        Console.WriteLine(grocerylist)
        Console.WriteLine()

        For i As Integer = 1 To 5
            Dim initialSeed As Integer = 0
            Dim newString1 As String = RandomizeNumerics(initialSeed, grocerylist, 10, 100)
            Console.WriteLine(newString1)
        Next

        Console.ReadLine()
    End Sub

    Private Function RandomizeNumerics(ByRef initialSeed As Integer, ByVal inputString As String, ByVal minValue As Integer, ByVal maxValue As Integer, Optional ByRef errmsg As String = Nothing) As String
        Dim rslt As String = inputString
        Try
            Dim new1 As String = String.Empty
            new1 = New Regex("[0-9]").Replace(inputString, "`")     'replace all digit with '`'
            new1 = Regex.Replace(new1, "`{2,}", "`").Trim           'club double '`' to single '`'

            'loop through all chars and replace '`'
            Dim sb As New Text.StringBuilder
            Dim lent As Integer = new1.Length
            For i As Integer = 0 To lent - 1
                Dim c As Char = new1.Substring(i, 1)
                If c = "`" Then
                    sb.Append(GetRandomInt(initialSeed, 1, 100))
                Else
                    sb.Append(c)
                End If
            Next

            rslt = sb.ToString  'piece everything together

        Catch ex As Exception
            errmsg = ex.Message
        End Try
        Return rslt
    End Function

    Private Function GetRandomInt(ByRef initialValue As Integer, ByVal min As Integer, ByVal max As Integer, Optional ByRef errMsg As String = Nothing) As Integer
        Dim rslt As Integer = 0
        Dim objRandom As Random = Nothing
        Try
            While rslt = 0 Or rslt = initialValue
                objRandom = New Random(CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))
                rslt = objRandom.Next(min, max + 1)
            End While
        Catch ex As Exception
            errMsg = ex.Message
        Finally
            objRandom = Nothing
            initialValue = rslt
        End Try
        Return rslt
    End Function

End Module
