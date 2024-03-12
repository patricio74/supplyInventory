﻿Imports MySql.Data.MySqlClient
Public Class supplyInventory
    Dim conString As String = "server=localhost; database= vgc; uid=root; password=;"
    Dim conn As New MySqlConnection(conString)

    Private Sub clearForm()
        populateList()
        tbxSearch.Clear()
        tbxArticle.Clear()
        tbxDescr.Clear()
        tbxQtyPropCard.Clear()
        tbxPropNum.Clear()
        tbxNewPropNum.Clear()
        tbxQtyPhysCount.Clear()
        tbxUnitValue.Clear()
        tbxLocation.Clear()
        cbxUM.SelectedIndex = 0
        cbxCondition.SelectedIndex = 0
        dtpPurchase.ResetText()
        tbxRemarks.Clear()
        'listViewInventory.SelectedItems.Clear()
    End Sub
    Private Sub populateList()
        Dim query As String = "SELECT id, article, description, um, unitValue, dateOfPurchase, location, cond, remarks FROM inventory"
        Using connection As New MySqlConnection(conString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        listViewInventory.Items.Clear()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("id").ToString())
                            item.SubItems.Add(reader("article").ToString())
                            item.SubItems.Add(reader("description").ToString())
                            item.SubItems.Add(reader("um").ToString())
                            item.SubItems.Add(reader("unitValue").ToString())
                            item.SubItems.Add(reader("dateOfPurchase").ToString())
                            item.SubItems.Add(reader("location").ToString())
                            item.SubItems.Add(reader("cond").ToString())
                            item.SubItems.Add(reader("remarks").ToString())
                            listViewInventory.Items.Add(item)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged
        If tbxSearch.Text.Trim() = "" Then
            populateList()
        Else
            searchInventory(tbxSearch.Text.Trim())
        End If
    End Sub

    Private Sub searchInventory(ByVal searchText As String)
        Dim query As String = "SELECT * FROM inventory WHERE article LIKE @searchText OR description LIKE @searchText"
        Try
            Using connection As New MySqlConnection(conString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@searchText", "%" & searchText & "%") ' Use wildcards for partial matches
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        listViewInventory.Items.Clear()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("id").ToString())
                            item.SubItems.Add(reader("article").ToString())
                            item.SubItems.Add(reader("description").ToString())
                            item.SubItems.Add(reader("um").ToString())
                            item.SubItems.Add(reader("unitValue").ToString())
                            item.SubItems.Add(reader("dateOfPurchase").ToString())
                            item.SubItems.Add(reader("location").ToString())
                            item.SubItems.Add(reader("cond").ToString())
                            item.SubItems.Add(reader("remarks").ToString())
                            listViewInventory.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
            tbxArticle.Clear()
            tbxDescr.Clear()
            tbxUnitValue.Clear()
            tbxLocation.Clear()
            tbxRemarks.Clear()
            tbxPropNum.Clear()
            tbxNewPropNum.Clear()
            tbxQtyPropCard.Clear()
            tbxQtyPhysCount.Clear()
            cbxUM.SelectedIndex = 0
            cbxCondition.SelectedIndex = 0
            dtpPurchase.ResetText()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub listViewInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewInventory.SelectedIndexChanged
        If listViewInventory.SelectedItems.Count > 0 Then
            Dim selectedRow As ListViewItem = listViewInventory.SelectedItems(0)
            Dim idValue As String = selectedRow.SubItems(0).Text
            populateTbx(idValue)
        End If
    End Sub
    Private Sub populateTbx(ByVal idValue As String)
        Dim query As String = "SELECT * FROM inventory WHERE id = @id"
        Try
            Using connection As New MySqlConnection(conString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", idValue)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            tbxArticle.Text = reader("article").ToString()
                            tbxDescr.Text = reader("description").ToString()
                            cbxUM.Text = reader("um").ToString()
                            tbxUnitValue.Text = reader("unitValue").ToString()
                            dtpPurchase.Value = Convert.ToDateTime(reader("dateOfPurchase"))
                            tbxLocation.Text = reader("location").ToString()
                            cbxCondition.Text = reader("cond").ToString()
                            tbxRemarks.Text = reader("remarks").ToString()
                            tbxPropNum.Text = reader("propNum").ToString()
                            tbxNewPropNum.Text = reader("newPropNum").ToString()
                            tbxQtyPropCard.Text = reader("qtyPropCard").ToString()
                            tbxQtyPhysCount.Text = reader("qtyPhysCount").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(tbxArticle.Text) OrElse
               String.IsNullOrWhiteSpace(tbxDescr.Text) OrElse
               String.IsNullOrWhiteSpace(tbxUnitValue.Text) OrElse
               String.IsNullOrWhiteSpace(tbxLocation.Text) OrElse
               String.IsNullOrWhiteSpace(tbxRemarks.Text) OrElse
               String.IsNullOrWhiteSpace(tbxPropNum.Text) OrElse
               String.IsNullOrWhiteSpace(tbxNewPropNum.Text) OrElse
               String.IsNullOrWhiteSpace(tbxQtyPropCard.Text) OrElse
               String.IsNullOrWhiteSpace(tbxQtyPhysCount.Text) OrElse
               cbxUM.SelectedIndex = -1 OrElse
               cbxCondition.SelectedIndex = -1 OrElse
               cbxUM.SelectedIndex = 0 OrElse
               cbxCondition.SelectedIndex = 0 OrElse
               dtpPurchase.Value = DateTime.MinValue Then
            MessageBox.Show("Fill out all fields to continue")
            clearForm()
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim query As String = "INSERT INTO inventory (article, description, um, unitValue, dateOfPurchase, location, cond, remarks, propNum, newPropNum, qtyPropCard, qtyPhysCount) VALUES (@article, @description, @um, @unitValue, @dateOfPurchase, @location, @condit, @remarks, @propNum, @newPropNum, @qtyPropCard, @qtyPhysCount)"
                Try
                    Dim description As String = tbxDescr.Text.Replace(vbCrLf, " ").Replace(vbTab, " ") 'para single line lang
                    Using connection As New MySqlConnection(conString)
                        Using command As New MySqlCommand(query, connection)
                            ' Add parameters
                            command.Parameters.AddWithValue("@article", tbxArticle.Text)
                            command.Parameters.AddWithValue("@description", tbxDescr.Text)
                            command.Parameters.AddWithValue("@um", cbxUM.Text)
                            command.Parameters.AddWithValue("@unitValue", tbxUnitValue.Text)
                            command.Parameters.AddWithValue("@dateOfPurchase", dtpPurchase.Text)
                            command.Parameters.AddWithValue("@location", tbxLocation.Text)
                            command.Parameters.AddWithValue("@condit", cbxCondition.Text)
                            command.Parameters.AddWithValue("@remarks", tbxRemarks.Text)
                            command.Parameters.AddWithValue("@propNum", tbxPropNum.Text)
                            command.Parameters.AddWithValue("@newPropNum", tbxNewPropNum.Text)
                            command.Parameters.AddWithValue("@qtyPropCard", tbxQtyPropCard.Text)
                            command.Parameters.AddWithValue("@qtyPhysCount", tbxQtyPhysCount.Text)
                            connection.Open()
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Item added successfully!")
                                clearForm()
                            Else
                                MessageBox.Show("Failed to add item!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearForm()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If listViewInventory.SelectedItems.Count > 0 Then
            Dim selectedRow As ListViewItem = listViewInventory.SelectedItems(0)
            Dim idValue As String = selectedRow.SubItems(0).Text ' Get the ID of the selected row
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Get values from textboxes
                Dim article As String = tbxArticle.Text
                Dim description As String = tbxDescr.Text
                Dim um As String = cbxUM.Text
                Dim unitValue As String = tbxUnitValue.Text
                Dim dateOfPurchase As String = dtpPurchase.Text
                Dim location As String = tbxLocation.Text
                Dim condit As String = cbxCondition.Text
                Dim remarks As String = tbxRemarks.Text
                Dim prop As String = tbxPropNum.Text
                Dim newProp As String = tbxNewPropNum.Text
                Dim propCard As String = tbxQtyPropCard.Text
                Dim physCount As String = tbxQtyPhysCount.Text
                Dim query As String = "UPDATE inventory SET article = @article, description = @description, um = @um, unitValue = @unitValue, dateOfPurchase = @dateOfPurchase, location = @location, cond = @condit, remarks = @remarks, propNum=@prop, newPropNum = @newProp, qtyPropCard = @propCard, qtyPhysCount = @physCount WHERE id = @id"
                Try
                    Using connection As New MySqlConnection(conString)
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@article", article)
                            command.Parameters.AddWithValue("@description", description)
                            command.Parameters.AddWithValue("@um", um)
                            command.Parameters.AddWithValue("@unitValue", unitValue)
                            command.Parameters.AddWithValue("@dateOfPurchase", dateOfPurchase)
                            command.Parameters.AddWithValue("@location", location)
                            command.Parameters.AddWithValue("@condit", condit)
                            command.Parameters.AddWithValue("@remarks", remarks)
                            command.Parameters.AddWithValue("@prop", prop)
                            command.Parameters.AddWithValue("@newProp", newProp)
                            command.Parameters.AddWithValue("@propCard", propCard)
                            command.Parameters.AddWithValue("@physCount", physCount)
                            command.Parameters.AddWithValue("@id", idValue) ' Use the ID of the selected row
                            connection.Open()
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Item updated successfully!")
                                clearForm()
                            Else
                                MessageBox.Show("Item update failed!.")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                clearForm()
            End If
        Else
            MessageBox.Show("Select item to continue")
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If listViewInventory.SelectedItems.Count > 0 Then
            Dim selectedRow As ListViewItem = listViewInventory.SelectedItems(0)
            Dim idValue As String = selectedRow.SubItems(0).Text
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM inventory WHERE id = @id"
                Try
                    Using connection As New MySqlConnection(conString)
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@id", idValue)
                            connection.Open()
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Item deleted successfully!")
                                clearForm()
                            Else
                                MessageBox.Show("No item deleted.")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                clearForm()
            End If
        Else
            MessageBox.Show("No item selected.")
        End If
    End Sub
    Private Sub supplyInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conn = New MySqlConnection(conString)
        Try
            populateList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        clearForm()
    End Sub
    Private Sub supplyInventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class