<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128553000/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4864)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E4864/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E4864/Controllers/HomeController.vb))
* [TabInfo.cs](./CS/E4864/Models/TabInfo.cs) (VB: [TabInfo.vb](./VB/E4864/Models/TabInfo.vb))
* **[_PageControlPartial.cshtml](./CS/E4864/Views/Home/_PageControlPartial.cshtml)**
* [_TabPartial.cshtml](./CS/E4864/Views/Home/_TabPartial.cshtml)
* [Index.cshtml](./CS/E4864/Views/Home/Index.cshtml)
<!-- default file list end -->
# PageControl - How to dynamically add/remove tab pages
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4864/)**
<!-- run online end -->


<p>This example illustrates how to dynamically add/remove PageControl's tabs on callbacks in MVC.</p><br />
<p>Tab data is passed to the PageControlPartial view as a model and is used to create tabs. Each tab information (its name, text) is stored in the TabInfo(MyTabInfo in VB.NET) class and passed to the TabPartial View as a model. You can expand this class with all required information that should be used in your tabs according to your scenario. To add/remove tabs, use CallbackPanel callbacks.</p>

<br/>


