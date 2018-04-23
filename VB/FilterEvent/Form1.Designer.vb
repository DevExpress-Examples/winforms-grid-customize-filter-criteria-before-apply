Namespace FilterEvent
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.barManager1 = New DevExpress.XtraBars.BarManager()
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.beiShowByYear = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            DirectCast(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' GridControl
            ' 
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
            Me.GridControl.Location = New System.Drawing.Point(0, 36)
            Me.GridControl.MainView = Me.GridView
            Me.GridControl.Margin = New System.Windows.Forms.Padding(4)
            Me.GridControl.Name = "GridControl"
            Me.GridControl.ShowOnlyPredefinedDetails = True
            Me.GridControl.Size = New System.Drawing.Size(552, 401)
            Me.GridControl.TabIndex = 0
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.GridView})
            ' 
            ' GridView
            ' 
            Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colShipName, Me.colOrderDate, Me.colFreight})
            Me.GridView.GridControl = Me.GridControl
            Me.GridView.Name = "GridView"
            ' 
            ' colShipName
            ' 
            Me.colShipName.Caption = "Ship Name"
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            Me.colShipName.Visible = True
            Me.colShipName.VisibleIndex = 0
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.Caption = "Order Date"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateYear
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 1
            ' 
            ' colFreight
            ' 
            Me.colFreight.Caption = "Freight"
            Me.colFreight.FieldName = "Freight"
            Me.colFreight.Name = "colFreight"
            Me.colFreight.Visible = True
            Me.colFreight.VisibleIndex = 2
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.beiShowByYear})
            Me.barManager1.MaxItemId = 1
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1})
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.beiShowByYear)})
            Me.bar1.Text = "Tools"
            ' 
            ' beiShowByYear
            ' 
            Me.beiShowByYear.Caption = "Show by year"
            Me.beiShowByYear.Edit = Me.repositoryItemComboBox1
            Me.beiShowByYear.EditValue = "1994"
            Me.beiShowByYear.Id = 0
            Me.beiShowByYear.Name = "beiShowByYear"
            Me.beiShowByYear.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            Me.beiShowByYear.Width = 100
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() { "1994", "1995", "1996"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(552, 36)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 437)
            Me.barDockControlBottom.Size = New System.Drawing.Size(552, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 36)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 401)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(552, 36)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 401)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(552, 437)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private GridControl As DevExpress.XtraGrid.GridControl
        Private WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private WithEvents beiShowByYear As DevExpress.XtraBars.BarEditItem
        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

    End Class
End Namespace

