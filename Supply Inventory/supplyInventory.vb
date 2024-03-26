Imports MySql.Data.MySqlClient
Public Class supplyInventory
    Dim conString As String = "server=localhost; database= vgcInventory; uid=root; password=;"
    Dim conn As New MySqlConnection(conString)
    Private Sub clearAddTab()
        populateList()
        tbxSearch.Clear()
        tbxArticle.Clear()
        tbxDescr.Clear()
        tbxQtyPropCard.Clear()
        tbxPropNum.Clear()
        tbxNewPropNum.Clear()
        tbxQtyPhysCount.Clear()
        tbxUnitValue.Clear()
        tbxLocationActual.Clear()
        tbxLocationReport.Clear()
        tbxUM.Clear()
        tbxCondition.Clear()
        dtpPurchase.ResetText()
        tbxResponsibility.Clear()
        tbxPPE1.Clear()
        tbxPPE2.Clear()
        tbxPPE3.Clear()
        tbxArticle.Focus()
    End Sub
    Private Sub clearUpdTab()
        populateList()
        tbxSearch.Clear()
        updArticle.Clear()
        updDescription.Clear()
        updQtyPropCard.Clear()
        updPropNum.Clear()
        updNewPropNum.Clear()
        updQtyPhysCount.Clear()
        updUnitValue.Clear()
        updLocActual.Clear()
        updLocRep.Clear()
        'cbxUM.SelectedIndex = 0
        'cbxCondition.SelectedIndex = 0
        updUM.Clear()
        updCondition.Clear()
        dtpPurchase.ResetText()
        updResponsibility.Clear()
        updPPE1.Clear()
        updPPE2.Clear()
        updPPE3.Clear()
        'listViewInventory.SelectedItems.Clear()
        updArticle.Focus()
    End Sub
    Private Sub populateList()
        Dim query As String = "SELECT id, article, description, um, unitValue, dateOfPurchase, cond FROM inventory"
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
                            'item.SubItems.Add(reader("location").ToString())
                            item.SubItems.Add(reader("cond").ToString())
                            'item.SubItems.Add(reader("remarks").ToString())
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
        Dim query As String = "SELECT * FROM inventory WHERE article LIKE @searchText OR description LIKE @searchText OR propNum LIKE @searchText OR newPropNum LIKE @searchText OR locationActual LIKE @searchText OR locationReport LIKE @searchText OR dateOfPurchase LIKE @searchText OR responsibility LIKE @searchText OR cond LIKE @searchText OR PPE1 LIKE @searchText OR PPE2 LIKE @searchText OR PPE3 LIKE @searchText"
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
                            'item.SubItems.Add(reader("location").ToString())
                            item.SubItems.Add(reader("cond").ToString())
                            'item.SubItems.Add(reader("remarks").ToString())
                            listViewInventory.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
            tbxArticle.Clear()
            tbxDescr.Clear()
            tbxUnitValue.Clear()
            tbxLocationActual.Clear()
            tbxPPE1.Clear()
            tbxPropNum.Clear()
            tbxNewPropNum.Clear()
            tbxQtyPropCard.Clear()
            tbxQtyPhysCount.Clear()
            'cbxUM.SelectedIndex = 0
            'cbxCondition.SelectedIndex = 0
            dtpPurchase.ResetText()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub listViewInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewInventory.SelectedIndexChanged
        If listViewInventory.SelectedItems.Count > 0 Then
            Dim selectedRow As ListViewItem = listViewInventory.SelectedItems(0)
            Dim idValue As String = selectedRow.SubItems(0).Text
            populateUpdateTab(idValue)
        End If
    End Sub
    Private Sub populateUpdateTab(ByVal idValue As String)
        Dim query As String = "SELECT * FROM inventory WHERE id = @id"
        Try
            Using connection As New MySqlConnection(conString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", idValue)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            TabControl1.SelectedIndex = 1
                            updArticle.Text = reader("article").ToString()
                            updDescription.Text = reader("description").ToString()
                            updUM.Text = reader("um").ToString()
                            updUnitValue.Text = reader("unitValue").ToString()
                            updDate.Value = Convert.ToDateTime(reader("dateOfPurchase"))
                            updLocActual.Text = reader("locationActual").ToString()
                            updLocRep.Text = reader("locationReport").ToString()
                            updCondition.Text = reader("cond").ToString()
                            updPropNum.Text = reader("propNum").ToString()
                            updNewPropNum.Text = reader("newPropNum").ToString()
                            updQtyPropCard.Text = reader("qtyPropCard").ToString()
                            updQtyPhysCount.Text = reader("qtyPhysCount").ToString()
                            updResponsibility.Text = reader("responsibility").ToString()
                            updPPE1.Text = reader("PPE1").ToString()
                            updPPE2.Text = reader("PPE2").ToString()
                            updPPE3.Text = reader("PPE3").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'If String.IsNullOrWhiteSpace(tbxDescr.Text) OrElse
        'String.IsNullOrWhiteSpace(tbxUnitValue.Text) OrElse
        'String.IsNullOrWhiteSpace(tbxLocationActual.Text) OrElse
        'String.IsNullOrWhiteSpace(tbxLocationReport.Text) OrElse
        'String.IsNullOrWhiteSpace(tbxPropNum.Text) OrElse
        'String.IsNullOrWhiteSpace(tbxNewPropNum.Text) OrElse
        'String.IsNullOrWhiteSpace(tbxQtyPropCard.Text) OrElse
        'String.IsNullOrWhiteSpace(tbxQtyPhysCount.Text) OrElse
        'dtpPurchase.Value = DateTime.MinValue Then
        'cbxUM.SelectedIndex = -1 OrElse
        'cbxCondition.SelectedIndex = -1 OrElse
        'cbxUM.SelectedIndex = 0 OrElse
        'cbxCondition.SelectedIndex = 0 OrElse
        'MessageBox.Show("Fill out all fields to continue")
        'clearForm()
        'Else
        Dim result As DialogResult = MessageBox.Show("Add this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = "INSERT INTO inventory (article, description, um, unitValue, dateOfPurchase, cond, propNum, newPropNum, qtyPropCard, qtyPhysCount,locationActual,locationReport,responsibility,PPE1,PPE2,PPE3) VALUES (@article, @description, @um, @unitValue, @dateOfPurchase, @condit, @propNum, @newPropNum, @qtyPropCard, @qtyPhysCount, @locActual, @locReport, @responsib, @ppe1, @ppe2, @ppe3)"
            Try
                Dim description As String = tbxDescr.Text.Replace(vbCrLf, " ").Replace(vbTab, " ").Replace(ControlChars.Lf, "") 'para single line lang
                Using connection As New MySqlConnection(conString)
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameters
                        command.Parameters.AddWithValue("@article", tbxArticle.Text)
                        command.Parameters.AddWithValue("@description", tbxDescr.Text.ToUpper)
                        command.Parameters.AddWithValue("@um", tbxUM.Text)
                        command.Parameters.AddWithValue("@unitValue", tbxUnitValue.Text)
                        command.Parameters.AddWithValue("@dateOfPurchase", dtpPurchase.Text)
                        command.Parameters.AddWithValue("@condit", tbxCondition.Text)
                        command.Parameters.AddWithValue("@propNum", tbxPropNum.Text)
                        command.Parameters.AddWithValue("@newPropNum", tbxNewPropNum.Text)
                        command.Parameters.AddWithValue("@qtyPropCard", tbxQtyPropCard.Text)
                        command.Parameters.AddWithValue("@qtyPhysCount", tbxQtyPhysCount.Text)
                        command.Parameters.AddWithValue("@locActual", tbxLocationActual.Text)
                        command.Parameters.AddWithValue("@locReport", tbxResponsibility.Text)
                        command.Parameters.AddWithValue("@responsib", tbxLocationActual.Text)
                        command.Parameters.AddWithValue("@ppe1", tbxPPE1.Text)
                        command.Parameters.AddWithValue("@ppe2", tbxPPE2.Text)
                        command.Parameters.AddWithValue("@ppe3", tbxPPE3.Text)
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Item added successfully!")
                            clearAddTab()
                        Else
                            MessageBox.Show("Failed to add item!")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
        'End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearAddTab()
    End Sub
    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If listViewInventory.SelectedItems.Count > 0 Then
            Dim selectedRow As ListViewItem = listViewInventory.SelectedItems(0)
            Dim idValue As String = selectedRow.SubItems(0).Text ' Get the ID of the selected row
            Dim result As DialogResult = MessageBox.Show("Update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Get values from textboxes
                Dim article As String = updArticle.Text
                Dim description As String = updDescription.Text.ToUpper
                Dim um As String = updUM.Text
                Dim unitValue As String = updUnitValue.Text
                Dim dateOfPurchase As String = dtpPurchase.Text
                Dim locActual As String = updLocActual.Text
                Dim locReport As String = updLocRep.Text
                Dim condit As String = updCondition.Text
                Dim respo As String = updResponsibility.Text
                Dim ppe1 As String = updPPE1.Text
                Dim ppe2 As String = updPPE2.Text
                Dim ppe3 As String = updPPE3.Text
                Dim prop As String = updPropNum.Text
                Dim newProp As String = updNewPropNum.Text
                Dim propCard As String = updQtyPropCard.Text
                Dim physCount As String = updQtyPhysCount.Text
                Dim query As String = "UPDATE inventory SET article = @article, description = @description, um = @um, unitValue = @unitValue, dateOfPurchase = @dateOfPurchase, locationActual = @locActual, locationReport=@locReport, cond = @condit,responsibility = @respo, propNum=@prop, newPropNum = @newProp, qtyPropCard = @propCard, qtyPhysCount = @physCount, PPE1 = @ppe1, PPE2 = @ppe2, PPE3 = @ppe3 WHERE id = @id"
                Try
                    Using connection As New MySqlConnection(conString)
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@article", article)
                            command.Parameters.AddWithValue("@description", description)
                            command.Parameters.AddWithValue("@um", um)
                            command.Parameters.AddWithValue("@unitValue", unitValue)
                            command.Parameters.AddWithValue("@dateOfPurchase", dateOfPurchase)
                            command.Parameters.AddWithValue("@locActual", locActual)
                            command.Parameters.AddWithValue("@locReport", locReport)
                            command.Parameters.AddWithValue("@condit", condit)
                            command.Parameters.AddWithValue("@respo", respo)
                            command.Parameters.AddWithValue("@prop", prop)
                            command.Parameters.AddWithValue("@newProp", newProp)
                            command.Parameters.AddWithValue("@propCard", propCard)
                            command.Parameters.AddWithValue("@physCount", physCount)
                            command.Parameters.AddWithValue("@ppe1", ppe1)
                            command.Parameters.AddWithValue("@ppe2", ppe2)
                            command.Parameters.AddWithValue("@ppe3", ppe3)
                            command.Parameters.AddWithValue("@id", idValue) ' Use the ID of the selected row
                            connection.Open()
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Item updated successfully!")
                                clearUpdTab()
                            Else
                                MessageBox.Show("Item update failed!.")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                clearUpdTab()
            End If
        Else
            MessageBox.Show("Select item to continue")
        End If
    End Sub
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
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
                                clearUpdTab()
                            Else
                                MessageBox.Show("No item deleted.")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                clearUpdTab()
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
        clearUpdTab()
    End Sub
    Private Sub supplyInventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            clearUpdTab()
        ElseIf TabControl1.SelectedIndex = 1 Then

        End If
    End Sub
End Class