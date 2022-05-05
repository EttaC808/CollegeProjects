<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInternetSpeedTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formInternetSpeedTest))
        Me.internetTestLbl = New System.Windows.Forms.Label()
        Me.enterInternetSpeedBtn = New System.Windows.Forms.Button()
        Me.internetSpeedTestImage = New System.Windows.Forms.PictureBox()
        Me.displayAvgInternetSpeedLbld = New System.Windows.Forms.Label()
        Me.inputInternetSpeedListBox = New System.Windows.Forms.ListBox()
        CType(Me.internetSpeedTestImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'internetTestLbl
        '
        Me.internetTestLbl.AutoSize = True
        Me.internetTestLbl.Font = New System.Drawing.Font("Tahoma", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.internetTestLbl.Location = New System.Drawing.Point(222, 9)
        Me.internetTestLbl.Name = "internetTestLbl"
        Me.internetTestLbl.Size = New System.Drawing.Size(340, 29)
        Me.internetTestLbl.TabIndex = 0
        Me.internetTestLbl.Text = "Internet Speed Test Survey"
        '
        'enterInternetSpeedBtn
        '
        Me.enterInternetSpeedBtn.BackColor = System.Drawing.Color.DarkKhaki
        Me.enterInternetSpeedBtn.Font = New System.Drawing.Font("Arial", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterInternetSpeedBtn.Location = New System.Drawing.Point(362, 71)
        Me.enterInternetSpeedBtn.Name = "enterInternetSpeedBtn"
        Me.enterInternetSpeedBtn.Size = New System.Drawing.Size(200, 40)
        Me.enterInternetSpeedBtn.TabIndex = 1
        Me.enterInternetSpeedBtn.Text = "Enter Internet Speed"
        Me.enterInternetSpeedBtn.UseVisualStyleBackColor = False
        '
        'internetSpeedTestImage
        '
        Me.internetSpeedTestImage.Image = CType(resources.GetObject("internetSpeedTestImage.Image"), System.Drawing.Image)
        Me.internetSpeedTestImage.Location = New System.Drawing.Point(-2, 117)
        Me.internetSpeedTestImage.Name = "internetSpeedTestImage"
        Me.internetSpeedTestImage.Size = New System.Drawing.Size(475, 275)
        Me.internetSpeedTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.internetSpeedTestImage.TabIndex = 2
        Me.internetSpeedTestImage.TabStop = False
        '
        'displayAvgInternetSpeedLbld
        '
        Me.displayAvgInternetSpeedLbld.AutoSize = True
        Me.displayAvgInternetSpeedLbld.Font = New System.Drawing.Font("Arial", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayAvgInternetSpeedLbld.Location = New System.Drawing.Point(422, 395)
        Me.displayAvgInternetSpeedLbld.Name = "displayAvgInternetSpeedLbld"
        Me.displayAvgInternetSpeedLbld.Size = New System.Drawing.Size(187, 16)
        Me.displayAvgInternetSpeedLbld.TabIndex = 4
        Me.displayAvgInternetSpeedLbld.Text = "Average Internet Speed:  "
        '
        'inputInternetSpeedListBox
        '
        Me.inputInternetSpeedListBox.Font = New System.Drawing.Font("Arial", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputInternetSpeedListBox.FormattingEnabled = True
        Me.inputInternetSpeedListBox.HorizontalScrollbar = True
        Me.inputInternetSpeedListBox.ItemHeight = 16
        Me.inputInternetSpeedListBox.Location = New System.Drawing.Point(702, 71)
        Me.inputInternetSpeedListBox.Name = "inputInternetSpeedListBox"
        Me.inputInternetSpeedListBox.Size = New System.Drawing.Size(70, 100)
        Me.inputInternetSpeedListBox.TabIndex = 5
        '
        'formInternetSpeedTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.inputInternetSpeedListBox)
        Me.Controls.Add(Me.displayAvgInternetSpeedLbld)
        Me.Controls.Add(Me.internetSpeedTestImage)
        Me.Controls.Add(Me.enterInternetSpeedBtn)
        Me.Controls.Add(Me.internetTestLbl)
        Me.Name = "formInternetSpeedTest"
        Me.Text = "formInternetSpeedSurvey"
        CType(Me.internetSpeedTestImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents internetTestLbl As Label
    Friend WithEvents enterInternetSpeedBtn As Button
    Friend WithEvents internetSpeedTestImage As PictureBox
    Friend WithEvents displayAvgInternetSpeedLbld As Label
    Friend WithEvents inputInternetSpeedListBox As ListBox
End Class
