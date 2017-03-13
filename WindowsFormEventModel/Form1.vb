Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Welcome to my project")
    End Sub

    Private Sub Label1_Mousehover() Handles Label1.MouseHover
        PictureBox1.Image = WindowsFormEventModel.My.Resources.Resources.basketball_157925_960_720
    End Sub
    Private Sub Label2_Mousehover() Handles Label2.MouseHover
        PictureBox1.Image = WindowsFormEventModel.My.Resources.Resources.download
    End Sub
    Private Sub Label3_Mousehover() Handles Label3.MouseHover
        PictureBox1.Image = WindowsFormEventModel.My.Resources.Resources.welcome_door_mat_full
    End Sub
End Class
