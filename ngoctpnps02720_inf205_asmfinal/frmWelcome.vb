Public Class frmWelcome

    Private Sub tmrWelcome_Tick(sender As Object, e As EventArgs) Handles tmrWelcome.Tick
        pgbWelcome.Increment(1)
        If pgbWelcome.Value = pgbWelcome.Maximum Then
            Me.Close()
        End If
    End Sub 'tmrWelcome_Tick
End Class 'frmWelcome