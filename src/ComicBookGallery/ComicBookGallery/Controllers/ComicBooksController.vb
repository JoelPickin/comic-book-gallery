Imports System
Imports System.Web.Mvc

Public Class ComicBooksController
    Inherits Controller
    Public Function Detail() As ActionResult
        If DateTime.Today.DayOfWeek = DayOfWeek.Monday Then
            Return Redirect("/")
        End If
        Return New ContentResult With {
            .Content = "Hello from the comic books control"
        }
    End Function

End Class
