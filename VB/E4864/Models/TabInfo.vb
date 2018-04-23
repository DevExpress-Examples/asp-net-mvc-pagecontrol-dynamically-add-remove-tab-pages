Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace E4864.Models
    Public Class MyTabInfo
        Private privateName As String
        Public Property Name() As String
            Get
                Return privateName
            End Get
            Set(ByVal value As String)
                privateName = value
            End Set
        End Property

        Private privateText As String
        Public Property Text() As String
            Get
                Return privateText
            End Get
            Set(ByVal value As String)
                privateText = value
            End Set
        End Property

        Private privateContent As String
        Public Property Content() As String
            Get
                Return privateContent
            End Get
            Set(ByVal value As String)
                privateContent = value
            End Set
        End Property
    End Class
End Namespace
