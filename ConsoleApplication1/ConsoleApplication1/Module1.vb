
'------------------------------------------'
'   This Program is made by Lewis and      '
'   And if you use it I won't do anything  '
'   So yeah enjoy thanks                   '
'------------------------------------------'
Imports System.Data
Imports System.IO
Imports System.Runtime.CompilerServices ' imports 
Module Module1
    Dim score As Integer = 0
    Dim loggedin As Boolean = False ' the few global variables needed 
    Dim name As String

    Sub Main()
        Randomize() ' calls randomize here so we can use better random numbers
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
        Console.WriteLine("Loading Shape Vectors") 'totally neeeded loading screen
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
            Register() ' simple menu
        ElseIf temp = 3 Then
            If loggedin Then
                My.Computer.FileSystem.WriteAllText("login\Users\" & name & "\game.csv", score, False) ' writes score to file
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
        If File.Exists("login\Users\" & name & "\" & name & " .csv") Then ' finds if user already exists
        Else
            Console.WriteLine("Username does not exist")
            Threading.Thread.Sleep(2500)
            Console.Clear()
            Main()
        End If
        Dim pass As String = My.Computer.FileSystem.ReadAllText("login\Users\" & name & "\" & name & " .csv") 'if it does, carry on with login
        password = SecureReadLine() ' enter password
        password = Trim(password) ' removes whitespaces
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
            Console.WriteLine("User name already exists") ' check if name exists
            Threading.Thread.Sleep(2000)
            Register()
        End If
        Dim password = SecureReadLine()
        If password = "password" Then ' password check
            Console.WriteLine("Don't be absurd, Use a better password!")
        Else
        End If
        System.IO.Directory.CreateDirectory("login\Users\" & user & "\")
        My.Computer.FileSystem.WriteAllText("login\Users\" & user & "\" & user & " .csv", password, False) ' make user info
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
        Console.WriteLine("|  \") ' shape menu
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
        Console.WriteLine("Your score is: " & score) 'print score
        Console.WriteLine(" __________")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine("|          |")
        Console.WriteLine(" __________")
        Dim y = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1 ' make random x and y ints
        Console.WriteLine("Y = " & y)
        Dim x = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("x = " & x)
        Dim area As String = x * y ' get area
        Dim a, b, c, d As Double
        a = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        b = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        c = area + CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1 ' make random values
        d = area - CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Dim ans As String = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1
        If ans = 1 Then
            a = area
        ElseIf ans = 2 Then
            b = area ' answer is one of those
        ElseIf ans = 3 Then
            c = area
        ElseIf ans = 4 Then
            d = area
        End If
        Console.WriteLine("A=" & a & " B=" & b & " C=" & c & " D=" & d & " Q: Go to menu") ' prints options
        Console.WriteLine("Enter Answer")
        ans = Console.ReadLine() ' prompts to enter answer
        If ans = area Then
            Console.WriteLine("That is correct!")
            score += 1
            Threading.Thread.Sleep(1000) ' handles points
            square()
        ElseIf ans = "q" Or ans = "Q" Then ' go to menu
            Main()
        Else
            Console.WriteLine("That is incorrect, The correct answer was " & area) ' incorrect answer
            Threading.Thread.Sleep(1000)
            square()
        End If
        Console.Read()
    End Sub
    Sub triangle() ' same as the last one
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
        Dim ans As String = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1
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
            Console.WriteLine("That is incorrect, The correct answer was " & area)
            Threading.Thread.Sleep(1000)
            triangle()
        End If
        Console.Read()
    End Sub
    Sub circle() 'also the same
        Console.Clear()
        Console.WriteLine("Your score is: " & score)

        Console.WriteLine("     *  *")
        Console.WriteLine("  *        *")
        Console.WriteLine(" *          *")
        Console.WriteLine(" *          *")
        Console.WriteLine("  *        *")
        Console.WriteLine("     *  *")
        Dim area As String = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
        Console.WriteLine("Radius " & area)

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
            Console.WriteLine("That is incorrect, The correct answer was " & area)
            Threading.Thread.Sleep(1000)
            circle()
        End If
        Console.Read()
    End Sub

    Public Function SecureReadLine() ' function to handle console input with stars
        Dim passwordMask As Char = "*"c
        Dim pwd As String = String.Empty
        Dim sb As New System.Text.StringBuilder() ' dims
        Dim cki As ConsoleKeyInfo = Nothing

        'Get the password
        Console.WriteLine("Enter password: ") ' prompts password input
        While (True)
            While Console.KeyAvailable() = False
                System.Threading.Thread.Sleep(50)
            End While
            cki = Console.ReadKey(True)
            If cki.Key = ConsoleKey.Enter Then ' prints stars
                Console.WriteLine()
                Exit While
            ElseIf cki.Key = ConsoleKey.Backspace Then
                If sb.Length > 0 Then ' handles backspaces
                    sb.Length -= 1
                    Console.Write(ChrW(8) & ChrW(32) & ChrW(8))
                End If
                Continue While
            ElseIf Asc(cki.KeyChar) < 32 OrElse Asc(cki.KeyChar) > 126 Then 'ends
                Continue While
            End If
            sb.Append(cki.KeyChar)
            Console.Write(passwordMask)
        End While ' returnss
        pwd = sb.ToString()
        Return pwd
    End Function
End Module
