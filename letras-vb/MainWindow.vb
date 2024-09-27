Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Letras Visual Basic"


        ' TOP MENU

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


        ' SEARCH BAR

        ' Create and configure the SearchBar (TextBox=
        Dim searchTextBox As New TextBox With {
            .Name = "searchTextBox",
            .Location = New Point(10, 50), ' Set location on the form
            .Width = 330, ' Set width
            .BorderStyle = BorderStyle.FixedSingle,
            .Text = "With A Little Help From My Friends ...",
            .ForeColor = Color.Gray
        }

        ' Create and configure the Button
        Dim searchButton As New Button With {
            .Text = "Buscar",
            .Location = New Point(350, 50), ' Set location next to the TextBox
            .BackColor = Color.LightBlue,
            .FlatStyle = FlatStyle.Flat
        }
        AddHandler searchButton.Click, AddressOf SearchButton_Click ' Event handler for button click

        ' Add the controls to the form
        Me.Controls.Add(searchTextBox)
        Me.Controls.Add(searchButton)

    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close() ' Closes the application
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs)
        Dim searchText As String = CType(Me.Controls("searchTextBox"), TextBox).Text
        MessageBox.Show("Searching for: " & searchText) ' Implement search logic here
    End Sub

End Class
