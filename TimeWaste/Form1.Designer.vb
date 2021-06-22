<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrsec = New System.Windows.Forms.Timer(Me.components)
        Me.lblSecWasted = New System.Windows.Forms.Label()
        Me.lblMinWasted = New System.Windows.Forms.Label()
        Me.tmrmin = New System.Windows.Forms.Timer(Me.components)
        Me.lblMillisWasted = New System.Windows.Forms.Label()
        Me.tmrmillis = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DisableMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableMillisItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFullTime = New System.Windows.Forms.Label()
        Me.tmrRealSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.lblCrazy = New System.Windows.Forms.Label()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Since you have opened the program you have wasted: "
        '
        'tmrsec
        '
        Me.tmrsec.Interval = 1000
        '
        'lblSecWasted
        '
        Me.lblSecWasted.AutoSize = True
        Me.lblSecWasted.Location = New System.Drawing.Point(288, 34)
        Me.lblSecWasted.Name = "lblSecWasted"
        Me.lblSecWasted.Size = New System.Drawing.Size(56, 13)
        Me.lblSecWasted.TabIndex = 1
        Me.lblSecWasted.Text = "0 seconds"
        '
        'lblMinWasted
        '
        Me.lblMinWasted.AutoSize = True
        Me.lblMinWasted.Location = New System.Drawing.Point(350, 34)
        Me.lblMinWasted.Name = "lblMinWasted"
        Me.lblMinWasted.Size = New System.Drawing.Size(143, 13)
        Me.lblMinWasted.TabIndex = 2
        Me.lblMinWasted.Text = "In Minutes that are 0 minutes"
        '
        'tmrmin
        '
        Me.tmrmin.Interval = 60000
        '
        'lblMillisWasted
        '
        Me.lblMillisWasted.AutoSize = True
        Me.lblMillisWasted.Location = New System.Drawing.Point(499, 34)
        Me.lblMillisWasted.Name = "lblMillisWasted"
        Me.lblMillisWasted.Size = New System.Drawing.Size(148, 13)
        Me.lblMillisWasted.TabIndex = 3
        Me.lblMillisWasted.Text = "In Milliseconds that are 0 millis"
        '
        'tmrmillis
        '
        Me.tmrmillis.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisableMenu, Me.ResetToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DisableMenu
        '
        Me.DisableMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisableMillisItem})
        Me.DisableMenu.Name = "DisableMenu"
        Me.DisableMenu.Size = New System.Drawing.Size(57, 20)
        Me.DisableMenu.Text = "Disable"
        '
        'DisableMillisItem
        '
        Me.DisableMillisItem.Name = "DisableMillisItem"
        Me.DisableMillisItem.Size = New System.Drawing.Size(140, 22)
        Me.DisableMillisItem.Text = "Milliseconds"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "That is:"
        '
        'lblFullTime
        '
        Me.lblFullTime.AutoSize = True
        Me.lblFullTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullTime.Location = New System.Drawing.Point(64, 71)
        Me.lblFullTime.Name = "lblFullTime"
        Me.lblFullTime.Size = New System.Drawing.Size(159, 39)
        Me.lblFullTime.TabIndex = 6
        Me.lblFullTime.Text = "00:00:00"
        '
        'tmrRealSeconds
        '
        Me.tmrRealSeconds.Interval = 1000
        '
        'lblCrazy
        '
        Me.lblCrazy.AutoSize = True
        Me.lblCrazy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrazy.Location = New System.Drawing.Point(10, 110)
        Me.lblCrazy.Name = "lblCrazy"
        Me.lblCrazy.Size = New System.Drawing.Size(759, 24)
        Me.lblCrazy.TabIndex = 7
        Me.lblCrazy.Text = "You're crazy! Over 1 day you are running this program/over 1 day you are on pc!"
        Me.lblCrazy.Visible = False
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCrazy)
        Me.Controls.Add(Me.lblFullTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblMillisWasted)
        Me.Controls.Add(Me.lblMinWasted)
        Me.Controls.Add(Me.lblSecWasted)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tmrsec As Timer
    Friend WithEvents lblSecWasted As Label
    Friend WithEvents lblMinWasted As Label
    Friend WithEvents tmrmin As Timer
    Friend WithEvents lblMillisWasted As Label
    Friend WithEvents tmrmillis As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DisableMenu As ToolStripMenuItem
    Friend WithEvents DisableMillisItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFullTime As Label
    Friend WithEvents tmrRealSeconds As Timer
    Friend WithEvents lblCrazy As Label
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
End Class
