<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128627034/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4119)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Customize filter criteria before applying it

This example handles the [SubstituteFilter](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.SubstituteFilter) event to modify the filter right before it is sent to the DataController. The event allows you to update or replace the filter with a custom filter.

```csharp
private void GridView_SubstituteFilter(object sender, SubstituteFilterEventArgs e) {
    e.Filter &= CriteriaOperator.Parse("getyear(OrderDate) = ?", Convert.ToInt32(this.beiShowByYear.EditValue));
}
private void beiShowByYear_EditValueChanged(object sender, EventArgs e) {
    CriteriaOperator filter = this.GridView.ActiveFilterCriteria;
    this.GridView.BeginDataUpdate();
    try {
        this.GridView.ActiveFilterCriteria = null;
        this.GridView.ActiveFilterCriteria = filter;
    } finally {
        this.GridView.EndDataUpdate();
    }
}
```


## Files to Review

* [Form1.cs](./CS/FilterEvent/Form1.cs) (VB: [Form1.vb](./VB/FilterEvent/Form1.vb))


## See Also

* [Filter DevExpress Data-Aware Controls - WinForms Cheat Sheet](https://supportcenter.devexpress.com/ticket/details/t904977/filter-devexpress-data-aware-controls-winforms-cheat-sheet)
