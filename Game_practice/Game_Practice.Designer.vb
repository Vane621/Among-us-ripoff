<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game_Practice
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_Practice))
        Me.Safe = New System.Windows.Forms.PictureBox()
        Me.SUS = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.mystery_box1wall = New System.Windows.Forms.PictureBox()
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pipe2wall = New System.Windows.Forms.PictureBox()
        Me.rwall = New System.Windows.Forms.PictureBox()
        Me.ewall = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WIN = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.endscreen = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.gay = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Safe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mystery_box1wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pipe2wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ewall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Safe
        '
        Me.Safe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Safe.Image = CType(resources.GetObject("Safe.Image"), System.Drawing.Image)
        Me.Safe.Location = New System.Drawing.Point(126, 476)
        Me.Safe.Name = "Safe"
        Me.Safe.Size = New System.Drawing.Size(49, 58)
        Me.Safe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Safe.TabIndex = 0
        Me.Safe.TabStop = False
        '
        'SUS
        '
        Me.SUS.Image = CType(resources.GetObject("SUS.Image"), System.Drawing.Image)
        Me.SUS.Location = New System.Drawing.Point(561, 330)
        Me.SUS.Name = "SUS"
        Me.SUS.Size = New System.Drawing.Size(46, 60)
        Me.SUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SUS.TabIndex = 7
        Me.SUS.TabStop = False
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'mystery_box1wall
        '
        Me.mystery_box1wall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mystery_box1wall.Location = New System.Drawing.Point(66, 191)
        Me.mystery_box1wall.Name = "mystery_box1wall"
        Me.mystery_box1wall.Size = New System.Drawing.Size(27, 288)
        Me.mystery_box1wall.TabIndex = 11
        Me.mystery_box1wall.TabStop = False
        Me.mystery_box1wall.Visible = False
        '
        'bullet
        '
        Me.bullet.Image = CType(resources.GetObject("bullet.Image"), System.Drawing.Image)
        Me.bullet.Location = New System.Drawing.Point(882, 12)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(61, 58)
        Me.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet.TabIndex = 12
        Me.bullet.TabStop = False
        Me.bullet.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Pipe2wall
        '
        Me.Pipe2wall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pipe2wall.Location = New System.Drawing.Point(80, 191)
        Me.Pipe2wall.Name = "Pipe2wall"
        Me.Pipe2wall.Size = New System.Drawing.Size(831, 61)
        Me.Pipe2wall.TabIndex = 9
        Me.Pipe2wall.TabStop = False
        Me.Pipe2wall.Visible = False
        '
        'rwall
        '
        Me.rwall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rwall.Location = New System.Drawing.Point(305, 432)
        Me.rwall.Name = "rwall"
        Me.rwall.Size = New System.Drawing.Size(411, 47)
        Me.rwall.TabIndex = 13
        Me.rwall.TabStop = False
        Me.rwall.Visible = False
        '
        'ewall
        '
        Me.ewall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ewall.Location = New System.Drawing.Point(908, 191)
        Me.ewall.Name = "ewall"
        Me.ewall.Size = New System.Drawing.Size(35, 270)
        Me.ewall.TabIndex = 14
        Me.ewall.TabStop = False
        Me.ewall.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(99, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'WIN
        '
        Me.WIN.Image = CType(resources.GetObject("WIN.Image"), System.Drawing.Image)
        Me.WIN.Location = New System.Drawing.Point(431, 302)
        Me.WIN.Name = "WIN"
        Me.WIN.Size = New System.Drawing.Size(100, 50)
        Me.WIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WIN.TabIndex = 17
        Me.WIN.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'endscreen
        '
        Me.endscreen.Image = CType(resources.GetObject("endscreen.Image"), System.Drawing.Image)
        Me.endscreen.Location = New System.Drawing.Point(-6, -7)
        Me.endscreen.Name = "endscreen"
        Me.endscreen.Size = New System.Drawing.Size(985, 564)
        Me.endscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.endscreen.TabIndex = 19
        Me.endscreen.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(99, 60)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(54, 37)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'gay
        '
        Me.gay.Image = CType(resources.GetObject("gay.Image"), System.Drawing.Image)
        Me.gay.Location = New System.Drawing.Point(190, 177)
        Me.gay.Name = "gay"
        Me.gay.Size = New System.Drawing.Size(235, 198)
        Me.gay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gay.TabIndex = 22
        Me.gay.TabStop = False
        Me.gay.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 150
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(170, 37)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'Timer4
        '
        Me.Timer4.Interval = 150
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'Timer6
        '
        Me.Timer6.Interval = 1
        '
        'Game_Practice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 546)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.gay)
        Me.Controls.Add(Me.SUS)
        Me.Controls.Add(Me.Safe)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.WIN)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ewall)
        Me.Controls.Add(Me.rwall)
        Me.Controls.Add(Me.bullet)
        Me.Controls.Add(Me.mystery_box1wall)
        Me.Controls.Add(Me.Pipe2wall)
        Me.Controls.Add(Me.endscreen)
        Me.DoubleBuffered = True
        Me.Name = "Game_Practice"
        Me.Text = "Among Us"
        CType(Me.Safe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mystery_box1wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pipe2wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ewall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endscreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Safe As PictureBox
    Friend WithEvents SUS As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents mystery_box1wall As PictureBox
    Friend WithEvents bullet As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pipe2wall As PictureBox
    Friend WithEvents rwall As PictureBox
    Friend WithEvents ewall As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents WIN As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents endscreen As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents gay As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
End Class
