Public Class Form1
    Dim score As Integer = 0 'This will used to record score
    Dim Speed As Integer  'Creating an Integer as name as speed
    Dim Road(5) As PictureBox 'Creating an array for Roadmovemt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Speed = 3
        'using an array to set the pictureboxes
        Road(0) = PictureBox1
        Road(1) = PictureBox2
        Road(2) = PictureBox3
        Road(3) = PictureBox4
        Road(4) = PictureBox5
        Road(5) = PictureBox6
    End Sub
    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        'Using for loop to move the road 
        For x As Integer = 0 To 5
            Road(x).Top += 2
            'using If statement to create loop as infinite and road moves continous
            If Road(x).Top >= Me.Height Then
                Road(x).Top = -Road(x).Height
            End If
        Next
        If score > 20 And score < 30 Then
            Speed = 10
        End If
        If score > 30 And score < 40 Then
            Speed = 11
        End If
        If score > 40 And score < 50 Then
            Speed = 12
        End If
        'This if statement is used to exit game due to collision of cars
        If (Car.Bounds.IntersectsWith(Enemy_Car1.Bounds)) Then
            gameover()
        End If
        If (Car.Bounds.IntersectsWith(Enemy_Car2.Bounds)) Then
            gameover()
        End If
        If (Car.Bounds.IntersectsWith(Enemy_Car3.Bounds)) Then
            gameover()
        End If
    End Sub
    Private Sub gameover()
        Score_Text.Visible = True
        Replay_Button.Visible = True
        End_Text.Visible = True
        RoadMover.Stop()
        Left_Mover.Stop()
        Right_Mover.Stop()
        Enemy1_Mover.Stop()
        Enemy2_Mover.Stop()
        Enemy3_Mover.Stop()

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Both the If statements are used to move the car as left and right by 5
        If e.KeyCode = Keys.Right Then
            Car.Left += 5
        End If

        If e.KeyCode = Keys.Left Then
            Car.Left -= 5
        End If
    End Sub

    Private Sub Right_Mover_Tick(sender As Object, e As EventArgs) Handles Right_Mover.Tick
        'This will used to set Maximum location of an car so it will not move outside the form
        If (Car.Location.X < 186) Then
            Car.Left += 5
        End If
    End Sub

    Private Sub Left_Mover_Tick(sender As Object, e As EventArgs) Handles Left_Mover.Tick
        'This will used to set Maximum location of an car so it will not move outside the form

        If (Car.Location.X < 0) Then
            Car.Left -= 5
        End If
    End Sub

    Private Sub Enemy1_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1_Mover.Tick
        'Setting up the timmer to the picture box 1 so that Enemy Car 1 is move
        Enemy_Car1.Top += 2
        'Using If Statement so the Cars are move again and again 
        If Enemy_Car1.Top >= Me.Height Then
            score += Speed * 2 'Score should be increase according to speed variable
            Score_Text.Text = "Score " & score 'score should be displayed by veriable
            Enemy_Car1.Top = -Enemy_Car1.Height
        End If
    End Sub

    Private Sub Enemy2_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2_Mover.Tick
        'Setting up the timmer to the picture box 2 so that Enemy Car 2 is move
        Enemy_Car2.Top += 1.8
        'Using If Statement so the Cars are move again and again 
        If Enemy_Car2.Top >= Me.Height Then
            score += Speed 'Score should be increase according to speed variable
            Score_Text.Text = "Score " & score 'score should be displayed by veriable
            Enemy_Car2.Top = -Enemy_Car2.Height
        End If
    End Sub

    Private Sub Enemy3_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3_Mover.Tick
        'Setting up the timmer to the picture box 3 so that Enemy Car 3 is move
        Enemy_Car3.Top += 1.4
        'Using If Statement so the Cars are move again and again 
        If Enemy_Car3.Top >= Me.Height Then
            score += Speed * 1.5  'Score should be increase according to speed variable
            Score_Text.Text = "Score " & score  'score should be displayed by veriable
            Enemy_Car3.Top = -Enemy_Car3.Height
        End If
    End Sub

    Private Sub Score_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Replay_Button_Click(sender As Object, e As EventArgs) Handles Replay_Button.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
