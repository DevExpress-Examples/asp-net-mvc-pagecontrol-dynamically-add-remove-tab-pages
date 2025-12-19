Imports System
Imports System.Collections.Generic
Imports System.Web.Mvc
Imports E4864.Models

Namespace E4864.Controllers

    Public Class HomeController
        Inherits Controller

        Private Shared counter As Integer

        Public Function Index() As ActionResult
            Return View()
        End Function

        <HttpGet>
        Public Function PageControlPartial() As ActionResult
            Dim data As List(Of TabInfo) = New List(Of TabInfo)()
            data.Add(New TabInfo() With {.Name = Guid.NewGuid().ToString(), .Text = "Tab", .Content = "Tab Content"})
            Session("TabData") = data
            Return PartialView("_PageControlPartial", data)
        End Function

        <HttpPost>
        Public Function PageControlPartial(ByVal command As String, ByVal parameter As String) As ActionResult
            Dim data As List(Of TabInfo) = If(CType(Session("TabData"), List(Of TabInfo)), New List(Of TabInfo)())
            Select Case command
                Case "ADD"
                    data.Add(New TabInfo() With {.Name = Guid.NewGuid().ToString(), .Text = String.Format("Tab {0}", counter), .Content = String.Format("Tab {0} content", counter)})
                    counter += 1
                Case "REMOVE"
                    If data.Count > 1 Then data.RemoveAll(Function(info) Equals(info.Name, parameter))
            End Select

            Session("TabData") = data
            Return PartialView("_PageControlPartial", data)
        End Function
    End Class
End Namespace
