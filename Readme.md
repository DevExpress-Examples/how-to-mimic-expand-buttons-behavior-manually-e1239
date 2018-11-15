<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/TestGridViewSite81/Default.aspx) (VB: [Default.aspx.vb](./VB/TestGridViewSite81/Default.aspx.vb))
* [Default.aspx.cs](./CS/TestGridViewSite81/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/TestGridViewSite81/Default.aspx.vb))
<!-- default file list end -->
# How to mimic expand buttons behavior manually


<p>The easiest solution to this task is to use templates.  It is necessary to add an <img> element to a column's DataItemTemplate Container and sets its src and onclick attributes using binding expressions.  The attached sample project shows how this can be done.</p>

<br/>


