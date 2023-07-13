<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABLESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.TABLESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1405, 37)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.LOGINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem1})
        Me.LOGINToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(118, 33)
        Me.LOGINToolStripMenuItem.Text = "Account"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.BackColor = System.Drawing.Color.Firebrick
        Me.LogoutToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(181, 34)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'TABLESToolStripMenuItem
        '
        Me.TABLESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRATIONToolStripMenuItem, Me.VOTESToolStripMenuItem})
        Me.TABLESToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TABLESToolStripMenuItem.Name = "TABLESToolStripMenuItem"
        Me.TABLESToolStripMenuItem.Size = New System.Drawing.Size(100, 33)
        Me.TABLESToolStripMenuItem.Text = "Tables"
        '
        'REGISTRATIONToolStripMenuItem
        '
        Me.REGISTRATIONToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
        Me.REGISTRATIONToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.REGISTRATIONToolStripMenuItem.Name = "REGISTRATIONToolStripMenuItem"
        Me.REGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(229, 34)
        Me.REGISTRATIONToolStripMenuItem.Text = "Registration"
        '
        'VOTESToolStripMenuItem
        '
        Me.VOTESToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
        Me.VOTESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VOTESToolStripMenuItem.Name = "VOTESToolStripMenuItem"
        Me.VOTESToolStripMenuItem.Size = New System.Drawing.Size(229, 34)
        Me.VOTESToolStripMenuItem.Text = "Votes"
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1405, 878)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminHome"
        Me.Text = "ADMIN'S HOMEPAGE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TABLESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VOTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
End Class
