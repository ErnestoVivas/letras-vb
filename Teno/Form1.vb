Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Teno"

        ' Create MenuStrip and menu items
        Dim menuStrip As New MenuStrip()
        Dim fileMenuItem As New ToolStripMenuItem("File")
        Dim exitMenuItem As New ToolStripMenuItem("Exit")

        ' Arrange items
        fileMenuItem.DropDownItems.Add(exitMenuItem)
        menuStrip.Items.Add(fileMenuItem)

        ' Add an event handler for the Exit menu item
        AddHandler exitMenuItem.Click, AddressOf ExitMenuItem_Click

        ' Set the MenuStrip as the main menu of the form and add it to the form's controls
        Me.MainMenuStrip = menuStrip
        Me.Controls.Add(menuStrip)

    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close() ' Closes the application
    End Sub

End Class
