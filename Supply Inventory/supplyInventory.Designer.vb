<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplyInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxArticle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxPropNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxNewPropNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxUnitValue = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpPurchase = New System.Windows.Forms.DateTimePicker()
        Me.tbxDescr = New System.Windows.Forms.RichTextBox()
        Me.tbxQtyPropCard = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbxQtyPhysCount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.listViewInventory = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbxLocationActual = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbxPPE1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbxLocationReport = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxPPE2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbxPPE3 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbxResponsibility = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbxUM = New System.Windows.Forms.TextBox()
        Me.tbxCondition = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(33, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "PPE ACCOUNT GROUP:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Firebrick
        Me.Label11.Location = New System.Drawing.Point(179, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "OTHER MACHINERY AND EQUIPMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Article:"
        '
        'tbxArticle
        '
        Me.tbxArticle.BackColor = System.Drawing.Color.White
        Me.tbxArticle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxArticle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxArticle.Location = New System.Drawing.Point(94, 326)
        Me.tbxArticle.Name = "tbxArticle"
        Me.tbxArticle.Size = New System.Drawing.Size(174, 27)
        Me.tbxArticle.TabIndex = 4
        Me.tbxArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Description:"
        '
        'tbxPropNum
        '
        Me.tbxPropNum.BackColor = System.Drawing.Color.White
        Me.tbxPropNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxPropNum.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPropNum.Location = New System.Drawing.Point(36, 513)
        Me.tbxPropNum.Name = "tbxPropNum"
        Me.tbxPropNum.Size = New System.Drawing.Size(542, 26)
        Me.tbxPropNum.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Old Property No.:"
        '
        'tbxNewPropNum
        '
        Me.tbxNewPropNum.BackColor = System.Drawing.Color.White
        Me.tbxNewPropNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNewPropNum.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewPropNum.Location = New System.Drawing.Point(36, 577)
        Me.tbxNewPropNum.Name = "tbxNewPropNum"
        Me.tbxNewPropNum.Size = New System.Drawing.Size(542, 26)
        Me.tbxNewPropNum.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 558)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "New Property No.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 617)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "UM:"
        '
        'tbxUnitValue
        '
        Me.tbxUnitValue.BackColor = System.Drawing.Color.White
        Me.tbxUnitValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxUnitValue.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUnitValue.Location = New System.Drawing.Point(323, 636)
        Me.tbxUnitValue.Name = "tbxUnitValue"
        Me.tbxUnitValue.Size = New System.Drawing.Size(256, 26)
        Me.tbxUnitValue.TabIndex = 14
        Me.tbxUnitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 617)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Unit Value:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 675)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Date of Purchase:"
        '
        'dtpPurchase
        '
        Me.dtpPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpPurchase.CustomFormat = "MMM dd, yyyy"
        Me.dtpPurchase.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPurchase.Location = New System.Drawing.Point(37, 694)
        Me.dtpPurchase.Name = "dtpPurchase"
        Me.dtpPurchase.Size = New System.Drawing.Size(158, 27)
        Me.dtpPurchase.TabIndex = 16
        Me.dtpPurchase.Value = New Date(2024, 2, 27, 0, 0, 0, 0)
        '
        'tbxDescr
        '
        Me.tbxDescr.BackColor = System.Drawing.Color.White
        Me.tbxDescr.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDescr.Location = New System.Drawing.Point(36, 380)
        Me.tbxDescr.Name = "tbxDescr"
        Me.tbxDescr.Size = New System.Drawing.Size(542, 111)
        Me.tbxDescr.TabIndex = 6
        Me.tbxDescr.Text = ""
        '
        'tbxQtyPropCard
        '
        Me.tbxQtyPropCard.BackColor = System.Drawing.Color.White
        Me.tbxQtyPropCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxQtyPropCard.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxQtyPropCard.Location = New System.Drawing.Point(212, 694)
        Me.tbxQtyPropCard.Name = "tbxQtyPropCard"
        Me.tbxQtyPropCard.Size = New System.Drawing.Size(173, 27)
        Me.tbxQtyPropCard.TabIndex = 18
        Me.tbxQtyPropCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(210, 675)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Qty. Per Property Card:"
        '
        'tbxQtyPhysCount
        '
        Me.tbxQtyPhysCount.BackColor = System.Drawing.Color.White
        Me.tbxQtyPhysCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxQtyPhysCount.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxQtyPhysCount.Location = New System.Drawing.Point(405, 694)
        Me.tbxQtyPhysCount.Name = "tbxQtyPhysCount"
        Me.tbxQtyPhysCount.Size = New System.Drawing.Size(174, 27)
        Me.tbxQtyPhysCount.TabIndex = 20
        Me.tbxQtyPhysCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(402, 675)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(169, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Qty. Per Physical Count:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(614, 331)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 16)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Location (actual):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(614, 509)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Condition:"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(1111, 372)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 72)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(1111, 464)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(144, 72)
        Me.btnUpdate.TabIndex = 38
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(1111, 650)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(144, 72)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(1282, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VETERANS GOLF CLUB"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1282, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INVENTORY COUNT FORM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(0, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1282, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OPERATION STATION"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1282, 75)
        Me.Panel1.TabIndex = 19
        '
        'listViewInventory
        '
        Me.listViewInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listViewInventory.BackColor = System.Drawing.Color.White
        Me.listViewInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader12})
        Me.listViewInventory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewInventory.FullRowSelect = True
        Me.listViewInventory.GridLines = True
        Me.listViewInventory.HideSelection = False
        Me.listViewInventory.Location = New System.Drawing.Point(36, 103)
        Me.listViewInventory.Name = "listViewInventory"
        Me.listViewInventory.Size = New System.Drawing.Size(1209, 208)
        Me.listViewInventory.TabIndex = 2
        Me.listViewInventory.UseCompatibleStateImageBehavior = False
        Me.listViewInventory.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "id"
        Me.id.Width = 57
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Article"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Description"
        Me.ColumnHeader5.Width = 402
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "UM"
        Me.ColumnHeader6.Width = 75
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Unit Value"
        Me.ColumnHeader7.Width = 133
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Date of Purchase"
        Me.ColumnHeader10.Width = 157
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Condition"
        Me.ColumnHeader12.Width = 321
        '
        'tbxLocationActual
        '
        Me.tbxLocationActual.BackColor = System.Drawing.Color.White
        Me.tbxLocationActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxLocationActual.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLocationActual.Location = New System.Drawing.Point(617, 350)
        Me.tbxLocationActual.Name = "tbxLocationActual"
        Me.tbxLocationActual.Size = New System.Drawing.Size(457, 26)
        Me.tbxLocationActual.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(943, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Search:"
        '
        'tbxSearch
        '
        Me.tbxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxSearch.BackColor = System.Drawing.Color.White
        Me.tbxSearch.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.Location = New System.Drawing.Point(1008, 70)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(237, 26)
        Me.tbxSearch.TabIndex = 36
        Me.tbxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(1111, 559)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(144, 72)
        Me.btnClear.TabIndex = 39
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'tbxPPE1
        '
        Me.tbxPPE1.BackColor = System.Drawing.Color.White
        Me.tbxPPE1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxPPE1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPPE1.Location = New System.Drawing.Point(618, 577)
        Me.tbxPPE1.Name = "tbxPPE1"
        Me.tbxPPE1.Size = New System.Drawing.Size(457, 26)
        Me.tbxPPE1.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(615, 558)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "PPE:"
        '
        'tbxLocationReport
        '
        Me.tbxLocationReport.BackColor = System.Drawing.Color.White
        Me.tbxLocationReport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxLocationReport.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLocationReport.Location = New System.Drawing.Point(617, 412)
        Me.tbxLocationReport.Name = "tbxLocationReport"
        Me.tbxLocationReport.Size = New System.Drawing.Size(457, 26)
        Me.tbxLocationReport.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(614, 393)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 16)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Location (report):"
        '
        'tbxPPE2
        '
        Me.tbxPPE2.BackColor = System.Drawing.Color.White
        Me.tbxPPE2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxPPE2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPPE2.Location = New System.Drawing.Point(618, 636)
        Me.tbxPPE2.Name = "tbxPPE2"
        Me.tbxPPE2.Size = New System.Drawing.Size(457, 26)
        Me.tbxPPE2.TabIndex = 32
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(615, 617)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 16)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "PPE:"
        '
        'tbxPPE3
        '
        Me.tbxPPE3.BackColor = System.Drawing.Color.White
        Me.tbxPPE3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxPPE3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPPE3.Location = New System.Drawing.Point(618, 694)
        Me.tbxPPE3.Name = "tbxPPE3"
        Me.tbxPPE3.Size = New System.Drawing.Size(457, 26)
        Me.tbxPPE3.TabIndex = 34
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(615, 675)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 16)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "PPE:"
        '
        'tbxResponsibility
        '
        Me.tbxResponsibility.BackColor = System.Drawing.Color.White
        Me.tbxResponsibility.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxResponsibility.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResponsibility.Location = New System.Drawing.Point(617, 472)
        Me.tbxResponsibility.Name = "tbxResponsibility"
        Me.tbxResponsibility.Size = New System.Drawing.Size(457, 26)
        Me.tbxResponsibility.TabIndex = 26
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(614, 453)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 16)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Responsibility:"
        '
        'tbxUM
        '
        Me.tbxUM.BackColor = System.Drawing.Color.White
        Me.tbxUM.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxUM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUM.Location = New System.Drawing.Point(37, 636)
        Me.tbxUM.Name = "tbxUM"
        Me.tbxUM.Size = New System.Drawing.Size(256, 26)
        Me.tbxUM.TabIndex = 12
        Me.tbxUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxCondition
        '
        Me.tbxCondition.BackColor = System.Drawing.Color.White
        Me.tbxCondition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxCondition.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCondition.Location = New System.Drawing.Point(617, 528)
        Me.tbxCondition.Name = "tbxCondition"
        Me.tbxCondition.Size = New System.Drawing.Size(457, 26)
        Me.tbxCondition.TabIndex = 28
        '
        'supplyInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1282, 745)
        Me.Controls.Add(Me.tbxPPE3)
        Me.Controls.Add(Me.tbxPPE2)
        Me.Controls.Add(Me.tbxPPE1)
        Me.Controls.Add(Me.tbxCondition)
        Me.Controls.Add(Me.tbxUM)
        Me.Controls.Add(Me.tbxResponsibility)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbxLocationReport)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbxLocationActual)
        Me.Controls.Add(Me.listViewInventory)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbxQtyPhysCount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbxQtyPropCard)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbxDescr)
        Me.Controls.Add(Me.dtpPurchase)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbxUnitValue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxNewPropNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbxPropNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxArticle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "supplyInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY COUNT FORM"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbxArticle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbxPropNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbxNewPropNum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbxUnitValue As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpPurchase As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbxDescr As System.Windows.Forms.RichTextBox
    Friend WithEvents tbxQtyPropCard As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbxQtyPhysCount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents listViewInventory As System.Windows.Forms.ListView
    Friend WithEvents tbxLocationActual As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbxSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tbxPPE1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbxLocationReport As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbxPPE2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbxPPE3 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tbxResponsibility As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tbxUM As TextBox
    Friend WithEvents tbxCondition As TextBox
End Class
