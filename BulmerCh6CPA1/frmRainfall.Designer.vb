<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfall
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
        Me.mnuFitness = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAverageRainfall = New System.Windows.Forms.Label()
        Me.lstRainfall = New System.Windows.Forms.ListBox()
        Me.btnRainfall = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuFitness.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFitness
        '
        Me.mnuFitness.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuClear, Me.mnuExit})
        Me.mnuFitness.Location = New System.Drawing.Point(0, 0)
        Me.mnuFitness.Name = "mnuFitness"
        Me.mnuFitness.Size = New System.Drawing.Size(739, 24)
        Me.mnuFitness.TabIndex = 5
        Me.mnuFitness.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(46, 20)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(38, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'lblAverageRainfall
        '
        Me.lblAverageRainfall.AutoSize = True
        Me.lblAverageRainfall.BackColor = System.Drawing.Color.White
        Me.lblAverageRainfall.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageRainfall.ForeColor = System.Drawing.Color.Red
        Me.lblAverageRainfall.Location = New System.Drawing.Point(14, 240)
        Me.lblAverageRainfall.Name = "lblAverageRainfall"
        Me.lblAverageRainfall.Size = New System.Drawing.Size(492, 29)
        Me.lblAverageRainfall.TabIndex = 9
        Me.lblAverageRainfall.Text = "Average Rainfall per Month is X.X inches"
        Me.lblAverageRainfall.Visible = False
        '
        'lstRainfall
        '
        Me.lstRainfall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRainfall.ForeColor = System.Drawing.Color.Red
        Me.lstRainfall.FormattingEnabled = True
        Me.lstRainfall.ItemHeight = 23
        Me.lstRainfall.Location = New System.Drawing.Point(527, 76)
        Me.lstRainfall.Name = "lstRainfall"
        Me.lstRainfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstRainfall.Size = New System.Drawing.Size(50, 257)
        Me.lstRainfall.TabIndex = 8
        '
        'btnRainfall
        '
        Me.btnRainfall.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRainfall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRainfall.Location = New System.Drawing.Point(80, 114)
        Me.btnRainfall.Name = "btnRainfall"
        Me.btnRainfall.Size = New System.Drawing.Size(207, 38)
        Me.btnRainfall.TabIndex = 7
        Me.btnRainfall.Text = "Enter Rainfall"
        Me.btnRainfall.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(12, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(484, 42)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Most Rainfall in US - Kauai"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(116, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Rainfall Average"
        '
        'frmRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BulmerCh6CPA1.My.Resources.Resources.hawaii
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(739, 370)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuFitness)
        Me.Controls.Add(Me.lblAverageRainfall)
        Me.Controls.Add(Me.lstRainfall)
        Me.Controls.Add(Me.btnRainfall)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmRainfall"
        Me.Text = "Most Rainfall in US"
        Me.mnuFitness.ResumeLayout(False)
        Me.mnuFitness.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFitness As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblAverageRainfall As Label
    Friend WithEvents lstRainfall As ListBox
    Friend WithEvents btnRainfall As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
End Class
