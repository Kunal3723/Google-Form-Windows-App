Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub View_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for CTRL+Y key combination
        Dim btnToggleStopwatch As Button = DirectCast(Me.Controls("btnToggleStopwatch"), Button)
        If e.Control AndAlso e.KeyCode = Keys.V Then
            View_Click(btnViewSubmissions, EventArgs.Empty)
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            Create_Click(btnCreateSubmission, EventArgs.Empty)
        End If

    End Sub

End Class
