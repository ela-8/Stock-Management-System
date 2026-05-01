Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class LoginForm
    Private filePath As String = Path.Combine(Application.StartupPath, "users.txt")
    Private attempts As Integer = 0
    Private Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function
    'Sign up
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim hashedPassword As String = HashPassword(password)

        ' Validation
        If username = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        If username.Contains(",") Then
            MessageBox.Show("Username cannot contain commas.")
            Exit Sub
        End If

        If password.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters.")
            Exit Sub
        End If

        ' Check if user already exists
        Dim lines() As String = {}
        If File.Exists(filePath) Then
            lines = File.ReadAllLines(filePath)
        End If
        ' Loop through each line in the file to find matching user
        For Each line In lines
            If line.Trim() = "" Then Continue For

            Dim parts() As String = line.Split(",")

            If parts.Length < 2 Then Continue For

            If parts(0).Trim().ToLower() = username.Trim().ToLower() Then
                MessageBox.Show("Username already exists.")
                Exit Sub
            End If

        Next

        ' Save new user
        Using writer As New StreamWriter(filePath, True)
            writer.WriteLine(username & "," & hashedPassword)
        End Using
        MessageBox.Show("Account created successfully.")
        txtUsername.Clear()
        txtPassword.Clear()


    End Sub
    'Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim hashedPassword As String = HashPassword(password)

        ' Validation
        If username = "" Or password = "" Then
            MessageBox.Show("Please enter all fields.")
            Exit Sub
        End If

        ' Check if file exists
        If Not File.Exists(filePath) Then
            MessageBox.Show("No users found. Please sign up first.")
            Exit Sub
        End If

        Dim lines() As String = File.ReadAllLines(filePath)
        Dim found As Boolean = False

        ' Loop through users
        For Each line In lines
            If line.Trim() = "" Then Continue For

            Dim parts() As String = line.Split(",")

            If parts.Length < 2 Then Continue For

            If parts(0).Trim().ToLower() = username.Trim().ToLower() AndAlso parts(1) = hashedPassword Then
                found = True
                Exit For
            End If
        Next

        If found = True Then
            MessageBox.Show("Welcome, " & username & "!")
            attempts = 0 ' reset attempts on success
            MainMenu.CurrentUser = username
            Dim menu As New MainMenu()
            menu.Show()
            Me.Hide()
        Else
            attempts += 1
            MessageBox.Show("Invalid username or password. Attempt " & attempts & " of 3.")

            If attempts >= 3 Then
                MessageBox.Show("Too many failed attempts. Application will close.")
                Application.Exit()
            End If
        End If

    End Sub


End Class
