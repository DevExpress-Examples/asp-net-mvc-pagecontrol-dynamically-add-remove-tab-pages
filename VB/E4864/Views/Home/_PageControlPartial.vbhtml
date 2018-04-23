@Imports E4864.Models
@ModelType List(Of MyTabInfo)
@Html.DevExpress().CallbackPanel(
    Sub(settings)
            settings.Name = "pageControlCallback"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "PageControlPartial"}
            settings.SetContent(
                Sub()
                        Html.DevExpress().PageControl(
                            Sub(pageControlSettings)
                                    pageControlSettings.Name = "pageControl"
                                    pageControlSettings.TabPages.Clear()
                                    For Each info As MyTabInfo In Model
                                        Dim page As MVCxTabPage = pageControlSettings.TabPages.Add(info.Text, info.Name)
                                        page.SetContent(
                                            Sub()
                                                    Html.RenderPartial("_TabPartial", info)
                                            End Sub
                                            )
                                                                                                   
                                        page.SetTabTemplateContent(
                                            Sub(container)
                                                    ViewContext.Writer.Write("<b class='dxtc-text'>")
                                                    ViewContext.Writer.Write(container.TabPage.Text)
                                                    ViewContext.Writer.Write("[<a href='javascript:pageControlCallback.PerformCallback({{ command: ""REMOVE"", parameter: ""{0}""}})'>X</a>]", info.Name)
                                                    ViewContext.Writer.Write("</b>")
                                            End Sub
                                            )
                                    Next info
                                    pageControlSettings.TabPages.Add("+", "new")
                                    pageControlSettings.ClientSideEvents.ActiveTabChanging = "function(s, e) {  if (e.tab.name == 'new') { e.cancel = true;  pageControlCallback.PerformCallback({ command: 'ADD', parameter: ''}); } }"
                            End Sub
                            ).Render()
                End Sub
                )
    End Sub
    ).GetHtml()
