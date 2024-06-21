<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        createEmail = New TextBox()
        createName = New TextBox()
        createGithubLink = New TextBox()
        createPhoneNum = New TextBox()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 21)
        Label1.TabIndex = 0
        Label1.Text = "Kunal Gupta, Slidely Task 2- Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
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
        ' createEmail
        ' 
        createEmail.BackColor = Color.Gainsboro
        createEmail.BorderStyle = BorderStyle.FixedSingle
        createEmail.Location = New Point(103, 92)
        createEmail.Name = "createEmail"
        createEmail.Size = New Size(248, 23)
        createEmail.TabIndex = 5
        ' 
        ' createName
        ' 
        createName.BackColor = Color.Gainsboro
        createName.BorderStyle = BorderStyle.FixedSingle
        createName.Location = New Point(103, 57)
        createName.Name = "createName"
        createName.Size = New Size(248, 23)
        createName.TabIndex = 6
        ' 
        ' createGithubLink
        ' 
        createGithubLink.BackColor = Color.Gainsboro
        createGithubLink.BorderStyle = BorderStyle.FixedSingle
        createGithubLink.Location = New Point(103, 172)
        createGithubLink.Multiline = True
        createGithubLink.Name = "createGithubLink"
        createGithubLink.Size = New Size(248, 45)
        createGithubLink.TabIndex = 7
        ' 
        ' createPhoneNum
        ' 
        createPhoneNum.BackColor = Color.Gainsboro
        createPhoneNum.BorderStyle = BorderStyle.FixedSingle
        createPhoneNum.Location = New Point(103, 132)
        createPhoneNum.Name = "createPhoneNum"
        createPhoneNum.Size = New Size(248, 23)
        createPhoneNum.TabIndex = 9
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(12, 260)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(339, 33)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "SUBMIT (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 305)
        Controls.Add(btnSubmit)
        Controls.Add(createPhoneNum)
        Controls.Add(createGithubLink)
        Controls.Add(createName)
        Controls.Add(createEmail)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents createEmail As TextBox
    Friend WithEvents createName As TextBox
    Friend WithEvents createGithubLink As TextBox
    Friend WithEvents createPhoneNum As TextBox
    Friend WithEvents btnSubmit As Button
End Class
