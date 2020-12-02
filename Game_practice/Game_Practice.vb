Public Class Game_Practice
    Private Sub Game_Practice_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                MoveTo(Safe, 0, -15)
            Case Keys.A
                MoveTo(Safe, -15, 0)
            Case Keys.S
                MoveTo(Safe, 0, 15)
            Case Keys.D
                MoveTo(Safe, 15, 0)
            Case Keys.Up
                MoveTo(SUS, 0, -15)
            Case Keys.Left
                MoveTo(SUS, -15, 0)
            Case Keys.Down
                MoveTo(SUS, 0, 15)
            Case Keys.Right
                MoveTo(SUS, 15, 0)
            Case Keys.Space
                bullet.Location = Safe.Location
                Timer1.Enabled = True
                bullet.Visible = True
                Safe.Image = PictureBox1.Image
                SUS.Image = PictureBox2.Image
                endscreen.Image = PictureBox5.Image
                WIN.Visible = False
                SUS.Location = Safe.Location
                WIN.Location = PictureBox4.Location
            Case Keys.F
                gay.Visible = True
                Timer6.Enabled = True
        End Select
        Me.Refresh()
    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(Safe.Location)
        headstart = headstart + 1D
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > Safe.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < Safe.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub
    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.EndsWith(t) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        If p.Name = "Safe" And Collision(p, "WIN") Then
            Me.endscreen.Image = PictureBox3.Image
            Timer2.Enabled = True
            WIN.Visible = False

            Return
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SUS.Image = PictureBox4.Image
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SUS.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Me.Refresh()

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Safe.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Me.Refresh()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        endscreen.Image = PictureBox5.Image
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        gay.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Me.Refresh()
    End Sub
End Class