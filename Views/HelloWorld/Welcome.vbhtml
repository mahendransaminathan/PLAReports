﻿@Code
    ViewData("Title") = "Welcome"
End Code

<h2>
    @Code
        For i As Integer = 0 To ViewBag.NumTimes
            @<h3> @ViewBag.Message @i.ToString </h3>
        Next i
End Code
</h2>

