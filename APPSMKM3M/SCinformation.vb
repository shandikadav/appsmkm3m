Public Class SCinformation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Teknik Komputer Jaringan" Then
            FormInfo_TKJ.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "Teknik Kendaraan Ringan" Then
            FormInfo_TKR.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "Farmasi" Then
            Farmasi.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "Teknik Audio Video" Then
            FormInfo_TAV.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "Teknik Laboratorium" Then
            FormInfo_TLM.Show()
            Me.Hide()
        End If
    End Sub
End Class