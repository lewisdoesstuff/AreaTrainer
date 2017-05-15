Imports System.Data
Imports System.IO
Module Module1
    Dim score As Integer = 0
    Dim loggedin As Boolean = False
    Dim name As String

    Sub Main()
        Randomize()
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("LOADING: |_________")
        Console.WriteLine("Loading Console")
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("LOADING: ||________")
        Console.WriteLine("Loading ServerList.txt")
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("LOADING: |||_______")
        Console.WriteLine("Loading Shape Vectors")
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("LOADING: ||||______")
        Console.WriteLine("Loading Text Input")
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("LOADING: |||||_____")
        Console.WriteLine("Loading Strings")
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("LOADING: ||||||____")
        Console.WriteLine("Opening Connection to server")
        Threading.Thread.Sleep(500)
        For i = 1 To 10
            Console.WriteLine("LOADING: ||||||____")
            Console.WriteLine("Connecting to Server |")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("LOADING: ||||||____")
            Console.WriteLine("Connecting to Server /")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("LOADING: ||||||____")
            Console.WriteLine("Connecting to Server -")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("LOADING: ||||||____")
            Console.WriteLine("Connecting to Server |")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("LOADING: ||||||____")
            Console.WriteLine("Connecting to Server -")
            Threading.Thread.Sleep(50)
            Console.Clear()
            Console.WriteLine("LOADING: ||||||____")
            Console.WriteLine("Connecting to Server \")
            Threading.Thread.Sleep(50)

            Console.Clear()
        Next
        Console.Clear()
        Console.WriteLine("LOADING: |||||||___")
        Console.WriteLine("Loading Menu")
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("LOADING: ||||||||__")
        Console.WriteLine("Loading Math")
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("LOADING: |||||||||_")
        Console.WriteLine("Downloading Login Database from server")
        Threading.Thread.Sleep(500)
        Console.WriteLine("LOADING: |||||||||_")
        For i = 1 To 100
            Console.WriteLine("LOADING: |||||||||_")

            Console.WriteLine("Fetching " & i & "%")
            Threading.Thread.Sleep(10)
            Console.Clear()
        Next

        Console.Clear()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("LOADING: ||||||||||")
        Console.WriteLine("Loading Complete!")
        Console.ForegroundColor = ConsoleColor.White
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine("Welcome to the Area Trainer")
        Console.WriteLine("1. Play")
        Console.WriteLine("2. Register")
        Console.WriteLine("3. Save and Quit")
        Dim temp = Console.ReadLine()
        If temp = 1 Then
            names()
        ElseIf temp = 2 Then
            Register()
        ElseIf temp = 3 Then
            If loggedin Then
                My.Computer.FileSystem.WriteAllText("login\Users" & name & "\game.csv", score, False)
                Console.WriteLine("Your score for this session was" & score)
                Environment.Exit(0.1)
            Else
                Environment.Exit(0.0)
            End If
        End If
    End Sub
    Sub names()
        Dim password As String = Nothing
        Console.WriteLine("Enter Username")
        name = Console.ReadLine
        Dim csv As String = Nothing
        If File.Exists("login\Users\" & name & "\" & name & " .csv") Then
        Else
            Console.WriteLine("Username does not exist")
            Threading.Thread.Sleep(2500)
            Console.Clear()
            Main()
        End If
        Dim pass As String = My.Computer.FileSystem.ReadAllText("login\Users\" & name & "\" & name & " .csv")
        Console.WriteLine("Enter your password")
        Dim key As ConsoleKeyInfo
        While key.Key <> ConsoleKey.Enter
            key = Console.ReadKey(True)
            If key.Key <> ConsoleKey.Backspace And key.Key <> ConsoleKey.Enter Then
                password += key.KeyChar
                Console.Write("*")
            ElseIf key.Key = ConsoleKey.Backspace Then
                key = Console.ReadKey(False)
                key = Console.ReadKey(True)

            End If
        End While
        password = Trim(password)
        If password = pass Then
            Threading.Thread.Sleep(1000)
            For i = 1 To 10
                Console.WriteLine("Connecting to Server |")
                Threading.Thread.Sleep(50)
                Console.Clear()
                Console.WriteLine("Connecting to Server /")
                Threading.Thread.Sleep(50)
                Console.Clear()
                Console.WriteLine("Connecting to Server -")
                Threading.Thread.Sleep(50)
                Console.Clear()
                Console.WriteLine("Connecting to Server |")
                Threading.Thread.Sleep(50)
                Console.Clear()
                Console.WriteLine("Connecting to Server -")
                Threading.Thread.Sleep(50)
                Console.Clear()
                Console.WriteLine("Connecting to Server \")
                Threading.Thread.Sleep(50)

                Console.Clear()
            Next
            loggedin = True
            Play()
        Else
            Console.WriteLine("Incorrect Password")
            Threading.Thread.Sleep(2500)
            names()
        End If


    End Sub
    Sub Register()
        Console.WriteLine("Enter a Username")
        Dim user As String = Console.ReadLine()
        If File.Exists("login\Users\" & user & "\" & user & " .csv") Then
            Console.WriteLine("User name already exists")
            Threading.Thread.Sleep(2000)
            Register()
        End If
        Console.WriteLine("Enter your password")
        Dim password As String = Nothing
        Dim key As ConsoleKeyInfo
        While key.Key <> ConsoleKey.Enter
            key = Console.ReadKey(True)
            If key.Key <> ConsoleKey.Backspace And key.Key <> ConsoleKey.Enter Then
                password += key.KeyChar
                Console.Write("*")
            ElseIf key.Key = ConsoleKey.Backspace Then
                key = Console.ReadKey(False)
                key = Console.ReadKey(True)
            End If
        End While
        If password = "password" Then
            Console.WriteLine("Don't be absurd, Use a better password!")
        Else
        End If
        System.IO.Directory.CreateDirectory("login\Users\" & user & "\")
        My.Computer.FileSystem.WriteAllText("login\Users\" & user & "\" & user & " .csv", password, False)
        Console.WriteLine("You have registered!")
        Threading.Thread.Sleep(2000)
        Main()
    End Sub

    Sub Play()
        Console.WriteLine("Choose a shape")
        Console.WriteLine("1. ")
        Console.WriteLine(" __________")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine(" __________")
        Console.WriteLine("2. ")
        Console.WriteLine("|\")
        Console.WriteLine("| \")
        Console.WriteLine("|  \")
        Console.WriteLine("|   \")
        Console.WriteLine("|    \")
        Console.WriteLine("|     \")
        Console.WriteLine("|______\")

        Console.WriteLine("3.  ")
        Console.WriteLine("     *  *")
        Console.WriteLine("  *        *")
        Console.WriteLine(" *          *")
        Console.WriteLine(" *          *")
        Console.WriteLine("  *        *")
        Console.WriteLine("     *  *")
        Dim choice As String = Console.ReadLine()
        If choice = "1" Then
            square()
        ElseIf choice = "2" Then
            triangle()
        ElseIf choice = "3" Then
            circle()
        End If
    End Sub

    Sub square()
        Console.Clear()
        Console.WriteLine("Your score is: " & score)
        Console.WriteLine(" __________")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine(" __________")
        Dim y = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("Y = " & y)
        Dim x = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("x = " & x)
        Dim area As String = x * y
        Dim a, b, c, d As Double
        a = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        b = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        c = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        d = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Dim ans = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1
        If ans = 1 Then
            a = area
        ElseIf ans = 2 Then
            b = area
        ElseIf ans = 3 Then
            c = area
        ElseIf ans = 4 Then
            d = area
        End If
        Console.WriteLine("A=" & a & " B=" & b & " C=" & c & " D=" & d & " Q: Go to menu")
        Console.WriteLine("Enter Answer")
        ans = Console.ReadLine()
        If ans = area Then
            Console.WriteLine("That is correct!")
            score += 1
            Threading.Thread.Sleep(1000)
            square()
        ElseIf ans = "q" Or ans = "Q" Then
            Main()
        Else
            Console.WriteLine("That is incorrect, The correct answer was" & area)
            Threading.Thread.Sleep(1000)
            square()
        End If
        Console.Read()
    End Sub
    Sub triangle()
        Console.Clear()
        Console.WriteLine("Your score is: " & score)

        Console.WriteLine("|\")
        Console.WriteLine("| \")
        Console.WriteLine("|  \")
        Console.WriteLine("|   \")
        Console.WriteLine("|    \")
        Console.WriteLine("|     \")
        Console.WriteLine("|______\")
        Dim y = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("Y = " & y)
        Dim x = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("x = " & x)
        Dim area As String = (x * y) / 2
        Dim a, b, c, d As Double
        a = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        b = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        c = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        d = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Dim ans = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1
        If ans = 1 Then
            a = area
        ElseIf ans = 2 Then
            b = area
        ElseIf ans = 3 Then
            c = area
        ElseIf ans = 4 Then
            d = area
        End If
        Console.WriteLine("A=" & a & " B=" & b & " C=" & c & " D=" & d & " Q: Go to menu")
        Console.WriteLine("Enter Answer")
        ans = Console.ReadLine()
        If ans = area Then
            Console.WriteLine("That is correct!")
            score += 1
            Threading.Thread.Sleep(1000)
            triangle()
        Else
            Console.WriteLine("That is incorrect, The correct answer was" & area)
            Threading.Thread.Sleep(1000)
            triangle()
        End If
        Console.Read()
    End Sub
    Sub circle()
        Console.Clear()
        Console.WriteLine("Your score is: " & score)

        Console.WriteLine("     *  *")
        Console.WriteLine("  *        *")
        Console.WriteLine(" *          *")
        Console.WriteLine(" *          *")
        Console.WriteLine("  *        *")
        Console.WriteLine("     *  *")
        Dim area As String = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("Radius" & area)

        area = Math.Round((area * area) * Math.PI)
        Dim a, b, c, d As Double
        a = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        b = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        c = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        d = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Dim ans = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1
        If ans = 1 Then
            a = area
        ElseIf ans = 2 Then
            b = area
        ElseIf ans = 3 Then
            c = area
        ElseIf ans = 4 Then
            d = area
        End If
        Console.WriteLine("A=" & a & " B=" & b & " C=" & c & " D=" & d & " Q: Go to menu")
        Console.WriteLine("Enter Answer")
        ans = Console.ReadLine()
        If ans = area Then
            Console.WriteLine("That is correct!")
            score += 1
            Threading.Thread.Sleep(1000)
            circle()
        Else
            Console.WriteLine("That is incorrect, The correct answer was" & area)
            Threading.Thread.Sleep(1000)
            circle()
        End If
        Console.Read()
    End Sub
End Module
