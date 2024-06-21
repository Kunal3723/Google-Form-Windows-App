Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class CreateSubmissionForm
    Private WithEvents stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Interval = 100
        Me.KeyPreview = True
        Dim btnToggleStopwatch As New Button()
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL+T)"
        btnToggleStopwatch.AutoSize = True
        btnToggleStopwatch.Location = New Point(12, 225)
        AddHandler btnToggleStopwatch.Click, AddressOf Stopwatch_Click
        Me.Controls.Add(btnToggleStopwatch)

        ' Add and configure the Label
        Dim lblTime As New TextBox()
        lblTime.Name = "lblTime"
        lblTime.Text = "00:00:00"
        lblTime.AutoSize = True
        lblTime.Location = New Point(250, 225)
        lblTime.TextAlign = HorizontalAlignment.Center
        lblTime.BackColor = Color.Gainsboro
        lblTime.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(lblTime)

        btnSubmit.Enabled = False

        AddHandler createName.TextChanged, AddressOf CheckFields
        AddHandler createEmail.TextChanged, AddressOf CheckFields
        AddHandler createPhoneNum.TextChanged, AddressOf CheckFields
        AddHandler createGithubLink.TextChanged, AddressOf CheckFields
        AddHandler lblTime.TextChanged, AddressOf CheckFields

    End Sub

    Private Async Sub Submit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Name As String = createName.Text
        Dim Email As String = createEmail.Text
        Dim PhoneNum As String = createPhoneNum.Text
        Dim GithubLink As String = createGithubLink.Text
        Dim lblTime As TextBox = DirectCast(Me.Controls("lblTime"), TextBox)
        Dim StopwatchTime As String = lblTime.Text

        stopwatch.Stop()
        timer.Stop()

        ' Create the submission object
        Dim submission As New Dictionary(Of String, String) From {
        {"name", Name},
        {"email", Email},
        {"phone", PhoneNum},
        {"github_link", GithubLink},
        {"stopwatch_time", StopwatchTime}
    }

        ' Convert the submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)

        ' Create an instance of HttpClient
        Using client As New HttpClient()
            Try
                ' Set the base address of the client
                client.BaseAddress = New Uri("http://localhost:3000/")

                ' Create the StringContent for the POST request
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")

                ' Make the POST request
                Dim response As HttpResponseMessage = Await client.PostAsync("submit", content)

                ' Check if the response is successful
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                Else
                    MessageBox.Show("Error: Unable to submit the data to the backend.")
                End If
            Catch ex As Exception
                ' Handle any exceptions that occur during the request
                MessageBox.Show("Exception: " & ex.Message)
            End Try
        End Using

        Me.Close()
    End Sub

    Private Sub Stopwatch_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim lblTime As TextBox = DirectCast(Me.Controls("lblTime"), TextBox)
        lblTime.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub CheckFields(sender As Object, e As EventArgs)
        Dim lblTime As TextBox = DirectCast(Me.Controls("lblTime"), TextBox)

        If Not String.IsNullOrWhiteSpace(createName.Text) AndAlso
           Not String.IsNullOrWhiteSpace(createEmail.Text) AndAlso
           Not String.IsNullOrWhiteSpace(createPhoneNum.Text) AndAlso
           Not String.IsNullOrWhiteSpace(createGithubLink.Text) AndAlso
           Not String.IsNullOrWhiteSpace(lblTime.Text) Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for CTRL+Y key combination
        Dim btnToggleStopwatch As Button = DirectCast(Me.Controls("btnToggleStopwatch"), Button)
        If e.Control AndAlso e.KeyCode = Keys.T Then
            Stopwatch_Click(btnToggleStopwatch, EventArgs.Empty)
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then
            Submit_Click(btnSubmit, EventArgs.Empty)
        End If

    End Sub

End Class