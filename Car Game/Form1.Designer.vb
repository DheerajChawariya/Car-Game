<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.Left_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Right_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.Enemy_Car1 = New System.Windows.Forms.PictureBox()
        Me.Enemy_Car2 = New System.Windows.Forms.PictureBox()
        Me.Enemy_Car3 = New System.Windows.Forms.PictureBox()
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.Score_Text = New System.Windows.Forms.Label()
        Me.Replay_Button = New System.Windows.Forms.Button()
        Me.Speed_Text = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy_Car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy_Car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy_Car3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.Location = New System.Drawing.Point(43, -43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(12, 110)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.Location = New System.Drawing.Point(158, -43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(12, 110)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox3.Location = New System.Drawing.Point(158, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 110)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox4.Location = New System.Drawing.Point(43, 105)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 110)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox5.Location = New System.Drawing.Point(43, 257)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(12, 110)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox6.Location = New System.Drawing.Point(158, 257)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(12, 110)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'Left_Mover
        '
        Me.Left_Mover.Interval = 10
        '
        'Right_Mover
        '
        Me.Right_Mover.Interval = 10
        '
        'Car
        '
        Me.Car.BackgroundImage = CType(resources.GetObject("Car.BackgroundImage"), System.Drawing.Image)
        Me.Car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Car.Location = New System.Drawing.Point(81, 271)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(49, 80)
        Me.Car.TabIndex = 1
        Me.Car.TabStop = False
        '
        'Enemy_Car1
        '
        Me.Enemy_Car1.BackgroundImage = CType(resources.GetObject("Enemy_Car1.BackgroundImage"), System.Drawing.Image)
        Me.Enemy_Car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy_Car1.Location = New System.Drawing.Point(97, -13)
        Me.Enemy_Car1.Name = "Enemy_Car1"
        Me.Enemy_Car1.Size = New System.Drawing.Size(33, 80)
        Me.Enemy_Car1.TabIndex = 1
        Me.Enemy_Car1.TabStop = False
        '
        'Enemy_Car2
        '
        Me.Enemy_Car2.BackgroundImage = CType(resources.GetObject("Enemy_Car2.BackgroundImage"), System.Drawing.Image)
        Me.Enemy_Car2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy_Car2.Location = New System.Drawing.Point(-6, 147)
        Me.Enemy_Car2.Name = "Enemy_Car2"
        Me.Enemy_Car2.Size = New System.Drawing.Size(43, 89)
        Me.Enemy_Car2.TabIndex = 1
        Me.Enemy_Car2.TabStop = False
        '
        'Enemy_Car3
        '
        Me.Enemy_Car3.BackgroundImage = CType(resources.GetObject("Enemy_Car3.BackgroundImage"), System.Drawing.Image)
        Me.Enemy_Car3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy_Car3.Location = New System.Drawing.Point(176, 147)
        Me.Enemy_Car3.Name = "Enemy_Car3"
        Me.Enemy_Car3.Size = New System.Drawing.Size(40, 89)
        Me.Enemy_Car3.TabIndex = 1
        Me.Enemy_Car3.TabStop = False
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Enabled = True
        Me.Enemy1_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Enabled = True
        Me.Enemy2_Mover.Interval = 10
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Enabled = True
        Me.Enemy3_Mover.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.End_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Text.ForeColor = System.Drawing.Color.Red
        Me.End_Text.Location = New System.Drawing.Point(22, 86)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(164, 36)
        Me.End_Text.TabIndex = 2
        Me.End_Text.Text = "Game Over"
        Me.End_Text.Visible = False
        '
        'Score_Text
        '
        Me.Score_Text.AutoSize = True
        Me.Score_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Text.Location = New System.Drawing.Point(-1, -1)
        Me.Score_Text.Name = "Score_Text"
        Me.Score_Text.Size = New System.Drawing.Size(79, 22)
        Me.Score_Text.TabIndex = 3
        Me.Score_Text.Text = "Score 0"
        Me.Score_Text.Visible = False
        '
        'Replay_Button
        '
        Me.Replay_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Replay_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Replay_Button.Location = New System.Drawing.Point(61, 161)
        Me.Replay_Button.Name = "Replay_Button"
        Me.Replay_Button.Size = New System.Drawing.Size(96, 54)
        Me.Replay_Button.TabIndex = 4
        Me.Replay_Button.Text = "Replay"
        Me.Replay_Button.UseVisualStyleBackColor = False
        Me.Replay_Button.Visible = False
        '
        'Speed_Text
        '
        Me.Speed_Text.AutoSize = True
        Me.Speed_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed_Text.Location = New System.Drawing.Point(137, -1)
        Me.Speed_Text.Name = "Speed_Text"
        Me.Speed_Text.Size = New System.Drawing.Size(84, 22)
        Me.Speed_Text.TabIndex = 3
        Me.Speed_Text.Text = "Speed 0"
        Me.Speed_Text.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(222, 353)
        Me.Controls.Add(Me.Replay_Button)
        Me.Controls.Add(Me.Speed_Text)
        Me.Controls.Add(Me.Score_Text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.Enemy_Car3)
        Me.Controls.Add(Me.Enemy_Car2)
        Me.Controls.Add(Me.Enemy_Car1)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy_Car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy_Car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy_Car3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents Left_Mover As Timer
    Friend WithEvents Right_Mover As Timer
    Friend WithEvents Car As PictureBox
    Friend WithEvents Enemy_Car1 As PictureBox
    Friend WithEvents Enemy_Car2 As PictureBox
    Friend WithEvents Enemy_Car3 As PictureBox
    Friend WithEvents Enemy1_Mover As Timer
    Friend WithEvents Enemy2_Mover As Timer
    Friend WithEvents Enemy3_Mover As Timer
    Friend WithEvents End_Text As Label
    Friend WithEvents Score_Text As Label
    Friend WithEvents Replay_Button As Button
    Friend WithEvents Speed_Text As Label
End Class
