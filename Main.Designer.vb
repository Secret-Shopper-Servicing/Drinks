<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HelperButton = New System.Windows.Forms.Button()
        Me.OrangeButton = New System.Windows.Forms.Button()
        Me.MilkButton = New System.Windows.Forms.Button()
        Me.BeverageButton = New System.Windows.Forms.Button()
        Me.CoffeeButton = New System.Windows.Forms.Button()
        Me.WaterButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palace Script MT", 72.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MistyRose
        Me.Label2.Location = New System.Drawing.Point(4, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 89)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Drinks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Salmon
        Me.Label3.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MistyRose
        Me.Label3.Location = New System.Drawing.Point(235, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 72)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Do You Ever Find" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yourself In Need Of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Drinks And Thirst ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use This For The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Onl" & _
            "y Best Drinks In" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The World!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'HelperButton
        '
        Me.HelperButton.Image = Global.Drinks.My.Resources.Resources.Help
        Me.HelperButton.Location = New System.Drawing.Point(247, 368)
        Me.HelperButton.Name = "HelperButton"
        Me.HelperButton.Size = New System.Drawing.Size(112, 58)
        Me.HelperButton.TabIndex = 8
        Me.HelperButton.UseVisualStyleBackColor = True
        '
        'OrangeButton
        '
        Me.OrangeButton.Image = Global.Drinks.My.Resources.Resources.Orange
        Me.OrangeButton.Location = New System.Drawing.Point(247, 236)
        Me.OrangeButton.Name = "OrangeButton"
        Me.OrangeButton.Size = New System.Drawing.Size(112, 126)
        Me.OrangeButton.TabIndex = 9
        Me.OrangeButton.UseVisualStyleBackColor = True
        '
        'MilkButton
        '
        Me.MilkButton.Image = Global.Drinks.My.Resources.Resources.Malk
        Me.MilkButton.Location = New System.Drawing.Point(130, 236)
        Me.MilkButton.Name = "MilkButton"
        Me.MilkButton.Size = New System.Drawing.Size(112, 92)
        Me.MilkButton.TabIndex = 7
        Me.MilkButton.UseVisualStyleBackColor = True
        '
        'BeverageButton
        '
        Me.BeverageButton.Image = Global.Drinks.My.Resources.Resources.Beverage
        Me.BeverageButton.Location = New System.Drawing.Point(12, 334)
        Me.BeverageButton.Name = "BeverageButton"
        Me.BeverageButton.Size = New System.Drawing.Size(112, 92)
        Me.BeverageButton.TabIndex = 6
        Me.BeverageButton.UseVisualStyleBackColor = True
        '
        'CoffeeButton
        '
        Me.CoffeeButton.Image = Global.Drinks.My.Resources.Resources.Cophie
        Me.CoffeeButton.Location = New System.Drawing.Point(129, 334)
        Me.CoffeeButton.Name = "CoffeeButton"
        Me.CoffeeButton.Size = New System.Drawing.Size(112, 92)
        Me.CoffeeButton.TabIndex = 5
        Me.CoffeeButton.UseVisualStyleBackColor = True
        '
        'WaterButton
        '
        Me.WaterButton.Image = Global.Drinks.My.Resources.Resources.Walter
        Me.WaterButton.Location = New System.Drawing.Point(12, 236)
        Me.WaterButton.Name = "WaterButton"
        Me.WaterButton.Size = New System.Drawing.Size(112, 92)
        Me.WaterButton.TabIndex = 4
        Me.WaterButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-9, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 141)
        Me.Panel1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(366, 438)
        Me.Controls.Add(Me.OrangeButton)
        Me.Controls.Add(Me.HelperButton)
        Me.Controls.Add(Me.MilkButton)
        Me.Controls.Add(Me.BeverageButton)
        Me.Controls.Add(Me.CoffeeButton)
        Me.Controls.Add(Me.WaterButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Drinks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents WaterButton As System.Windows.Forms.Button
    Friend WithEvents CoffeeButton As System.Windows.Forms.Button
    Friend WithEvents BeverageButton As System.Windows.Forms.Button
    Friend WithEvents MilkButton As System.Windows.Forms.Button
    Friend WithEvents HelperButton As System.Windows.Forms.Button
    Friend WithEvents OrangeButton As System.Windows.Forms.Button

End Class
