Imports System.Data.Entity
Public Class Form1
    Private db As TireEntities
    Dim helper As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New TireEntities()
        db.customers.Load()
        CustomerBindingSource.DataSource = db.customers.Local
        DataGridView1.Enabled = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CustomerBindingSource.AddNew()
        DataGridView1.Enabled = False

        helper = 1
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        db.SaveChanges()
        MessageBox.Show("saved")
        helper = 0
        DataGridView1.Enabled = True
    End Sub

    Private Sub btnDetele_Click(sender As Object, e As EventArgs) Handles btnDetele.Click
        CustomerBindingSource.RemoveCurrent()
        MessageBox.Show("record deleted")
        helper = 0
        DataGridView1.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtId.Text = ""
        txtName.Text = ""
        If helper = 1 Then
            CustomerBindingSource.RemoveCurrent()
        End If
        DataGridView1.Enabled = True
    End Sub
End Class
