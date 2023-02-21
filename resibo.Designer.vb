<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resibo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.strdate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.strcustomername = New System.Windows.Forms.Label()
        Me.strmodelname = New System.Windows.Forms.Label()
        Me.strcartype = New System.Windows.Forms.Label()
        Me.strmechname = New System.Windows.Forms.Label()
        Me.strservicetype = New System.Windows.Forms.Label()
        Me.stroverall = New System.Windows.Forms.Label()
        Me.strfee = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stritemname = New System.Windows.Forms.Label()
        Me.strprice = New System.Windows.Forms.Label()
        Me.strqty = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'strdate
        '
        Me.strdate.AutoSize = True
        Me.strdate.Font = New System.Drawing.Font("ROG Fonts", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strdate.Location = New System.Drawing.Point(575, 134)
        Me.strdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strdate.Name = "strdate"
        Me.strdate.Size = New System.Drawing.Size(165, 20)
        Me.strdate.TabIndex = 1
        Me.strdate.Text = "SERVICE DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "customer name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(438, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CAR MODEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(438, 242)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CARTYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 242)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MECHANIC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 336)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "SERVICETYPES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(615, 473)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TOTAL"
        '
        'strcustomername
        '
        Me.strcustomername.AutoSize = True
        Me.strcustomername.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strcustomername.Location = New System.Drawing.Point(78, 201)
        Me.strcustomername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strcustomername.Name = "strcustomername"
        Me.strcustomername.Size = New System.Drawing.Size(13, 18)
        Me.strcustomername.TabIndex = 8
        Me.strcustomername.Text = "."
        '
        'strmodelname
        '
        Me.strmodelname.AutoSize = True
        Me.strmodelname.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strmodelname.Location = New System.Drawing.Point(438, 201)
        Me.strmodelname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strmodelname.Name = "strmodelname"
        Me.strmodelname.Size = New System.Drawing.Size(13, 18)
        Me.strmodelname.TabIndex = 9
        Me.strmodelname.Text = "."
        '
        'strcartype
        '
        Me.strcartype.AutoSize = True
        Me.strcartype.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strcartype.Location = New System.Drawing.Point(438, 281)
        Me.strcartype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strcartype.Name = "strcartype"
        Me.strcartype.Size = New System.Drawing.Size(13, 18)
        Me.strcartype.TabIndex = 10
        Me.strcartype.Text = "."
        '
        'strmechname
        '
        Me.strmechname.AutoSize = True
        Me.strmechname.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strmechname.Location = New System.Drawing.Point(78, 281)
        Me.strmechname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strmechname.Name = "strmechname"
        Me.strmechname.Size = New System.Drawing.Size(13, 18)
        Me.strmechname.TabIndex = 11
        Me.strmechname.Text = "."
        '
        'strservicetype
        '
        Me.strservicetype.AutoSize = True
        Me.strservicetype.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strservicetype.Location = New System.Drawing.Point(203, 365)
        Me.strservicetype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strservicetype.Name = "strservicetype"
        Me.strservicetype.Size = New System.Drawing.Size(13, 18)
        Me.strservicetype.TabIndex = 12
        Me.strservicetype.Text = "."
        '
        'stroverall
        '
        Me.stroverall.AutoSize = True
        Me.stroverall.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stroverall.Location = New System.Drawing.Point(595, 508)
        Me.stroverall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stroverall.Name = "stroverall"
        Me.stroverall.Size = New System.Drawing.Size(13, 18)
        Me.stroverall.TabIndex = 13
        Me.stroverall.Text = "."
        '
        'strfee
        '
        Me.strfee.AutoSize = True
        Me.strfee.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strfee.Location = New System.Drawing.Point(203, 382)
        Me.strfee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strfee.Name = "strfee"
        Me.strfee.Size = New System.Drawing.Size(13, 18)
        Me.strfee.TabIndex = 14
        Me.strfee.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(439, 336)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Parts Avail"
        '
        'stritemname
        '
        Me.stritemname.AutoSize = True
        Me.stritemname.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stritemname.Location = New System.Drawing.Point(527, 365)
        Me.stritemname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stritemname.Name = "stritemname"
        Me.stritemname.Size = New System.Drawing.Size(13, 18)
        Me.stritemname.TabIndex = 16
        Me.stritemname.Text = "."
        '
        'strprice
        '
        Me.strprice.AutoSize = True
        Me.strprice.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strprice.Location = New System.Drawing.Point(527, 382)
        Me.strprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strprice.Name = "strprice"
        Me.strprice.Size = New System.Drawing.Size(13, 18)
        Me.strprice.TabIndex = 17
        Me.strprice.Text = "."
        '
        'strqty
        '
        Me.strqty.AutoSize = True
        Me.strqty.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strqty.Location = New System.Drawing.Point(527, 401)
        Me.strqty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strqty.Name = "strqty"
        Me.strqty.Size = New System.Drawing.Size(13, 18)
        Me.strqty.TabIndex = 18
        Me.strqty.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 34)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Acme Auto Servicing Center"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(438, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "item name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(440, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Sell Price:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(440, 401)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Quantity:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(79, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 18)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "service name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(79, 382)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 18)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "service fee:"
        '
        'resibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(809, 613)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.strqty)
        Me.Controls.Add(Me.strprice)
        Me.Controls.Add(Me.stritemname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.strfee)
        Me.Controls.Add(Me.stroverall)
        Me.Controls.Add(Me.strservicetype)
        Me.Controls.Add(Me.strmechname)
        Me.Controls.Add(Me.strcartype)
        Me.Controls.Add(Me.strmodelname)
        Me.Controls.Add(Me.strcustomername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.strdate)
        Me.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "resibo"
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents strdate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents strcustomername As Label
    Friend WithEvents strmodelname As Label
    Friend WithEvents strcartype As Label
    Friend WithEvents strmechname As Label
    Friend WithEvents strservicetype As Label
    Friend WithEvents stroverall As Label
    Friend WithEvents strfee As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents stritemname As Label
    Friend WithEvents strprice As Label
    Friend WithEvents strqty As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
