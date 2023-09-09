<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginGroupBox = New System.Windows.Forms.GroupBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Lblpassword = New System.Windows.Forms.Label()
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblTimeandDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LoginGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginGroupBox
        '
        Me.LoginGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.LoginGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginGroupBox.Controls.Add(Me.BtnExit)
        Me.LoginGroupBox.Controls.Add(Me.Txtpassword)
        Me.LoginGroupBox.Controls.Add(Me.Txtusername)
        Me.LoginGroupBox.Controls.Add(Me.Lblpassword)
        Me.LoginGroupBox.Controls.Add(Me.Lblusername)
        Me.LoginGroupBox.Controls.Add(Me.Btnlogin)
        Me.LoginGroupBox.Location = New System.Drawing.Point(181, 82)
        Me.LoginGroupBox.Name = "LoginGroupBox"
        Me.LoginGroupBox.Size = New System.Drawing.Size(371, 236)
        Me.LoginGroupBox.TabIndex = 1
        Me.LoginGroupBox.TabStop = False
        Me.LoginGroupBox.Text = "  "
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(214, 130)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(98, 64)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Txtpassword
        '
        Me.Txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtpassword.Location = New System.Drawing.Point(102, 58)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.Size = New System.Drawing.Size(136, 20)
        Me.Txtpassword.TabIndex = 4
        '
        'Txtusername
        '
        Me.Txtusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtusername.Location = New System.Drawing.Point(102, 26)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(136, 20)
        Me.Txtusername.TabIndex = 3
        '
        'Lblpassword
        '
        Me.Lblpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.Location = New System.Drawing.Point(27, 61)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(56, 13)
        Me.Lblpassword.TabIndex = 2
        Me.Lblpassword.Text = "Password:"
        Me.Lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblusername
        '
        Me.Lblusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblusername.AutoSize = True
        Me.Lblusername.Location = New System.Drawing.Point(27, 29)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(58, 13)
        Me.Lblusername.TabIndex = 1
        Me.Lblusername.Text = "Username:"
        Me.Lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnlogin
        '
        Me.Btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnlogin.FlatAppearance.BorderSize = 0
        Me.Btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnlogin.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.Location = New System.Drawing.Point(30, 130)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(98, 64)
        Me.Btnlogin.TabIndex = 0
        Me.Btnlogin.Text = "LOGIN"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'LblName
        '
        Me.LblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(57, 58)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(651, 21)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "MWIKI PRIMARY SCHOOL INVENTORY MANAGEMENT SYSTEM "
        '
        'LblTimeandDate
        '
        Me.LblTimeandDate.AllowDrop = True
        Me.LblTimeandDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTimeandDate.AutoSize = True
        Me.LblTimeandDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTimeandDate.Location = New System.Drawing.Point(12, 361)
        Me.LblTimeandDate.Name = "LblTimeandDate"
        Me.LblTimeandDate.Size = New System.Drawing.Size(77, 13)
        Me.LblTimeandDate.TabIndex = 4
        Me.LblTimeandDate.Text = "Time and Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(733, 401)
        Me.Controls.Add(Me.LblTimeandDate)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LoginGroupBox)
        Me.DoubleBuffered = True
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LoginGroupBox.ResumeLayout(False)
        Me.LoginGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Lblpassword As System.Windows.Forms.Label
    Friend WithEvents Lblusername As System.Windows.Forms.Label
    Friend WithEvents Btnlogin As System.Windows.Forms.Button
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblTimeandDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
