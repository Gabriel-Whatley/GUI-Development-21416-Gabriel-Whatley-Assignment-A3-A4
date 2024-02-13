<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        picbox_prime = New PictureBox()
        btn_prime = New Button()
        btn_veg = New Button()
        btn_select = New Button()
        btn_exit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        sel_msg_lbl = New Label()
        picbox_veggie = New PictureBox()
        CType(picbox_prime, ComponentModel.ISupportInitialize).BeginInit()
        CType(picbox_veggie, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picbox_prime
        ' 
        picbox_prime.BackgroundImageLayout = ImageLayout.Zoom
        picbox_prime.Location = New Point(47, 69)
        picbox_prime.Name = "picbox_prime"
        picbox_prime.Size = New Size(250, 167)
        picbox_prime.SizeMode = PictureBoxSizeMode.StretchImage
        picbox_prime.TabIndex = 0
        picbox_prime.TabStop = False
        picbox_prime.Visible = False
        ' 
        ' btn_prime
        ' 
        btn_prime.Location = New Point(135, 242)
        btn_prime.Name = "btn_prime"
        btn_prime.Size = New Size(75, 23)
        btn_prime.TabIndex = 1
        btn_prime.Text = "Prime Beef"
        btn_prime.UseVisualStyleBackColor = True
        ' 
        ' btn_veg
        ' 
        btn_veg.Location = New Point(424, 242)
        btn_veg.Name = "btn_veg"
        btn_veg.Size = New Size(75, 23)
        btn_veg.TabIndex = 2
        btn_veg.Text = "Veggie"
        btn_veg.UseVisualStyleBackColor = True
        ' 
        ' select_btn
        ' 
        btn_select.Location = New Point(266, 272)
        btn_select.Name = "select_btn"
        btn_select.Size = New Size(101, 23)
        btn_select.TabIndex = 3
        btn_select.Text = "Select Meal"
        btn_select.UseVisualStyleBackColor = True
        ' 
        ' btn_exit
        ' 
        btn_exit.Location = New Point(266, 382)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(101, 23)
        btn_exit.TabIndex = 4
        btn_exit.Text = "Exit Window"
        btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold)
        Label1.Location = New Point(192, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 27)
        Label1.TabIndex = 5
        Label1.Text = "Farm Burger Specials"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(162, 313)
        Label2.Name = "Label2"
        Label2.Size = New Size(308, 14)
        Label2.TabIndex = 6
        Label2.Text = "Choose a burger and then click the Select Meal button"
        ' 
        ' sel_msg_lbl
        ' 
        sel_msg_lbl.AutoSize = True
        sel_msg_lbl.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sel_msg_lbl.Location = New Point(246, 344)
        sel_msg_lbl.Name = "sel_msg_lbl"
        sel_msg_lbl.Size = New Size(144, 14)
        sel_msg_lbl.TabIndex = 7
        sel_msg_lbl.Text = "Enjoy your burger special"
        sel_msg_lbl.Visible = False
        ' 
        ' picbox_veggie
        ' 
        picbox_veggie.BackgroundImageLayout = ImageLayout.Zoom
        picbox_veggie.Location = New Point(336, 69)
        picbox_veggie.Name = "picbox_veggie"
        picbox_veggie.Size = New Size(250, 167)
        picbox_veggie.SizeMode = PictureBoxSizeMode.StretchImage
        picbox_veggie.TabIndex = 8
        picbox_veggie.TabStop = False
        picbox_veggie.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(632, 435)
        Controls.Add(picbox_veggie)
        Controls.Add(sel_msg_lbl)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_exit)
        Controls.Add(btn_select)
        Controls.Add(btn_veg)
        Controls.Add(btn_prime)
        Controls.Add(picbox_prime)
        Name = "Form1"
        Text = "Form1"
        CType(picbox_prime, ComponentModel.ISupportInitialize).EndInit()
        CType(picbox_veggie, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picbox_prime As PictureBox
    Friend WithEvents btn_prime As Button
    Friend WithEvents btn_veg As Button
    Friend WithEvents btn_select As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sel_msg_lbl As Label
    Friend WithEvents picbox_veggie As PictureBox

End Class
