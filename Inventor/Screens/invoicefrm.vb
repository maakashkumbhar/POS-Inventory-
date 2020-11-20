Imports System.Data.OleDb

Public Class invoicefrm
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Akash\documents\visual studio 2010\Projects\Inventor\Inventor\Inturn.accdb"
    Dim conn As New OleDbConnection(constr)
    Dim adtr As New OleDbDataAdapter
    Dim cmd As New OleDbCommand

    Dim str As String
    Dim k As Integer
    Dim A(30) As Integer
    Dim b As Boolean
    Private Sub invoicefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InturnDataSet.Bills' table. You can move, or remove it, as needed.
        Me.BillsTableAdapter.Fill(Me.InturnDataSet.Bills)
        'TODO: This line of code loads data into the 'InturnDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.InturnDataSet.Products)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Invoicedate.ValueChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cstmAddress.TextChanged

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub


    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InturnDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ProductsTableAdapter.SearchQuery(Me.InturnDataSet.Products, TextBox6.Text)
    End Sub

    Private Sub SearchQueryToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchQueryToolStripButton.Click
        Try
            Me.ProductsTableAdapter.SearchQuery(Me.InturnDataSet.Products, Product_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Qty As Integer
        Dim rate As Integer
        Dim Taxable As Integer
        Dim SGST As Decimal
        Dim CGST As Decimal

        If TextBox9.Text = Nothing And TextBox10.Text = Nothing Then
            MsgBox("Please Enter the Quantity and Rate!")
        Else
            Qty = TextBox9.Text
            rate = TextBox10.Text
        End If
        Taxable = Qty * rate
        TextBox11.Text = Qty * rate
        If TextBox12.Text = Nothing And TextBox14.Text = Nothing Then
            MsgBox("Enter The SGST Value and CGST Value!")
        Else
            SGST = TextBox12.Text
            CGST = TextBox14.Text
        End If
        TextBox13.Text = Taxable * SGST / 100
        TextBox16.Text = Taxable * CGST / 100

        If TextBox15.Text = Nothing Or TextBox7.Text = Nothing Or TextBox17.Text = Nothing Or TextBox9.Text = Nothing Or TextBox8.Text = Nothing Or TextBox10.Text = Nothing Or TextBox11.Text = Nothing Or TextBox12.Text = Nothing Or TextBox13.Text = Nothing Or TextBox14.Text = Nothing Or TextBox16.Text = Nothing Then
            MsgBox("Please enter The Required Values!!")
        Else
            Me.invoicegrid.Rows.Add(TextBox15.Text, TextBox7.Text, TextBox17.Text, TextBox9.Text, TextBox8.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox16.Text)
        End If
        TextBox15.Clear()
        TextBox7.Clear()
        TextBox17.Clear()
        TextBox9.Clear()
        TextBox8.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox16.Clear()

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Tax_amt As Decimal
        Dim sgst_amt As Decimal
        Dim cgst_amt As Decimal
        Dim Net_amt As Decimal = 0
        Dim Add_amt As Decimal = 0
        Dim Cn_dn_amt As Decimal = 0
        Dim Round_off As Decimal = 0

        For i = 0 To invoicegrid.Rows.Count - 1
            Tax_amt += invoicegrid.Rows(i).Cells(6).Value
            sgst_amt += invoicegrid.Rows(i).Cells(8).Value
            cgst_amt += invoicegrid.Rows(i).Cells(10).Value
        Next
        TextBox18.Text = Tax_amt
        TextBox19.Text = sgst_amt
        TextBox20.Text = cgst_amt
        If TextBox22.Text = Nothing Or TextBox23.Text = Nothing Or TextBox24.Text = Nothing Then
            Add_amt = 0
            Cn_dn_amt = 0
            Round_off = 0
        Else
            Add_amt = TextBox22.Text
            Cn_dn_amt = TextBox23.Text
            Round_off = TextBox24.Text
        End If
        Net_amt = Add_amt + Cn_dn_amt + Tax_amt + sgst_amt + cgst_amt
        TextBox25.Text = Net_amt

        TextBox21.Text = NumberInWords(Val(TextBox25.Text))
    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox25.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
        MainFrm.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.ProductsTableAdapter.Fill(Me.InturnDataSet.Products)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim product_name As String
        Dim qty As Integer
        If Invoicedate.Text = "" Or cstmText.Text = "" Or cstmAddress.Text = "" Or cstPan.Text = "" Or cstGst.Text = "" Then
            MsgBox("Please Enter the Customer Information And Date!!")
        End If
        Try
            For i = 0 To invoicegrid.Rows.Count - 1
                product_name = invoicegrid.Rows(i).Cells(1).Value
                qty = invoicegrid.Rows(i).Cells(3).Value

                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim query As String = "update Products set Product_Stock = Product_Stock - '" & qty & "' where Product_Name = '" & product_name & "'"
                    cmd = New OleDbCommand(query, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Stock Updated!!")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Validate()
        Me.BillsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InturnDataSet)
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub SearchQueryToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles SearchQueryToolStrip.ItemClicked

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmRecipt.Show()

    End Sub

    Function NumberInWords(ByVal num As String)
        'Constants are Defined
        Dim digit(100) As String
        digit(0) = ""
        digit(1) = "One "
        digit(2) = "Two "
        digit(3) = "Three "
        digit(4) = "Four "
        digit(5) = "Five "
        digit(6) = "Six "
        digit(7) = "Seven "
        digit(8) = "Eight "
        digit(9) = "Nine "
        digit(10) = "Ten "
        digit(11) = "Eleven "
        digit(12) = "Twelve "
        digit(13) = "Thirteen "
        digit(14) = "Fourteen "
        digit(15) = "Fifteen "
        digit(16) = "Sixteen "
        digit(17) = "Seventeen "
        digit(18) = "Eighteen "
        digit(19) = "Ninteen "
        digit(20) = "Twenty "
        digit(30) = "Thirty "
        digit(40) = "Fourty "
        digit(50) = "Fifty "
        digit(60) = "Sixty "
        digit(70) = "Seventy "
        digit(80) = "Eighty "
        digit(90) = "Ninty "
        digit(100) = "Hundred "
        Dim tt(5) As String
        tt(2) = "Thousand "
        tt(3) = "Lakh "
        tt(4) = "Crore "
        tt(5) = "Hundred Crore "
        'Separating the Whole Number and Digits
        Dim nn As String
        Dim dd As String = ""
        nn = Math.Round(Val(num), 2)
        If InStr(nn, ".") <> 0 Then
            dd = Mid(nn, InStr(nn, ".") + 1)
            nn = Mid(nn, 1, InStr(nn, ".") - 1)
        End If
        'Variable nn stores the whole number and dd stores the digits
        'Finding the Word for numbers
        Dim x As Integer
        Dim y As Integer = 0
        x = nn.Length - 1
        Dim z As String
        Dim str As String = ""
        Dim str1 As String = ""
        If x > 1 Then
            While (x > -1)
                'First Loop Last two digits of Number is evaluated(ones and Tens)
                If y = 0 Then
                    z = Mid(nn, x, 2)
                    If Val(z) < 21 And Val(z) > 0 Then
                        str = digit(Val(z))
                    ElseIf Val(z) > 0 Then
                        str = digit(Val(z(0)) * 10)
                        str = str & digit(Val(z(1)))
                    End If
                    x = x - 1
                End If
                'Second Loop 3rd digits of Number is evaluated(Hundred)
                If y = 1 Then
                    z = Mid(nn, x, 1)
                    If Val(z) <> 0 Then
                        str = digit(Val(z)) & "Hundred " & str
                    End If
                    x = x - 2
                End If
                'Subsequent Loop Next two digits sequence of Number is evaluated(Thousands,Lakhs,Crore,etc)
                If y > 1 Then
                    If x <> 0 Then
                        z = Mid(nn, x, 2)
                        If Val(z) < 21 And Val(z) > 0 Then
                            str = digit(Val(z)) & tt(y) & str
                        ElseIf Val(z) > 0 Then
                            str1 = digit(Val(z(0)) * 10)
                            str = str1 & digit(Val(z(1))) & tt(y) & str
                        End If
                        x = x - 2
                    Else
                        z = Mid(nn, 1, 1)
                        If Val(z) < 21 And Val(z) > 0 Then
                            str = digit(Val(z)) & tt(y) & str
                        ElseIf Val(z) > 0 Then
                            str1 = digit(Val(z(0)) * 10)
                            str = str1 & digit(Val(z(1))) & tt(y) & str
                        End If
                        x = -1
                    End If
                End If
                y = y + 1
            End While
        Else
            If Val(nn) < 21 And Val(nn) > 0 Then
                str = digit(Val(nn))
            ElseIf Val(nn) > 0 Then
                str = digit(Val(nn(0)) * 10)
                str = str & digit(Val(nn(1)))
            End If
            'str = digit(nn)
        End If
        If str = "" Then
            str = "Zero "
        End If
        str = str & "Rupees "
        'Digits are evaluated(Paise)
        If Val(dd) > 0 Then
            If dd.Length = 1 Then
                z = Val(dd) * 10
            Else
                z = dd
            End If
            If Val(z) < 21 And Val(z) > 0 Then
                str = str & "and " & digit(Val(z)) & "Paise"
            ElseIf Val(z) > 0 Then
                str1 = digit(Val(z(0)) * 10)
                str = str & "and " & str1 & digit(Val(z(1))) & "Paise"
            End If
        End If
        'Word string is returned
        NumberInWords = str
    End Function
End Class