Imports MySql.Data.MySqlClient

Public Class frmUserMgmt

    Private Sub frmUserMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserPrompt.Visible = True
        lblUserPrompt.Dock = DockStyle.Fill

        refreshEmpList()
    End Sub

    Public Sub refreshEmpList()
        dgvCurrentUserList.Rows.Clear()

        Try
            Dim dbConnection As MySqlConnection = New MySqlConnection("Server=localhost;Database=techcare;Uid=techcare;Pwd=techcare;")
            Dim dbCommand As MySqlCommand = New MySqlCommand("SELECT employeeID, title, forename, surname, userAccessLevel, username FROM Employees;", dbConnection)

            dbConnection.Open()

            Dim dbReader As MySqlDataReader = dbCommand.ExecuteReader

            If dbReader.HasRows Then
                While dbReader.Read
                    dgvCurrentUserList.Rows.Add(New String() {dbReader(0).ToString, dbReader(5).ToString, dbReader(1).ToString & " " & dbReader(2).ToString &
                                                " " & dbReader(3).ToString, dbReader(4).ToString})
                End While
            End If

            dbConnection.Close()
            dbCommand.Dispose()
            dbConnection.Dispose()
        Catch ex As Exception
            MsgBox("Se produjo un error al buscar empleados en la base de datos de techcare." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical, "techcare")
        End Try
    End Sub

    Private Sub dgvCurrentUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCurrentUserList.CellClick
        lblEmpName.Text = dgvCurrentUserList.SelectedRows(0).Cells(2).Value.ToString
        lblEmpID.Text = dgvCurrentUserList.SelectedRows(0).Cells(0).Value.ToString
        lblUserAccessLvl.Text = dgvCurrentUserList.SelectedRows(0).Cells(3).Value.ToString
        lblUserPrompt.Visible = False
    End Sub

    Private Sub btnEditEmployeeDetails_Click(sender As Object, e As EventArgs) Handles btnEditEmployeeDetails.Click

        frmEditEmpDetails.tbTitle.Text = functions.obtainEmployeeDetails(lblEmpID.Text, 1)
        frmEditEmpDetails.tbForename.Text = functions.obtainEmployeeDetails(lblEmpID.Text, 2)
        frmEditEmpDetails.tbSurname.Text = functions.obtainEmployeeDetails(lblEmpID.Text, 3)

        If functions.obtainEmployeeDetails(lblEmpID.Text, 4) = "Basic" Then
            frmEditEmpDetails.rbBasicAccess.Checked = True
        Else
            frmEditEmpDetails.rbFullAccess.Checked = True
        End If

        frmEditEmpDetails.Text = "Editing Details for Employee: " & lblEmpID.Text
        frmEditEmpDetails.empID = lblEmpID.Text

        frmEditEmpDetails.ShowDialog()
    End Sub

    Private Sub btnResetEmpPwd_Click(sender As Object, e As EventArgs) Handles btnResetEmpPwd.Click
        frmResetPassword.empID = lblEmpID.Text
        frmResetPassword.ShowDialog()
    End Sub

    Private Sub btnDeleteEmp_Click(sender As Object, e As EventArgs) Handles btnDeleteEmp.Click

        If lblEmpID.Text = frmMainWindow.lblEmpID.Text Then
            MsgBox("No se puede eliminar un usuario que actualmente ha iniciado sesión. Por favor, cierre sesión en esta cuenta e inténtelo de nuevo.", MsgBoxStyle.Critical, "techcare")
        Else
            Dim msg As DialogResult = MessageBox.Show("Está a punto de eliminar a un empleado del sistema." & vbNewLine & " Esta accion es irreversible." &
                                                      vbNewLine & vbNewLine & "¿Quieres continuar?", "techcare", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If msg = DialogResult.Yes Then
                Try
                    Dim dbConnection As MySqlConnection = New MySqlConnection("Server=localhost;Database=techcare;Uid=techcare;Pwd=techcare;")
                    Dim dbCommand As MySqlCommand = New MySqlCommand("DELETE FROM Employees WHERE employeeID=@empID", dbConnection)

                    dbConnection.Open()

                    dbCommand.Parameters.AddWithValue("@empID", lblEmpID.Text)

                    dbCommand.ExecuteNonQuery()

                    dbConnection.Close()
                    dbCommand.Dispose()
                    dbConnection.Dispose()

                    MsgBox("Usuario eliminado exitosamente.", MsgBoxStyle.Information, "techcare")
                    refreshEmpList()
                    lblUserPrompt.Visible = True
                    lblUserPrompt.Dock = DockStyle.Fill
                Catch ex As Exception
                    MsgBox("Se ha producido una excepción al eliminar este usuario." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical, "techcare")
                End Try
            End If
        End If
    End Sub

    Private Sub btnCreateNewEmp_Click(sender As Object, e As EventArgs) Handles btnCreateNewEmp.Click
        frmCreateUser.ShowDialog()
    End Sub
End Class