<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VotingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VotingForm))
        Me.lblPRES = New System.Windows.Forms.Label()
        Me.lblVP = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPRES
        '
        Me.lblPRES.AutoSize = True
        Me.lblPRES.BackColor = System.Drawing.Color.Transparent
        Me.lblPRES.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPRES.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPRES.Location = New System.Drawing.Point(34, 116)
        Me.lblPRES.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPRES.Name = "lblPRES"
        Me.lblPRES.Size = New System.Drawing.Size(118, 27)
        Me.lblPRES.TabIndex = 0
        Me.lblPRES.Text = "President"
        '
        'lblVP
        '
        Me.lblVP.AutoSize = True
        Me.lblVP.BackColor = System.Drawing.Color.Transparent
        Me.lblVP.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVP.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblVP.Location = New System.Drawing.Point(337, 116)
        Me.lblVP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVP.Name = "lblVP"
        Me.lblVP.Size = New System.Drawing.Size(175, 27)
        Me.lblVP.TabIndex = 1
        Me.lblVP.Text = "Vice President"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ABARRONDO, EVELIA  ", "DE GUZMAN, LEODY   ", "BALBOA, EDWARD   "})
        Me.ComboBox1.Location = New System.Drawing.Point(39, 148)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox1.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"ANDRADE, SONNY BOY ", "GONZALES, NORBERTO  ", "MURIO, JOSE ROMEL "})
        Me.ComboBox2.Location = New System.Drawing.Point(342, 148)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox2.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(215, 522)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 35)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Submit Votes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox10)
        Me.GroupBox1.Controls.Add(Me.ComboBox9)
        Me.GroupBox1.Controls.Add(Me.ComboBox8)
        Me.GroupBox1.Controls.Add(Me.ComboBox7)
        Me.GroupBox1.Controls.Add(Me.ComboBox6)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Location = New System.Drawing.Point(22, 203)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(611, 287)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Senator"
        '
        'ComboBox10
        '
        Me.ComboBox10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox10.Location = New System.Drawing.Point(320, 235)
        Me.ComboBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox10.TabIndex = 7
        '
        'ComboBox9
        '
        Me.ComboBox9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox9.Location = New System.Drawing.Point(320, 173)
        Me.ComboBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox9.TabIndex = 6
        '
        'ComboBox8
        '
        Me.ComboBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox8.Location = New System.Drawing.Point(320, 113)
        Me.ComboBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox8.TabIndex = 5
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox7.Location = New System.Drawing.Point(320, 52)
        Me.ComboBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox7.TabIndex = 4
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox6.Location = New System.Drawing.Point(8, 235)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox6.TabIndex = 3
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox5.Location = New System.Drawing.Point(8, 173)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox5.TabIndex = 2
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox4.Location = New System.Drawing.Point(8, 113)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox4.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"ANIÑON, DEL CRUZ    ", "ANTIPORDA, ARSENIO ", "ARAP, SALIC       ", "DE GUZMAN, KEVIN    ", "DE VERA, RODEL     ", "FLORES, RUDY       ", "GAA, KAMADHENU      ", "KAYANAN, WINSTON    ", "MEGIO, NANCY         ", "MURIO, JOSE ROMEL   ", "RAVAL, MINDA          ", "ROBREDA, LANI        ", "SEÑO, CORNELIO      ", "TAGLE, PEDRITO      ", "VALDES, ANTONIO     ", "ZY, DOGAN"})
        Me.ComboBox3.Location = New System.Drawing.Point(8, 52)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(275, 30)
        Me.ComboBox3.TabIndex = 0
        '
        'VotingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 614)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblVP)
        Me.Controls.Add(Me.lblPRES)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VotingForm"
        Me.Text = "VOTING FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPRES As Label
    Friend WithEvents lblVP As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
