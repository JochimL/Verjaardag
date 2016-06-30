Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim paper As Graphics
        Dim foto As New Bitmap("Koereurchinees.jpg")

        paper = PictureBox1.CreateGraphics()
        Dim myPen As Pen = New Pen(Color.Black)
        paper.DrawImage(foto, 0, 0, 260, 209)

    End Sub
End Class
