<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Labli3 = New Label()
        labli4 = New Label()
        txtFirst = New TextBox()
        txtFather = New TextBox()
        txtGrand = New TextBox()
        txtResult = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Emoji", 10.2F)
        Label1.Location = New Point(335, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 0
        Label1.Text = "الاسم الاول"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Emoji", 10.2F)
        Label2.Location = New Point(335, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 1
        Label2.Text = "اسم الأب"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Labli3
        ' 
        Labli3.Font = New Font("Segoe UI Emoji", 10.2F)
        Labli3.Location = New Point(335, 262)
        Labli3.Name = "Labli3"
        Labli3.Size = New Size(107, 25)
        Labli3.TabIndex = 2
        Labli3.Text = "اسم الجد"
        Labli3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labli4
        ' 
        labli4.Font = New Font("Segoe UI Emoji", 10.2F)
        labli4.Location = New Point(335, 319)
        labli4.Name = "labli4"
        labli4.Size = New Size(107, 25)
        labli4.TabIndex = 3
        labli4.Text = "النتيجة"
        labli4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtFirst
        ' 
        txtFirst.BackColor = SystemColors.Menu
        txtFirst.Location = New Point(124, 160)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(125, 27)
        txtFirst.TabIndex = 4
        txtFirst.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtFather
        ' 
        txtFather.BackColor = SystemColors.Menu
        txtFather.Location = New Point(124, 207)
        txtFather.Name = "txtFather"
        txtFather.Size = New Size(125, 27)
        txtFather.TabIndex = 5
        txtFather.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGrand
        ' 
        txtGrand.BackColor = SystemColors.Menu
        txtGrand.Location = New Point(124, 260)
        txtGrand.Name = "txtGrand"
        txtGrand.Size = New Size(125, 27)
        txtGrand.TabIndex = 6
        txtGrand.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(58, 319)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(258, 27)
        txtResult.TabIndex = 7
        txtResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Button1.Location = New Point(59, 446)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 55)
        Button1.TabIndex = 8
        Button1.Text = "طباعة الأب"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.AppWorkspace
        Button2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Button2.Location = New Point(213, 446)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 55)
        Button2.TabIndex = 9
        Button2.Text = "حذف الجد"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.AppWorkspace
        Button3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Button3.Location = New Point(375, 446)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 55)
        Button3.TabIndex = 10
        Button3.Text = "اضافة ابن"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(544, 573)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtResult)
        Controls.Add(txtGrand)
        Controls.Add(txtFather)
        Controls.Add(txtFirst)
        Controls.Add(labli4)
        Controls.Add(Labli3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Labli3 As Label
    Friend WithEvents labli4 As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtFather As TextBox
    Friend WithEvents txtGrand As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
