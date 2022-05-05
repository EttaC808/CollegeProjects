<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostRainfallUSAForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mostRainfallUSAForm))
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.rainfallTitleLbl = New System.Windows.Forms.Label()
        Me.rainfallBtn = New System.Windows.Forms.Button()
        Me.rainfallListBox = New System.Windows.Forms.ListBox()
        Me.avgRainfall = New System.Windows.Forms.Label()
        Me.avgRainfallEstimateLbl = New System.Windows.Forms.Label()
        Me.mnuFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(865, 27)
        Me.mnuFile.TabIndex = 0
        Me.mnuFile.Text = "mnuRainfall"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(206, 24)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(206, 24)
        Me.mnuExit.Text = "E&xit"
        '
        'rainfallTitleLbl
        '
        Me.rainfallTitleLbl.AutoSize = True
        Me.rainfallTitleLbl.Font = New System.Drawing.Font("Arial", 20.29091!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rainfallTitleLbl.ForeColor = System.Drawing.Color.Red
        Me.rainfallTitleLbl.Location = New System.Drawing.Point(26, 47)
        Me.rainfallTitleLbl.Name = "rainfallTitleLbl"
        Me.rainfallTitleLbl.Size = New System.Drawing.Size(457, 36)
        Me.rainfallTitleLbl.TabIndex = 1
        Me.rainfallTitleLbl.Text = "Most Rainfall in the US - Kauai"
        '
        'rainfallBtn
        '
        Me.rainfallBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.rainfallBtn.Font = New System.Drawing.Font("Tahoma", 13.74545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rainfallBtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rainfallBtn.Location = New System.Drawing.Point(181, 187)
        Me.rainfallBtn.Name = "rainfallBtn"
        Me.rainfallBtn.Size = New System.Drawing.Size(201, 40)
        Me.rainfallBtn.TabIndex = 2
        Me.rainfallBtn.Text = "Enter Rainfall"
        Me.rainfallBtn.UseVisualStyleBackColor = False
        '
        'rainfallListBox
        '
        Me.rainfallListBox.Font = New System.Drawing.Font("Arial", 13.74545!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rainfallListBox.ForeColor = System.Drawing.Color.Red
        Me.rainfallListBox.FormattingEnabled = True
        Me.rainfallListBox.ItemHeight = 24
        Me.rainfallListBox.Location = New System.Drawing.Point(650, 47)
        Me.rainfallListBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rainfallListBox.Name = "rainfallListBox"
        Me.rainfallListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rainfallListBox.Size = New System.Drawing.Size(81, 292)
        Me.rainfallListBox.TabIndex = 3
        '
        'avgRainfall
        '
        Me.avgRainfall.AutoSize = True
        Me.avgRainfall.Font = New System.Drawing.Font("Tahoma", 9.818182!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgRainfall.ForeColor = System.Drawing.Color.RoyalBlue
        Me.avgRainfall.Location = New System.Drawing.Point(210, 120)
        Me.avgRainfall.Name = "avgRainfall"
        Me.avgRainfall.Size = New System.Drawing.Size(150, 19)
        Me.avgRainfall.TabIndex = 4
        Me.avgRainfall.Text = "Rainfall Average "
        '
        'avgRainfallEstimateLbl
        '
        Me.avgRainfallEstimateLbl.AutoSize = True
        Me.avgRainfallEstimateLbl.Font = New System.Drawing.Font("Verdana", 13.74545!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgRainfallEstimateLbl.ForeColor = System.Drawing.Color.Red
        Me.avgRainfallEstimateLbl.Location = New System.Drawing.Point(27, 298)
        Me.avgRainfallEstimateLbl.Name = "avgRainfallEstimateLbl"
        Me.avgRainfallEstimateLbl.Size = New System.Drawing.Size(525, 26)
        Me.avgRainfallEstimateLbl.TabIndex = 5
        Me.avgRainfallEstimateLbl.Text = "Average Rainfall per Month is X.X Inches"
        Me.avgRainfallEstimateLbl.Visible = False
        '
        'mostRainfallUSAForm
        '
        Me.AcceptButton = Me.rainfallBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(865, 633)
        Me.Controls.Add(Me.avgRainfallEstimateLbl)
        Me.Controls.Add(Me.avgRainfall)
        Me.Controls.Add(Me.rainfallListBox)
        Me.Controls.Add(Me.rainfallBtn)
        Me.Controls.Add(Me.rainfallTitleLbl)
        Me.Controls.Add(Me.mnuFile)
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "mostRainfallUSAForm"
        Me.Text = "Most Rainfall in the USA"
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents rainfallTitleLbl As Label
    Friend WithEvents rainfallBtn As Button
    Friend WithEvents rainfallListBox As ListBox
    Friend WithEvents avgRainfall As Label
    Friend WithEvents avgRainfallEstimateLbl As Label
End Class
