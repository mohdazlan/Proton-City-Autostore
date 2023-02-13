Public Class frmConfig
    Private Sub pbInvoice_MouseHover(sender As Object, e As EventArgs) Handles pbInvoice.MouseHover
        pbInvoice.Image = Proton_Auto_Store.My.Resources.invoice2
    End Sub

    Private Sub pbInvoice_Click(sender As Object, e As EventArgs) Handles pbInvoice.Click
        MsgBox("hello World")
    End Sub
End Class