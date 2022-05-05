' Program Name: Tiny House Builders Database
' Develper:     Paulette Crawford
' Date:         March 28th, 2021
' Purpose:      This application displays information on tiny house builders such as: 
'               the builder id, builder name, email address, tiny house specialty, and if they build on-site;
'               users can add a new record to the database, or delete the record.

Public Class tinyHouseBuilders
    Private Sub BuildersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BuildersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BuildersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TinyHousesDataSet)

    End Sub

    Private Sub tinyHouseBuilders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TinyHousesDataSet.Builders' table. You can move, or remove it, as needed.
        Me.BuildersTableAdapter.Fill(Me.TinyHousesDataSet.Builders)

    End Sub
End Class
