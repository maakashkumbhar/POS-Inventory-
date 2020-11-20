Public Class frmRecipt

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub


    Private Sub frmRecipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InturnDataSet.Bills' table. You can move, or remove it, as needed.
        get_data()
    End Sub

    Public Sub get_data()
        Label19.Text = invoicefrm.cstmText.Text
        Label20.Text = invoicefrm.cstmAddress.Text
        Label21.Text = invoicefrm.cstGst.Text
        Label22.Text = invoicefrm.cstPan.Text
        Label24.Text = invoicefrm.TextBox2.Text
        Label13.Text = invoicefrm.Invoicedate.Text
        Label27.Text = invoicefrm.TextBox18.Text
        Label28.Text = invoicefrm.TextBox19.Text
        Label29.Text = invoicefrm.TextBox20.Text
        Label32.Text = invoicefrm.cstmText.Text
        Label42.Text = invoicefrm.TextBox22.Text
        Label40.Text = invoicefrm.TextBox23.Text
        Label38.Text = invoicefrm.TextBox24.Text
        Label36.Text = invoicefrm.TextBox25.Text
        Label26.Text = invoicefrm.TextBox21.Text
        Label43.Text = invoicefrm.TextBox1.Text

        Dim row As New DataGridViewRow()
        'Getting the Values from the Datagridview From Invoice Frm'
        For i As Integer = 0 To invoicefrm.invoicegrid.Rows.Count - 1
            row = DirectCast(invoicefrm.invoicegrid.Rows(i).Clone(), DataGridViewRow)
            Dim intColIndex As Integer = 0
            For Each cell As DataGridViewCell In invoicefrm.invoicegrid.Rows(i).Cells
                row.Cells(intColIndex).Value = cell.Value
                intColIndex += 1
            Next
            reciptgrid.Rows.Add(row)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim dlg As New PrintDialog
        If (dlg.ShowDialog() = DialogResult.OK) Then
            PrintForm1.PrinterSettings = dlg.PrinterSettings
            PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        End If

    End Sub

    Private Sub BillsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class