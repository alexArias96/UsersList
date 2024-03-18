<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Users
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Users))
        Me.pnl_Title = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pnl_data = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Modify = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Identity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_UsersList = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnl_Title.SuspendLayout()
        Me.pnl_data.SuspendLayout()
        CType(Me.dgv_UsersList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_Title
        '
        Me.pnl_Title.BackColor = System.Drawing.Color.Black
        Me.pnl_Title.Controls.Add(Me.Panel1)
        Me.pnl_Title.Controls.Add(Me.Label1)
        Me.pnl_Title.Controls.Add(Me.btn_Close)
        Me.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Title.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Title.Name = "pnl_Title"
        Me.pnl_Title.Size = New System.Drawing.Size(509, 47)
        Me.pnl_Title.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(76, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 10)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Users"
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Red
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(452, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(57, 47)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "X"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'pnl_data
        '
        Me.pnl_data.BackColor = System.Drawing.Color.DimGray
        Me.pnl_data.Controls.Add(Me.btn_Cancel)
        Me.pnl_data.Controls.Add(Me.btn_Modify)
        Me.pnl_data.Controls.Add(Me.btn_Save)
        Me.pnl_data.Controls.Add(Me.txt_Email)
        Me.pnl_data.Controls.Add(Me.txt_Phone)
        Me.pnl_data.Controls.Add(Me.Label6)
        Me.pnl_data.Controls.Add(Me.Label5)
        Me.pnl_data.Controls.Add(Me.txt_LastName)
        Me.pnl_data.Controls.Add(Me.txt_Name)
        Me.pnl_data.Controls.Add(Me.txt_Identity)
        Me.pnl_data.Controls.Add(Me.Label4)
        Me.pnl_data.Controls.Add(Me.Label3)
        Me.pnl_data.Controls.Add(Me.Label2)
        Me.pnl_data.Controls.Add(Me.dgv_UsersList)
        Me.pnl_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_data.Location = New System.Drawing.Point(0, 47)
        Me.pnl_data.Name = "pnl_data"
        Me.pnl_data.Size = New System.Drawing.Size(509, 385)
        Me.pnl_data.TabIndex = 2
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Cancel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(385, 141)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 32)
        Me.btn_Cancel.TabIndex = 28
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Modify
        '
        Me.btn_Modify.BackColor = System.Drawing.Color.Yellow
        Me.btn_Modify.Enabled = False
        Me.btn_Modify.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modify.ForeColor = System.Drawing.Color.White
        Me.btn_Modify.Location = New System.Drawing.Point(211, 141)
        Me.btn_Modify.Name = "btn_Modify"
        Me.btn_Modify.Size = New System.Drawing.Size(92, 32)
        Me.btn_Modify.TabIndex = 27
        Me.btn_Modify.Text = "Modify"
        Me.btn_Modify.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Green
        Me.btn_Save.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(36, 141)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(92, 32)
        Me.btn_Save.TabIndex = 26
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(304, 100)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(185, 22)
        Me.txt_Email.TabIndex = 25
        '
        'txt_Phone
        '
        Me.txt_Phone.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Phone.Location = New System.Drawing.Point(92, 100)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(121, 22)
        Me.txt_Phone.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Phone"
        '
        'txt_LastName
        '
        Me.txt_LastName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LastName.Location = New System.Drawing.Point(354, 61)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(135, 22)
        Me.txt_LastName.TabIndex = 21
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(92, 61)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(121, 22)
        Me.txt_Name.TabIndex = 20
        '
        'txt_Identity
        '
        Me.txt_Identity.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Identity.Location = New System.Drawing.Point(354, 22)
        Me.txt_Identity.Name = "txt_Identity"
        Me.txt_Identity.Size = New System.Drawing.Size(135, 22)
        Me.txt_Identity.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(245, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Identity"
        '
        'dgv_UsersList
        '
        Me.dgv_UsersList.AllowUserToAddRows = False
        Me.dgv_UsersList.AllowUserToDeleteRows = False
        Me.dgv_UsersList.AllowUserToResizeColumns = False
        Me.dgv_UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_UsersList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        Me.dgv_UsersList.EnableHeadersVisualStyles = False
        Me.dgv_UsersList.Location = New System.Drawing.Point(14, 194)
        Me.dgv_UsersList.Name = "dgv_UsersList"
        Me.dgv_UsersList.RowHeadersVisible = False
        Me.dgv_UsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_UsersList.Size = New System.Drawing.Size(480, 172)
        Me.dgv_UsersList.TabIndex = 0
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        '
        'frm_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 432)
        Me.Controls.Add(Me.pnl_data)
        Me.Controls.Add(Me.pnl_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Users"
        Me.Text = "rs"
        Me.pnl_Title.ResumeLayout(False)
        Me.pnl_Title.PerformLayout()
        Me.pnl_data.ResumeLayout(False)
        Me.pnl_data.PerformLayout()
        CType(Me.dgv_UsersList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_Title As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_data As Panel
    Friend WithEvents dgv_UsersList As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Modify As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_Phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_LastName As TextBox
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents txt_Identity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
