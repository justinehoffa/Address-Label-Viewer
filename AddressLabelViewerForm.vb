﻿Public Class AddressLabelViewerForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim textBox As Control
        DisplayLabel.Text = ""
        For Each Textbox In Me.Controls
            If TypeOf textBox Is TextBox Then
                textBox.Text = ""
            End If
        Next
    End Sub

    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        ValidateTextBoxes()

        If AccumulateMessage("", False) <> "" Then
            AlertUser(AccumulateMessage("", False))
        Else
            Display()
        End If
    End Sub

    Sub ValidateTextBoxes()
        Dim problem As Boolean = False

        If FirstNameTextBox.Text = "" Then
            AccumulateMessage("First Name is a required field.", False)
            FirstNameTextBox.Focus()
            problem = False
        End If

        If LastNameTextBox.Text = "" Then
            AccumulateMessage("Last Name is a required field.", False)
            LastNameTextBox.Focus()
            problem = False
        End If

        If StreetAddressTextBox.Text = "" Then
            AccumulateMessage("Street Address is a required field.", False)
            StreetAddressTextBox.Focus()
            problem = False
        End If

        If CityTextBox.Text = "" Then
            AccumulateMessage("City is a required field.", False)
            CityTextBox.Focus()
            problem = False
        End If

        If StateTextBox.Text = "" Then
            AccumulateMessage("State is a required field.", False)
            StateTextBox.Focus()
            problem = False
        End If

        If ZipTextBox.Text = "" Then
            AccumulateMessage("Zip is a required field.", False)
            ZipTextBox.Focus()
            problem = False
        End If

        If ZipTextBox.Text = "" And Not problem Then
            CreateZipCode()
        End If

    End Sub

    Sub AlertUser(ByVal Message As String)
        MsgBox(Message)
        AccumulateMessage("", True)
    End Sub

    Function AccumulateMessage(ByVal newMessage As String, Clear As Boolean) As String
        Static message As String
        If Clear Then
            message = ""
        ElseIf newMessage <> "" Then
            message &= newMessage & vbNewLine
        End If
        Return message
    End Function

    Sub CreateZipCode()
        ZipTextBox.Text = "83***"
    End Sub

    Sub Display()
        DisplayLabel.Text = FirstNameTextBox.Text _
                            & vbNewLine & LastNameTextBox.Text _
                            & vbNewLine & StreetAddressTextBox.Text _
                            & vbNewLine & CityTextBox.Text _
                            & vbNewLine & StateTextBox.Text & "," _
                            & ZipTextBox.Text
    End Sub

End Class
