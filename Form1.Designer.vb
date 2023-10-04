<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        txtHeight = New TextBox()
        txtWeight = New TextBox()
        txtBMI = New TextBox()
        txtComment = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(238, 324)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Calculate your BMI"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(151, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter your Weight"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(151, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 25)
        Label2.TabIndex = 1
        Label2.Text = "Enter your Height"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(151, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 25)
        Label3.TabIndex = 1
        Label3.Text = "Your BMI is"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(151, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 25)
        Label4.TabIndex = 1
        Label4.Text = "What it means"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(322, 100)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(322, 38)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 2
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(322, 100)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(150, 31)
        txtHeight.TabIndex = 2
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(322, 38)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(150, 31)
        txtWeight.TabIndex = 2
        ' 
        ' txtBMI
        ' 
        txtBMI.Location = New Point(322, 151)
        txtBMI.Name = "txtBMI"
        txtBMI.Size = New Size(150, 31)
        txtBMI.TabIndex = 2
        ' 
        ' txtComment
        ' 
        txtComment.Location = New Point(283, 208)
        txtComment.Name = "txtComment"
        txtComment.Size = New Size(484, 31)
        txtComment.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(txtWeight)
        Controls.Add(TextBox2)
        Controls.Add(txtComment)
        Controls.Add(txtBMI)
        Controls.Add(txtHeight)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Calculate your BMI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents txtComment As TextBox
End Class
