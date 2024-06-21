Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class ViewSubmissionsForm

    Private submissions As Dictionary(Of String, String)
    Private currentIndex As Integer
    Private totalSubmissions As Integer
    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        currentIndex = 0
        submissions = GetSubmissionFromBackend(currentIndex)
        totalSubmissions = submissions("count")
        If totalSubmissions > 0 Then
            ShowSubmission(currentIndex)
        End If

        btnPrevious.Enabled = currentIndex > 0
        btnNext.Enabled = currentIndex < totalSubmissions - 1

    End Sub
    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If currentIndex > 0 Then
            currentIndex -= 1
            submissions = GetSubmissionFromBackend(currentIndex)
            ShowSubmission(currentIndex)
        End If
        btnPrevious.Enabled = currentIndex > 0
        btnNext.Enabled = currentIndex < totalSubmissions - 1

    End Sub

    Private Sub Next_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            submissions = GetSubmissionFromBackend(currentIndex)
            ShowSubmission(currentIndex)
        End If
        btnPrevious.Enabled = currentIndex > 0
        btnNext.Enabled = currentIndex < totalSubmissions - 1

    End Sub

    Private Function GetSubmissionFromBackend(index As Integer) As Dictionary(Of String, String)
        ' Define the result variable
        Dim submission As New Dictionary(Of String, String)()

        ' Create an HttpClient instance
        Using client As New HttpClient()
            ' Set the base address of the client
            client.BaseAddress = New Uri("http://localhost:3000/")

            Try
                ' Make an asynchronous GET request with the index as a query parameter
                Dim response As HttpResponseMessage = client.GetAsync("read?index=" & currentIndex).Result

                ' Check if the response is successful
                If response.IsSuccessStatusCode Then
                    ' Read the response content as a string
                    Dim responseData As String = response.Content.ReadAsStringAsync().Result

                    ' Deserialize the JSON response into a dictionary
                    submission = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(responseData)

                Else
                    ' Handle the error response here (optional)
                    MessageBox.Show("Error: Unable to fetch the submission from the backend.")
                End If
            Catch ex As Exception
                ' Handle any exceptions that occur during the request
                MessageBox.Show("Exception: " & ex.Message)
            End Try
        End Using

        ' Return the submission
        Return submission
    End Function

    Private Sub ShowSubmission(index As Integer)

        viewName.Text = submissions("name")
        viewEmail.Text = submissions("email")
        viewGithubLink.Text = submissions("github_link")
        viewPhoneNum.Text = submissions("phone")
        viewStopwatchTime.Text = submissions("stopwatch_time")
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for CTRL+Y key combination
        Dim btnToggleStopwatch As Button = DirectCast(Me.Controls("btnToggleStopwatch"), Button)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Previous_Click(btnPrevious, EventArgs.Empty)
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            Next_Click(btnNext, EventArgs.Empty)
        End If

    End Sub

End Class