Imports System.Media
Public Class frmImagenes

    Dim sonido As New SoundPlayer

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCapitanAmerica.CheckedChanged
        pctImagen.Image = My.Resources.CapitanAmerica
        sonido.Stop()
    End Sub

    Private Sub rdbMujerMaravilla_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMujerMaravilla.CheckedChanged
        pctImagen.Image = My.Resources.MujerMaravilla
        sonido.Stop()
    End Sub

    Private Sub rdbLinternaVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLinternaVerde.CheckedChanged
        pctImagen.Image = My.Resources.LinternaVerde
        sonido.Stop()
    End Sub

    Private Sub rdbMujerInvisible_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMujerInvisible.CheckedChanged
        pctImagen.Image = My.Resources.MujerInvisible
        sonido.Stop()
    End Sub

    Private Sub frmImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sonido.SoundLocation = "BlindingLights.Wav"
        sonido.Play()
    End Sub
End Class
