'Name: Gabriel Whatley
'Date :  2/13/24
'Class:   CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that allows the user To Select a burger, shows a picture, And displays a message When the burger Is selected.
Public Class Form1
    Private Sub btn_prime_Click(sender As Object, e As EventArgs) Handles btn_prime.Click
        picbox_prime.Visible = True 'Make the prime picbox visible and the veggie picbox invisible.
        picbox_veggie.Visible = False
    End Sub

    Private Sub btn_veg_Click(sender As Object, e As EventArgs) Handles btn_veg.Click
        picbox_veggie.Visible = True 'Make the veggie picbox visible and the prime picbox invisible.
        picbox_prime.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'load pictures from resources into picboxes on form load.
        picbox_prime.Image = My.Resources.prime  'load resources into picbox.
        picbox_veggie.Image = My.Resources.veggie 'load resources into picbox.
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        sel_msg_lbl.Visible = True 'show the burger message.
        btn_veg.Enabled = False 'disable veggie button.
        btn_prime.Enabled = False 'disable prime button.
        btn_select.Enabled = False 'disable select button.
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Close() 'close the form
    End Sub
End Class