<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        viewName = New TextBox()
        viewEmail = New TextBox()
        viewGithubLink = New TextBox()
        viewPhoneNum = New TextBox()
        viewStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 21)
        Label1.TabIndex = 0
        Label1.Text = "Kunal Gupta, Slidely Task 2- View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 4
        Label5.Text = "Github Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 15)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch time"
        ' 
        ' viewName
        ' 
        viewName.BackColor = Color.Gainsboro
        viewName.BorderStyle = BorderStyle.FixedSingle
        viewName.Location = New Point(108, 60)
        viewName.Name = "viewName"
        viewName.ReadOnly = True
        viewName.Size = New Size(237, 23)
        viewName.TabIndex = 6
        viewName.TextAlign = HorizontalAlignment.Center
        ' 
        ' viewEmail
        ' 
        viewEmail.BackColor = Color.Gainsboro
        viewEmail.BorderStyle = BorderStyle.FixedSingle
        viewEmail.Location = New Point(108, 100)
        viewEmail.Name = "viewEmail"
        viewEmail.ReadOnly = True
        viewEmail.Size = New Size(237, 23)
        viewEmail.TabIndex = 7
        viewEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' viewGithubLink
        ' 
        viewGithubLink.BackColor = Color.Gainsboro
        viewGithubLink.BorderStyle = BorderStyle.FixedSingle
        viewGithubLink.Location = New Point(108, 180)
        viewGithubLink.Multiline = True
        viewGithubLink.Name = "viewGithubLink"
        viewGithubLink.ReadOnly = True
        viewGithubLink.Size = New Size(237, 45)
        viewGithubLink.TabIndex = 8
        viewGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' viewPhoneNum
        ' 
        viewPhoneNum.BackColor = Color.Gainsboro
        viewPhoneNum.BorderStyle = BorderStyle.FixedSingle
        viewPhoneNum.Location = New Point(108, 140)
        viewPhoneNum.Name = "viewPhoneNum"
        viewPhoneNum.ReadOnly = True
        viewPhoneNum.Size = New Size(237, 23)
        viewPhoneNum.TabIndex = 9
        viewPhoneNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' viewStopwatchTime
        ' 
        viewStopwatchTime.BackColor = Color.Gainsboro
        viewStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        viewStopwatchTime.Location = New Point(108, 242)
        viewStopwatchTime.Name = "viewStopwatchTime"
        viewStopwatchTime.ReadOnly = True
        viewStopwatchTime.Size = New Size(237, 23)
        viewStopwatchTime.TabIndex = 10
        viewStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(12, 285)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(165, 29)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ControlLightLight
        btnNext.FlatAppearance.BorderColor = Color.Black
        btnNext.ForeColor = SystemColors.ControlText
        btnNext.Location = New Point(183, 285)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(162, 29)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(357, 326)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(viewStopwatchTime)
        Controls.Add(viewPhoneNum)
        Controls.Add(viewGithubLink)
        Controls.Add(viewEmail)
        Controls.Add(viewName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents viewName As TextBox
    Friend WithEvents viewEmail As TextBox
    Friend WithEvents viewGithubLink As TextBox
    Friend WithEvents viewPhoneNum As TextBox
    Friend WithEvents viewStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
