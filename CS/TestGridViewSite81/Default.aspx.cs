using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
using System.Collections.Generic;
using DevExpress.Web.ASPxEditors;
using System.Collections.Specialized;
using System.Collections;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Data.Filtering;
using DevExpress.Web.ASPxRoundPanel;
using DevExpress.Web.ASPxMenu;
using System.Threading;
using System.Globalization;
using DevExpress.Web.ASPxPopupControl;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.Web.ASPxNavBar;
using System.Drawing;


public partial class _Default : System.Web.UI.Page {


    protected void Page_Load(object sender, EventArgs e) {
    }

    protected string GetImageIndex(GridViewDataItemTemplateContainer container) {
        ASPxGridView gridView = container.Grid;
        return gridView.DetailRows.IsVisible(container.VisibleIndex) ? "Images/Copy.bmp" : "Images/Dial.bmp";
    }

    protected string GetOnClickEventHandler(GridViewDataItemTemplateContainer container) {
        ASPxGridView gridView = container.Grid;
        if(gridView.DetailRows.IsVisible(container.VisibleIndex))
            return "grid.CollapseDetailRow(" +  container.VisibleIndex + ");";
        else
            return "grid.ExpandDetailRow(" +  container.VisibleIndex + ");";
    }

    protected void ASPxGridView2_BeforePerformDataSelect(object sender, EventArgs e) {
        Session["CategoryID"] = ((ASPxGridView)sender).GetMasterRowKeyValue();

    }
}
