<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivacyPolicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem1, Me.InstructionToolStripMenuItem, Me.InformationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegisterToolStripMenuItem1
        '
        Me.RegisterToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem2, Me.LoginToolStripMenuItem1})
        Me.RegisterToolStripMenuItem1.Name = "RegisterToolStripMenuItem1"
        Me.RegisterToolStripMenuItem1.Size = New System.Drawing.Size(64, 20)
        Me.RegisterToolStripMenuItem1.Text = "Account"
        '
        'RegisterToolStripMenuItem2
        '
        Me.RegisterToolStripMenuItem2.Name = "RegisterToolStripMenuItem2"
        Me.RegisterToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.RegisterToolStripMenuItem2.Text = "Register"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'InstructionToolStripMenuItem
        '
        Me.InstructionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionToolStripMenuItem1})
        Me.InstructionToolStripMenuItem.Name = "InstructionToolStripMenuItem"
        Me.InstructionToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.InstructionToolStripMenuItem.Text = "Instruction"
        '
        'InstructionToolStripMenuItem1
        '
        Me.InstructionToolStripMenuItem1.Name = "InstructionToolStripMenuItem1"
        Me.InstructionToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.InstructionToolStripMenuItem1.Text = "Instruction"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrivacyPolicyToolStripMenuItem})
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'PrivacyPolicyToolStripMenuItem
        '
        Me.PrivacyPolicyToolStripMenuItem.Name = "PrivacyPolicyToolStripMenuItem"
        Me.PrivacyPolicyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrivacyPolicyToolStripMenuItem.Text = "Agreement"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 483)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegisterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InstructionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrivacyPolicyToolStripMenuItem As ToolStripMenuItem
End Class
