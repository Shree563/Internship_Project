Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' Enable key preview
    End Sub





    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        stopwatch.Start()

        ' Initialize and start the timer
        timer.Interval = 1000 ' Set interval to 1 second
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
    End Sub

    ' Event handler for timer tick
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Dim elapsedTime As Long = stopwatch.ElapsedMilliseconds / 1000 ' Convert to seconds
        txtElapsedTime.Text = elapsedTime.ToString() ' Update the TextBox with elapsed time
    End Sub






    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check if Ctrl + A is pressed
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.B Then
            btnBack.PerformClick()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        stopwatch.Stop()
        Dim elapsedTime As Long = stopwatch.ElapsedMilliseconds / 1000 ' Convert to seconds
        Dim user As New Dictionary(Of String, String) From {
            {"name", txtName.Text},
            {"email", txtEmail.Text},
            {"phone", txtPhone.Text},
            {"githubLink", txtGitHub.Text},
            {"elapsedTime", elapsedTime.ToString()}
        }



        Dim json As String = JsonConvert.SerializeObject(user)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/users", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("User submitted successfully!")
                ClearForm()
            Else
                MessageBox.Show("Error submitting user.")
            End If
        End Using
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGitHub.Clear()

        ' Restart the stopwatch
        stopwatch.Reset()
        stopwatch.Start()
        timer.Start()


    End Sub






    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class