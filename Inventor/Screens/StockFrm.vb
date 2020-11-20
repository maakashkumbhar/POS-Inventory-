Imports System.Data.OleDb
Public Class StockFrm
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Akash\documents\visual studio 2010\Projects\Inventor\Inventor\Inturn.accdb"
    Dim conn As New OleDbConnection(constr)
    Dim adtr As New OleDbDataAdapter
    Dim cmd As New OleDbCommand

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InturnDataSet)

    End Sub

    Private Sub StockFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InturnDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.InturnDataSet.Products)
        'TODO: This line of code loads data into the 'InturnDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.InturnDataSet.Stock)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do You Want to Add New ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StockBindingSource.AddNew()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        StockBindingSource.RemoveCurrent()
        MsgBox("Records Deleted Succsesfully!!!")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Do You Want to Save Changes?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.StockBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.InturnDataSet)
            MsgBox("New Stock Added!!")
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim query As String = "update Products set Product_Stock = Product_Stock + '" & Integer.Parse(Stock_AmountTextBox.Text) & "' where Product_Name = '" & Product_NameTextBox.Text & "'"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Stock Updated!!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
        MainFrm.Show()
    End Sub

    Private Sub SearchProductsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchProductsToolStripButton.Click
        Try
            Me.ProductsTableAdapter.searchProducts(Me.InturnDataSet.Products, Product_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ProductsTableAdapter.searchProducts(Me.InturnDataSet.Products, TextBox6.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.ProductsTableAdapter.Fill(Me.InturnDataSet.Products)
    End Sub
End Class