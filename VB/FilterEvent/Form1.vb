Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.Data

Namespace FilterEvent

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim ds As DataSet = New DataSet()
            ds.ReadXml("nwind.xml")
            GridControl.DataSource = ds
            GridControl.DataMember = "Orders"
            GridView.ActiveFilterCriteria = CriteriaOperator.Parse("Freight > 0")
        End Sub

        Private Sub GridView_SubstituteFilter(ByVal sender As Object, ByVal e As SubstituteFilterEventArgs)
            e.Filter = e.Filter And CriteriaOperator.Parse("getyear(OrderDate) = ?", Convert.ToInt32(beiShowByYear.EditValue))
        End Sub

        Private Sub beiShowByYear_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim filter As CriteriaOperator = GridView.ActiveFilterCriteria
            GridView.BeginDataUpdate()
            Try
                GridView.ActiveFilterCriteria = Nothing
                GridView.ActiveFilterCriteria = filter
            Finally
                GridView.EndDataUpdate()
            End Try
        End Sub
    End Class
End Namespace
