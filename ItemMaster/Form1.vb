﻿Public Class Form1
    Private Sub TabFormControl1_OuterFormCreating(sender As Object, e As DevExpress.XtraBars.OuterFormCreatingEventArgs) Handles TabFormControl1.OuterFormCreating
        Dim form As New Form1
        form.TabFormControl.Pages.Clear()
        e.Form = form
    End Sub
End Class
