<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addplacedetails
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addplacedetails))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbimage = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Txttitle = New System.Windows.Forms.TextBox()
        Me.Txtabout = New System.Windows.Forms.TextBox()
        Me.Txtimagename = New System.Windows.Forms.TextBox()
        Me.Txttransport = New System.Windows.Forms.TextBox()
        Me.Txtwalk = New System.Windows.Forms.TextBox()
        Me.Txtmapurl = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Back")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(441, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Place Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 56)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(984, 491)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Browser"
        Me.ToolTip1.SetToolTip(Me.Button1, "Select Image")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Place Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(710, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "About"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(79, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Image Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(58, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 38)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Transportation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(122, 518)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 38)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "To Walk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(122, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 38)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Map URL"
        '
        'pbimage
        '
        Me.pbimage.Location = New System.Drawing.Point(808, 334)
        Me.pbimage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbimage.Name = "pbimage"
        Me.pbimage.Size = New System.Drawing.Size(370, 150)
        Me.pbimage.TabIndex = 9
        Me.pbimage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbimage, "Choose Image From Your Device")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(988, 579)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 55)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Save All "
        Me.ToolTip1.SetToolTip(Me.Button2, "Save Data")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Txttitle
        '
        Me.Txttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttitle.Location = New System.Drawing.Point(309, 85)
        Me.Txttitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txttitle.Name = "Txttitle"
        Me.Txttitle.Size = New System.Drawing.Size(330, 39)
        Me.Txttitle.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Txttitle, "Enter Title")
        '
        'Txtabout
        '
        Me.Txtabout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtabout.Location = New System.Drawing.Point(808, 61)
        Me.Txtabout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txtabout.Multiline = True
        Me.Txtabout.Name = "Txtabout"
        Me.Txtabout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtabout.Size = New System.Drawing.Size(370, 234)
        Me.Txtabout.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.Txtabout, "Enter About Place With ABOUT Title")
        '
        'Txtimagename
        '
        Me.Txtimagename.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtimagename.Location = New System.Drawing.Point(304, 348)
        Me.Txtimagename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txtimagename.Name = "Txtimagename"
        Me.Txtimagename.Size = New System.Drawing.Size(330, 39)
        Me.Txtimagename.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Txtimagename, "Enter Image")
        '
        'Txttransport
        '
        Me.Txttransport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttransport.Location = New System.Drawing.Point(304, 176)
        Me.Txttransport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txttransport.Multiline = True
        Me.Txttransport.Name = "Txttransport"
        Me.Txttransport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txttransport.Size = New System.Drawing.Size(330, 130)
        Me.Txttransport.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Txttransport, "Enter Transportation Details with TRANSPORTATION Title")
        '
        'Txtwalk
        '
        Me.Txtwalk.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtwalk.Location = New System.Drawing.Point(304, 506)
        Me.Txtwalk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txtwalk.Name = "Txtwalk"
        Me.Txtwalk.Size = New System.Drawing.Size(330, 39)
        Me.Txtwalk.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Txtwalk, "Enter Walk Duration ")
        '
        'Txtmapurl
        '
        Me.Txtmapurl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmapurl.Location = New System.Drawing.Point(304, 428)
        Me.Txtmapurl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txtmapurl.Name = "Txtmapurl"
        Me.Txtmapurl.Size = New System.Drawing.Size(330, 39)
        Me.Txtmapurl.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.Txtmapurl, "Enter Map URL ")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(234, 731)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 55)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "View"
        Me.ToolTip1.SetToolTip(Me.Button4, "Update Data")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(448, 731)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 55)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.Button3, "Update Data")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(310, 666)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(330, 39)
        Me.TxtID.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.TxtID, "Enter Map URL ")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(86, 666)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 38)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Place name"
        Me.ToolTip1.SetToolTip(Me.Label8, "Enter Id for Update")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 625)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(716, 181)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'addplacedetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1240, 801)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Txtmapurl)
        Me.Controls.Add(Me.Txtwalk)
        Me.Controls.Add(Me.Txttransport)
        Me.Controls.Add(Me.Txtimagename)
        Me.Controls.Add(Me.Txtabout)
        Me.Controls.Add(Me.Txttitle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pbimage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "addplacedetails"
        Me.Text = "Place Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pbimage As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Txttitle As TextBox
    Friend WithEvents Txtabout As TextBox
    Friend WithEvents Txtimagename As TextBox
    Friend WithEvents Txttransport As TextBox
    Friend WithEvents Txtwalk As TextBox
    Friend WithEvents Txtmapurl As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label8 As Label
End Class
