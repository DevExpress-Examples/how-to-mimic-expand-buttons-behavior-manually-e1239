Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView
Imports System.Collections.Generic
Imports DevExpress.Web.ASPxEditors
Imports System.Collections.Specialized
Imports System.Collections
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Data.Filtering
Imports DevExpress.Web.ASPxRoundPanel
Imports DevExpress.Web.ASPxMenu
Imports System.Threading
Imports System.Globalization
Imports DevExpress.Web.ASPxPopupControl
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.Web.ASPxNavBar
Imports System.Drawing


Partial Public Class _Default
	Inherits System.Web.UI.Page


	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Function GetImageIndex(ByVal container As GridViewDataItemTemplateContainer) As String
		Dim gridView As ASPxGridView = container.Grid
		If gridView.DetailRows.IsVisible(container.VisibleIndex) Then
			Return "Images/Copy.bmp"
		Else
			Return "Images/Dial.bmp"
		End If
	End Function

	Protected Function GetOnClickEventHandler(ByVal container As GridViewDataItemTemplateContainer) As String
		Dim gridView As ASPxGridView = container.Grid
		If gridView.DetailRows.IsVisible(container.VisibleIndex) Then
			Return "grid.CollapseDetailRow(" & container.VisibleIndex & ");"
		Else
			Return "grid.ExpandDetailRow(" & container.VisibleIndex & ");"
		End If
	End Function

	Protected Sub ASPxGridView2_BeforePerformDataSelect(ByVal sender As Object, ByVal e As EventArgs)
		Session("CategoryID") = (CType(sender, ASPxGridView)).GetMasterRowKeyValue()

	End Sub
End Class
