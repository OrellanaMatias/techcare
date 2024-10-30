Imports MySql.Data.MySqlClient
Public Class frmResetPassword

    Public empID As Integer

    Private Sub btnConfirmChanges_Click(sender As Object, e As EventArgs) Handles btnConfirmChanges.Click
        If functions.validateNewPassword(tbNewPassword.Text) = True And tbNewPassword.Text = tbConfirmNewPassword.Text Then
            Try
                Dim dbConnection As MySqlConnection = New MySqlConnection("Server=localhost;Database=techcare;Uid=techcare;Pwd=techcare;")
                Dim dbCommand As MySqlCommand = New MySqlCommand("UPDATE Employees SET password=@pwd WHERE employeeID=@empID;", dbConnection)

                dbCommand.Parameters.AddWithValue("@pwd", tbNewPassword.Text)
                dbCommand.Parameters.AddWithValue("@empID", empID)

                dbConnection.Open()

                dbCommand.ExecuteNonQuery()

                dbConnection.Close()
                dbCommand.Dispose()
                dbConnection.Dispose()

                MsgBox("Contraseña actualizada exitosamente. Los cambios haran efecto a partir del próximo inicio de sesión.", MsgBoxStyle.Information, "techcare")

                frmUserMgmt.refreshEmpList()
                Me.Close()
            Catch ex As Exception
                MsgBox("Se ha producido un error al actualizar la contraseña del usuario." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical, "techcare")
                frmUserMgmt.refreshEmpList()
                Me.Close()
            End Try
        Else
            MsgBox("¡No se puede escribir una nueva contraseña en la base de datos!" & vbNewLine & vbNewLine & "Asegúrese de que su contraseña coincida y tenga al menos 8 caracteres." &
                   "1 carácter mayúscula, 1 número y 1 carácter especial.", MsgBoxStyle.Exclamation, "techcare")
        End If
    End Sub
End Class