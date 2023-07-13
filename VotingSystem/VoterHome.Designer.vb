<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VoterHome
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegisterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivacyPolicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem1, Me.InstructionToolStripMenuItem, Me.InformationToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 37)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegisterToolStripMenuItem1
        '
        Me.RegisterToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem2, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.RegisterToolStripMenuItem1.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterToolStripMenuItem1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.RegisterToolStripMenuItem1.Name = "RegisterToolStripMenuItem1"
        Me.RegisterToolStripMenuItem1.Size = New System.Drawing.Size(118, 33)
        Me.RegisterToolStripMenuItem1.Text = "Account"
        '
        'RegisterToolStripMenuItem2
        '
        Me.RegisterToolStripMenuItem2.BackColor = System.Drawing.Color.Firebrick
        Me.RegisterToolStripMenuItem2.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.RegisterToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.RegisterToolStripMenuItem2.Name = "RegisterToolStripMenuItem2"
        Me.RegisterToolStripMenuItem2.Size = New System.Drawing.Size(187, 34)
        Me.RegisterToolStripMenuItem2.Text = "Register"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(187, 34)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(187, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'InstructionToolStripMenuItem
        '
        Me.InstructionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionToolStripMenuItem1})
        Me.InstructionToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.InstructionToolStripMenuItem.Name = "InstructionToolStripMenuItem"
        Me.InstructionToolStripMenuItem.Size = New System.Drawing.Size(145, 33)
        Me.InstructionToolStripMenuItem.Text = "Instruction"
        '
        'InstructionToolStripMenuItem1
        '
        Me.InstructionToolStripMenuItem1.BackColor = System.Drawing.Color.Firebrick
        Me.InstructionToolStripMenuItem1.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.InstructionToolStripMenuItem1.Name = "InstructionToolStripMenuItem1"
        Me.InstructionToolStripMenuItem1.Size = New System.Drawing.Size(212, 34)
        Me.InstructionToolStripMenuItem1.Text = "Instruction"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrivacyPolicyToolStripMenuItem})
        Me.InformationToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformationToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(155, 33)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'PrivacyPolicyToolStripMenuItem
        '
        Me.PrivacyPolicyToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
        Me.PrivacyPolicyToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrivacyPolicyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PrivacyPolicyToolStripMenuItem.Name = "PrivacyPolicyToolStripMenuItem"
        Me.PrivacyPolicyToolStripMenuItem.Size = New System.Drawing.Size(221, 34)
        Me.PrivacyPolicyToolStripMenuItem.Text = "Agreement"
        '
        'VoterHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1366, 1055)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VoterHome"
        Me.Text = "VOTER'S HOMEPAGE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegisterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InstructionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrivacyPolicyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
