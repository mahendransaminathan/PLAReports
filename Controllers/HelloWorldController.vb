Namespace MvcMovie
    Public Class HelloWorldController
        Inherits System.Web.Mvc.Controller

        Public Function Index() As ActionResult
            'Return "This is my default action..."
            Return View()
        End Function

        Public Function Welcome(ByVal name As String, Optional ByVal numTimes As Integer = 1) As ActionResult
            'Dim message As String = "Hello " & name & ", NumTimes is: " & numTimes
            ViewBag.Message = "Hello " & name
            ViewBag.NumTimes = numTimes
            Return View()
            'Return "" & Server.HtmlEncode(message) & ""
        End Function

    End Class
End Namespace