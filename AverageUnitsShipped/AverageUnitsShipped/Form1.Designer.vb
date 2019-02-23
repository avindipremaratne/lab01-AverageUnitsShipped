<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lbDays = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lbDisplayAverage = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.tbDisplay = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbDays
        '
        Me.lbDays.AutoSize = True
        Me.lbDays.Location = New System.Drawing.Point(188, 15)
        Me.lbDays.Name = "lbDays"
        Me.lbDays.Size = New System.Drawing.Size(0, 13)
        Me.lbDays.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(188, 232)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exits the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(100, 232)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Resets the values")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(14, 232)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(80, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Enters the value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lbDisplayAverage
        '
        Me.lbDisplayAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDisplayAverage.Location = New System.Drawing.Point(44, 207)
        Me.lbDisplayAverage.Name = "lbDisplayAverage"
        Me.lbDisplayAverage.Size = New System.Drawing.Size(200, 23)
        Me.lbDisplayAverage.TabIndex = 4
        Me.lbDisplayAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbDisplayAverage, "Display average")
        '
        'tbInput
        '
        Me.tbInput.Location = New System.Drawing.Point(95, 15)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(61, 20)
        Me.tbInput.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tbInput, "Inputs value")
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(47, 18)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(31, 13)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "&Units"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbDisplay
        '
        Me.tbDisplay.Location = New System.Drawing.Point(53, 53)
        Me.tbDisplay.Multiline = True
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Size = New System.Drawing.Size(173, 140)
        Me.tbDisplay.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbDisplay, "Outputs the values entered")
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(285, 276)
        Me.Controls.Add(Me.tbDisplay)
        Me.Controls.Add(Me.lbDays)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbDisplayAverage)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lbUnits)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avearge Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbDays As Label
    Private WithEvents btnExit As Button
    Private WithEvents btnReset As Button
    Private WithEvents btnEnter As Button
    Private WithEvents lbDisplayAverage As Label
    Private WithEvents tbInput As TextBox
    Private WithEvents lbUnits As Label
    Friend WithEvents tbDisplay As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
