Imports System.Net.Http
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json


Public Class ViewSubmissionsForm
    Private users As List(Of User)
    Private currentIndex As Integer = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' Enable key preview
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check if Ctrl + A is pressed
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.B Then
            Button3.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub

    Public Class User
        Public Property Name As String
        Public Property email As String
        Public Property phone As String
        Public Property githubLink As String

        Public Property elapsedTime As String
    End Class
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
    End Sub

    Private Async Function LoadSubmissions() As Task
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/users")

                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    users = JsonConvert.DeserializeObject(Of List(Of User))(json)

                    ' Display the first submission by default
                    DisplaySubmission(users, currentIndex)
                Else
                    MessageBox.Show("Error fetching submissions.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Function

    Private Sub DisplaySubmission(users As List(Of User), index As Integer)
        ' Assuming labels txtNameView, txtEmailView, txtPhoneView, txtGitHubView are used to display data
        If index >= 0 AndAlso index < users.Count Then
            Dim user As User = users(index)
            txtNameView.Text = user.Name ' Ensure 'Name' matches the property in your User class
            txtEmailView.Text = user.email
            txtPhoneView.Text = user.phone
            txtGitHubView.Text = user.githubLink
            TextBox1.Text = user.elapsedTime
        Else
            MessageBox.Show("No submissions available.")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(users, currentIndex)
        Else
            MessageBox.Show("You are at the beginning of the submissions.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < users.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(users, currentIndex)
        Else
            MessageBox.Show("You are at the end of the submissions.")
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Example: Assuming you have a list or data structure where user submissions are stored
        ' and you have a way to get the ID of the selected submission to delete.

        ' Replace this with your actual logic to get the user ID to delete.
        Dim userIdToDelete As Integer = GetUserSubmissionIdToDelete()

        If userIdToDelete <> -1 Then ' Assuming -1 means no user selected
            If MessageBox.Show("Are you sure you want to delete this submission?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Using client As New HttpClient()
                        Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/users/{userIdToDelete}")

                        If response.IsSuccessStatusCode Then
                            MessageBox.Show("User submission deleted successfully!")
                            ' Optionally, reload submissions or update UI as needed
                        Else
                            MessageBox.Show("Error deleting user submission.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Please select a user submission to delete.")
        End If
    End Sub

    Private Function GetUserSubmissionIdToDelete() As Integer
        ' Replace with your logic to retrieve the ID of the submission to delete
        ' For example, if you have a DataGridView or ListBox showing submissions,
        ' you might get the selected submission's ID from there.
        ' Return the actual ID or -1 if no valid ID is available.
        Return 1 ' Example: Replace with actual logic
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
