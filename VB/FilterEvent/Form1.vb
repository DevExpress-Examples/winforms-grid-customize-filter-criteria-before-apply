Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.Data

Namespace FilterEvent
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim ds As New DataSet()
            ds.ReadXml("nwind.xml")
            Me.GridControl.DataSource = ds
            Me.GridControl.DataMember = "Orders"
            Me.GridView.ActiveFilterCriteria = CriteriaOperator.Parse("Freight > 0")
        End Sub

        Private Sub GridView_SubstituteFilter(ByVal sender As Object, ByVal e As SubstituteFilterEventArgs) Handles GridView.SubstituteFilter
            e.Filter = e.Filter And CriteriaOperator.Parse("getyear(OrderDate) = ?", Convert.ToInt32(Me.beiShowByYear.EditValue))
        End Sub

        Private Sub beiShowByYear_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles beiShowByYear.EditValueChanged
            Dim filter As CriteriaOperator = Me.GridView.ActiveFilterCriteria
            Me.GridView.BeginDataUpdate()
            Try
                Me.GridView.ActiveFilterCriteria = Nothing
                Me.GridView.ActiveFilterCriteria = filter
            Finally
                Me.GridView.EndDataUpdate()
            End Try
        End Sub
    End Class
End Namespace
