<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/TestGridViewSite81/Default.aspx) (VB: [Default.aspx](./VB/TestGridViewSite81/Default.aspx))
* [Default.aspx.cs](./CS/TestGridViewSite81/Default.aspx.cs) (VB: [Default.aspx](./VB/TestGridViewSite81/Default.aspx))
<!-- default file list end -->
# How to mimic expand buttons behavior manually


<p>The easiest solution to this task is to use templates.  It is necessary to add an <img> element to a column's DataItemTemplate Container and sets its src and onclick attributes using binding expressions.  The attached sample project shows how this can be done.</p>

<br/>


